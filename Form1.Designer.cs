namespace Image_Processing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIDEOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.convMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossLaplascianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dIPToolStripMenuItem,
            this.subtractToolStripMenuItem,
            this.onToolStripMenuItem,
            this.offToolStripMenuItem,
            this.vIDEOToolStripMenuItem,
            this.convMatrixToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1387, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.saveAsImageToolStripMenuItem.Text = "Save as .jpg";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // dIPToolStripMenuItem
            // 
            this.dIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelCopyToolStripMenuItem,
            this.grayscalingToolStripMenuItem,
            this.inversionToolStripMenuItem,
            this.mirrorHorizontalToolStripMenuItem,
            this.mirrorVerticalToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.binaryToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            this.dIPToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            this.pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            this.pixelCopyToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.pixelCopyToolStripMenuItem.Text = "Pixel Copy";
            this.pixelCopyToolStripMenuItem.Click += new System.EventHandler(this.pixelCopyToolStripMenuItem_Click);
            // 
            // grayscalingToolStripMenuItem
            // 
            this.grayscalingToolStripMenuItem.Name = "grayscalingToolStripMenuItem";
            this.grayscalingToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.grayscalingToolStripMenuItem.Text = "Grayscaling";
            this.grayscalingToolStripMenuItem.Click += new System.EventHandler(this.grayscalingToolStripMenuItem_Click);
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // mirrorHorizontalToolStripMenuItem
            // 
            this.mirrorHorizontalToolStripMenuItem.Name = "mirrorHorizontalToolStripMenuItem";
            this.mirrorHorizontalToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.mirrorHorizontalToolStripMenuItem.Text = "Mirror Horizontal";
            this.mirrorHorizontalToolStripMenuItem.Click += new System.EventHandler(this.mirrorHorizontalToolStripMenuItem_Click);
            // 
            // mirrorVerticalToolStripMenuItem
            // 
            this.mirrorVerticalToolStripMenuItem.Name = "mirrorVerticalToolStripMenuItem";
            this.mirrorVerticalToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.mirrorVerticalToolStripMenuItem.Text = "Mirror Vertical";
            this.mirrorVerticalToolStripMenuItem.Click += new System.EventHandler(this.mirrorVerticalToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.subtractToolStripMenuItem.Text = "Subtract";
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.subtractToolStripMenuItem_Click);
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.onToolStripMenuItem.Text = "on";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.offToolStripMenuItem.Text = "off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // vIDEOToolStripMenuItem
            // 
            this.vIDEOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.contrastToolStripMenuItem1,
            this.brightnessToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.histogramToolStripMenuItem1,
            this.sepiaToolStripMenuItem1});
            this.vIDEOToolStripMenuItem.Name = "vIDEOToolStripMenuItem";
            this.vIDEOToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.vIDEOToolStripMenuItem.Text = "VIDEO";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem1
            // 
            this.contrastToolStripMenuItem1.Name = "contrastToolStripMenuItem1";
            this.contrastToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.contrastToolStripMenuItem1.Text = "Contrast";
            this.contrastToolStripMenuItem1.Click += new System.EventHandler(this.contrastToolStripMenuItem1_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.copyToolStripMenuItem.Text = "Color Inversion";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem1
            // 
            this.histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            this.histogramToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.histogramToolStripMenuItem1.Text = "Histogram";
            this.histogramToolStripMenuItem1.Click += new System.EventHandler(this.histogramToolStripMenuItem1_Click);
            // 
            // sepiaToolStripMenuItem1
            // 
            this.sepiaToolStripMenuItem1.Name = "sepiaToolStripMenuItem1";
            this.sepiaToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.sepiaToolStripMenuItem1.Text = "Sepia";
            this.sepiaToolStripMenuItem1.Click += new System.EventHandler(this.sepiaToolStripMenuItem1_Click);
            // 
            // convMatrixToolStripMenuItem
            // 
            this.convMatrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianBlurToolStripMenuItem,
            this.shrinkToolStripMenuItem,
            this.smoothingToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.meanRemovalToolStripMenuItem,
            this.embossLaplascianToolStripMenuItem});
            this.convMatrixToolStripMenuItem.Name = "convMatrixToolStripMenuItem";
            this.convMatrixToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.convMatrixToolStripMenuItem.Text = "Conv Matrix";
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // shrinkToolStripMenuItem
            // 
            this.shrinkToolStripMenuItem.Name = "shrinkToolStripMenuItem";
            this.shrinkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shrinkToolStripMenuItem.Text = "Shrink";
            this.shrinkToolStripMenuItem.Click += new System.EventHandler(this.shrinkToolStripMenuItem_Click_1);
            // 
            // smoothingToolStripMenuItem
            // 
            this.smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
            this.smoothingToolStripMenuItem.Click += new System.EventHandler(this.smoothingToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // meanRemovalToolStripMenuItem
            // 
            this.meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            this.meanRemovalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.meanRemovalToolStripMenuItem.Text = "Mean Removal";
            this.meanRemovalToolStripMenuItem.Click += new System.EventHandler(this.meanRemovalToolStripMenuItem_Click);
            // 
            // embossLaplascianToolStripMenuItem
            // 
            this.embossLaplascianToolStripMenuItem.Name = "embossLaplascianToolStripMenuItem";
            this.embossLaplascianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.embossLaplascianToolStripMenuItem.Text = "Emboss Laplascian";
            this.embossLaplascianToolStripMenuItem.Click += new System.EventHandler(this.embossLaplascianToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(707, 101);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(629, 555);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar1.Location = new System.Drawing.Point(89, 33);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = -50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(277, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "brightness";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Contrast";
            // 
            // trackBar2
            // 
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar2.Location = new System.Drawing.Point(437, 32);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(277, 56);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Value = 50;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(716, 32);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "rotate";
            // 
            // trackBar3
            // 
            this.trackBar3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar3.Location = new System.Drawing.Point(789, 32);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar3.Maximum = 360;
            this.trackBar3.Minimum = -360;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(277, 56);
            this.trackBar3.TabIndex = 7;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 730);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscalingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorVerticalToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIDEOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem convMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanRemovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossLaplascianToolStripMenuItem;
    }
}

