using System.Drawing;

namespace WindowsFormsApp1
{
  partial class Form1
  {
    Bitmap image;
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.линейноеРастяжениеГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.операторПрюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.матМорфологииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(12, 33);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(1177, 663);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1201, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // открытьToolStripMenuItem
      // 
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
      // 
      // фильтрыToolStripMenuItem
      // 
      this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.матМорфологииToolStripMenuItem,
            this.медианныйФильтрToolStripMenuItem});
      this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
      this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
      this.фильтрыToolStripMenuItem.Text = "Фильтры";
      // 
      // точечныеToolStripMenuItem
      // 
      this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.серыйМирToolStripMenuItem,
            this.линейноеРастяжениеГистограммыToolStripMenuItem,
            this.волныToolStripMenuItem});
      this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
      this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.точечныеToolStripMenuItem.Text = "Точечные";
      // 
      // инверсияToolStripMenuItem
      // 
      this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
      this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.инверсияToolStripMenuItem.Text = "Инверсия";
      this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
      // 
      // матричныеToolStripMenuItem
      // 
      this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операторПрюиттаToolStripMenuItem});
      this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
      this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.матричныеToolStripMenuItem.Text = "Матричные";
      // 
      // серыйМирToolStripMenuItem
      // 
      this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
      this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.серыйМирToolStripMenuItem.Text = "Серый Мир";
      this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
      // 
      // линейноеРастяжениеГистограммыToolStripMenuItem
      // 
      this.линейноеРастяжениеГистограммыToolStripMenuItem.Name = "линейноеРастяжениеГистограммыToolStripMenuItem";
      this.линейноеРастяжениеГистограммыToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
      this.линейноеРастяжениеГистограммыToolStripMenuItem.Text = "Линейное растяжение Гистограммы";
      this.линейноеРастяжениеГистограммыToolStripMenuItem.Click += new System.EventHandler(this.линейноеРастяжениеГистограммыToolStripMenuItem_Click);
      // 
      // волныToolStripMenuItem
      // 
      this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
      this.волныToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
      this.волныToolStripMenuItem.Text = "Волны";
      this.волныToolStripMenuItem.Click += new System.EventHandler(this.волныToolStripMenuItem_Click);
      // 
      // операторПрюиттаToolStripMenuItem
      // 
      this.операторПрюиттаToolStripMenuItem.Name = "операторПрюиттаToolStripMenuItem";
      this.операторПрюиттаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.операторПрюиттаToolStripMenuItem.Text = "Резкость";
      this.операторПрюиттаToolStripMenuItem.Click += new System.EventHandler(this.операторПрюиттаToolStripMenuItem_Click);
      // 
      // матМорфологииToolStripMenuItem
      // 
      this.матМорфологииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.gradToolStripMenuItem});
      this.матМорфологииToolStripMenuItem.Name = "матМорфологииToolStripMenuItem";
      this.матМорфологииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.матМорфологииToolStripMenuItem.Text = "Мат Морфологии";
      // 
      // dilationToolStripMenuItem
      // 
      this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
      this.dilationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.dilationToolStripMenuItem.Text = "Dilation";
      this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
      // 
      // erosionToolStripMenuItem
      // 
      this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
      this.erosionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.erosionToolStripMenuItem.Text = "Erosion";
      this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.closeToolStripMenuItem.Text = "Close";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // gradToolStripMenuItem
      // 
      this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
      this.gradToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.gradToolStripMenuItem.Text = "Grad";
      this.gradToolStripMenuItem.Click += new System.EventHandler(this.gradToolStripMenuItem_Click);
      // 
      // медианныйФильтрToolStripMenuItem
      // 
      this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
      this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
      this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1201, 708);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеГистограммыToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem операторПрюиттаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem матМорфологииToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem;
  }
}

