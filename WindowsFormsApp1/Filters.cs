using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApp1
{
  abstract class Filters
  {

    protected abstract Color calculateNewPixelColor(Bitmap src, int x, int y);
    protected abstract void setup(Bitmap source);

    public Bitmap processImage(Bitmap source)
    {
      Bitmap res = new Bitmap(source.Width, source.Height);
      setup(source);
      for (int i = 0; i < source.Width; i++)
      {
        for (int j = 0; j < source.Height; j++)
        {
          res.SetPixel(i, j, calculateNewPixelColor(source, i, j));
        }
      }

      return res;
    }
    public int Clamp(int val, int min, int max)
    {
      if (val < min)
        return min;
      if (val > max)
        return max;
      return val;
    }

  }

  class MatrixFilter : Filters
  {
    protected float[,] kernel = null;
    protected MatrixFilter() { }
    public MatrixFilter(float[,] kernel)
    {
      this.kernel = kernel;
    }

    protected override void setup(Bitmap source) { }

    protected override Color calculateNewPixelColor(Bitmap src, int x, int y)
    {
      int radiusX = kernel.GetLength(0) / 2;
      int radiusY = kernel.GetLength(1) / 2;
      float resR = 0;
      float resG = 0;
      float resB = 0;
      for (int i = -radiusY; i < radiusY; i++)
      {
        for (int j = -radiusX; j < radiusX; j++)
        {
          int idX = Clamp(x + j, 0, src.Width - 1);
          int idY = Clamp(y + i, 0, src.Height - 1);
          Color neib = src.GetPixel(idX, idY);
          resR += neib.R * kernel[j + radiusX, i + radiusY];
          resG += neib.G * kernel[j + radiusX, i + radiusY];
          resB += neib.B * kernel[j + radiusX, i + radiusY];
        }
      }
      return Color.FromArgb(Clamp((int)resR, 0, 255), Clamp((int)resG, 0, 255), Clamp((int)resB, 0, 255));
    }

  }

  class SharpnessFilter : MatrixFilter
  {
    private void createKernel()
    {
      kernel = new float[3, 3];
      kernel[0, 0] = -1; kernel[0, 1] = -1; kernel[0, 2] = -1;
      kernel[1, 0] = -1; kernel[1, 1] = 4; kernel[1, 2] = -1;
      kernel[2, 0] = -1; kernel[2, 1] = -1; kernel[2, 2] = -1;
    }
    public SharpnessFilter()
    {
      createKernel();
    }
  }

  class InvertFilter : Filters
  {
    protected override void setup(Bitmap source) { }
    protected override Color calculateNewPixelColor(Bitmap src, int x, int y)
    {
      Color orig = src.GetPixel(x, y);
      return Color.FromArgb(255 - orig.R, 255 - orig.G, 255 - orig.B);
    }
  }



  class GrayWorld : Filters
  {
    private int R_avg;
    private int G_avg;
    private int B_avg;
    private int Avg;

    protected override void setup(Bitmap source)
    {
      R_avg = 0;
      G_avg = 0;
      B_avg = 0;
      Avg = 0;
      int N = (source.Width + 1) * (source.Height + 1);
      for (int i = 0; i < source.Width; i++)
      {
        for (int j = 0; j < source.Height; j++)
        {
          R_avg += source.GetPixel(i, j).R;
          G_avg += source.GetPixel(i, j).G;
          B_avg += source.GetPixel(i, j).B;
        }
      }
      R_avg /= N;
      G_avg /= N;
      B_avg /= N;
      Avg = (R_avg + G_avg + B_avg) / 3;
    }

    protected override Color calculateNewPixelColor(Bitmap src, int x, int y)
    {
      return Color.FromArgb(Clamp(src.GetPixel(x, y).R * Avg / R_avg, 0, 255), Clamp(src.GetPixel(x, y).G * Avg / G_avg, 0, 255), Clamp(src.GetPixel(x, y).B * Avg / B_avg, 0, 255));
    }
  }
  class LinearHistogramStretch : Filters
  {
    private double Brightness_max;
    private double Brightness_min;

    protected override void setup(Bitmap source)
    {
      Brightness_max = 0;
      Brightness_min = 1;
      int N = (source.Width + 1) * (source.Height + 1);
      double brt;
      for (int i = 0; i < source.Width; i++)
      {
        for (int j = 0; j < source.Height; j++)
        {
          brt = source.GetPixel(i, j).GetBrightness();
          Brightness_max = Brightness_max > brt ? Brightness_max : brt;
          Brightness_min = Brightness_min < brt ? Brightness_min : brt;
        }
      }
    }

    private double f(double y)
    {
      return (y - Brightness_min) * (Brightness_max - Brightness_min);
    }

    protected override Color calculateNewPixelColor(Bitmap src, int x, int y)
    {
      double brt = src.GetPixel(x, y).GetBrightness();
      return Color.FromArgb((int)(src.GetPixel(x, y).R / brt * f(brt)), (int)(src.GetPixel(x, y).G / brt * f(brt)), (int)(src.GetPixel(x, y).B / brt * f(brt)));
    }
  }

  class Waves : Filters
  {
    protected override void setup(Bitmap source){}

    protected override Color calculateNewPixelColor(Bitmap src, int x, int y)
    {
      int k = Clamp(x + (int)(20 * Math.Sin(2 * Math.PI * y / 60)), 0, src.Width - 1);
      int l = y;
      return Color.FromArgb(src.GetPixel(k, l).R, src.GetPixel(k, l).G, src.GetPixel(k, l).B);
    }
  }

  class Dilation
  {
    protected bool[,] B;
    public Bitmap processImage(Bitmap src)
    {
      setup(src);
      Bitmap res = new Bitmap(src.Width, src.Height);
      for (int y = 1; y < src.Height - 1; y++)
      {
        for (int x = 1; x < src.Width - 1; x++)
        {
          double max = 0;
          int i_max = 0;
          int j_max = 0;
          for (int j = -1; j <= 1; j++)
            for (int i = -1; i <= 1; i++)
              if (B[i + 1, j + 1] && (src.GetPixel(x + i, y + j).GetBrightness() > max))
              {
                max = src.GetPixel(x + i, y + j).GetBrightness();
                i_max = i;
                j_max = j;
              }
          res.SetPixel(x, y, Color.FromArgb(src.GetPixel(i_max + x, j_max + y).R, src.GetPixel(i_max + x, j_max + y).G, src.GetPixel(i_max + x, j_max + y).B));
        } 
      }
      return res;
    }

    protected void setup(Bitmap source)
    {
      B = new bool[3, 3];
      B[0, 0] = true; B[0, 1] = true; B[0, 2] = true;
      B[1, 0] = true; B[1, 1] = true; B[1, 2] = true;
      B[2, 0] = true; B[2, 1] = true; B[2, 2] = true;
    }
  }

  class Erosion
  {
    protected bool[,] B;
    public Bitmap processImage(Bitmap src)
    {
      setup(src);
      Bitmap res = new Bitmap(src.Width, src.Height);
      for (int y = 1; y < src.Height - 1; y++)
      {
        for (int x = 1; x < src.Width - 1; x++)
        {
          double min = 1;
          int i_max = 0;
          int j_max = 0;
          for (int j = -1; j <= 1; j++)
            for (int i = -1; i <= 1; i++)
              if (B[i + 1, j + 1] && (src.GetPixel(x + i, y + j).GetBrightness() < min))
              {
                min = src.GetPixel(x + i, y + j).GetBrightness();
                i_max = i;
                j_max = j;
              }
          res.SetPixel(x, y, Color.FromArgb(src.GetPixel(i_max + x, j_max + y).R, src.GetPixel(i_max + x, j_max + y).G, src.GetPixel(i_max + x, j_max + y).B));
        }
      }
      return res;
    }

    protected void setup(Bitmap source)
    {
      B = new bool[3, 3];
      B[0, 0] = true; B[0, 1] = true; B[0, 2] = true;
      B[1, 0] = true; B[1, 1] = true; B[1, 2] = true;
      B[2, 0] = true; B[2, 1] = true; B[2, 2] = true;
    }
  }

  class Grad : Filters
  {
    private Bitmap first, second;
    protected override Color calculateNewPixelColor(Bitmap src, int x, int y)
    {
      return Color.FromArgb(Clamp(Math.Abs(first.GetPixel(x, y).R - second.GetPixel(x, y).R), 0, 255), Clamp(Math.Abs(first.GetPixel(x, y).G - second.GetPixel(x, y).G), 0, 255), Clamp(Math.Abs(first.GetPixel(x, y).B - second.GetPixel(x, y).B), 0, 255));
    }

    protected override void setup(Bitmap source)
    {
      Dilation d = new Dilation();
      Erosion e = new Erosion();
      first = d.processImage(source);
      second = e.processImage(source);
    }
  }

  class MedianFilter
  {
    private Color[] vals;
    
    private bool comp(Color left, Color right)
    {
      return left.GetBrightness() > right.GetBrightness();
    }

    private void swap(int i, int j)
    {
      Color c = vals[i];
      vals[i] = vals[j];
      vals[j] = c;
    }

    private void sort()
    {
      bool f = true;
      while (f)
      {
        f = false;
        for (int i = 0; i < 24; i++)
        {
          if (comp(vals[i], vals[i + 1]))
          {
            f = true;
            swap(i, i + 1);
          }
        }
      }
    }

    public Bitmap processImage(Bitmap src)
    {
      setup(src);
      Bitmap res = new Bitmap(src.Width, src.Height);
      for (int y = 2; y < src.Height - 2; y++)
      {
        for (int x = 2; x < src.Width - 2; x++)
        {

          for (int j = -2; j <= 2; j++)
            for (int i = -2; i <= 2; i++)
            {
              vals[(i + 2) + (j + 2) * 5] = src.GetPixel(x + i, y + j);
            }
          sort();
          res.SetPixel(x, y, vals[12]);
        }
      }
      return res;
    }

    protected void setup(Bitmap source) 
    {
      vals = new Color[25];
    }
  }

}
