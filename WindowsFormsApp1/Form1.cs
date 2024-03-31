using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog d = new OpenFileDialog();
      d.Filter = "Image Files|*.png;*.jpg|All files(*.*)|*.*";
      if(d.ShowDialog() == DialogResult.OK)
      {
        image = new Bitmap(d.FileName);
        pictureBox1.Image = image;
        pictureBox1.Refresh();
      }

    }

    private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
    {
      InvertFilter filter = new InvertFilter();
      Bitmap res = filter.processImage(image);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void серыйМирToolStripMenuItem_Click(object sender, EventArgs e)
    {
      GrayWorld filter = new GrayWorld();
      Bitmap res = filter.processImage(image);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void линейноеРастяжениеГистограммыToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LinearHistogramStretch filter = new LinearHistogramStretch();
      Bitmap res = filter.processImage(image);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void волныToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Waves filter = new Waves();
      Bitmap res = filter.processImage(image);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void операторПрюиттаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SharpnessFilter filter = new SharpnessFilter();
      Bitmap res = filter.processImage(image);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Dilation filter = new Dilation();
      Bitmap res = filter.processImage(image);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Erosion filter = new Erosion();
      Bitmap res = filter.processImage(image);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Erosion erosion = new Erosion();
      Bitmap res = erosion.processImage(image);
      Dilation dilation = new Dilation();
      res = dilation.processImage(res);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Dilation dilation = new Dilation();
      Bitmap res = dilation.processImage(image);
      Erosion erosion = new Erosion();
      res = erosion.processImage(res);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void gradToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Grad filter = new Grad();
      Bitmap res = filter.processImage(image);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }

    private void медианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MedianFilter filter = new MedianFilter();
      Bitmap res = filter.processImage(image);
      pictureBox1.Image = res;
      pictureBox1.Refresh();
    }
  }
}
