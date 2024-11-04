using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing
{
    public partial class Form2 : Form
    {
        Bitmap imageB, imageA,resultImage;
        public Form2()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = imageA;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Color green = Color.FromArgb(0, 0, 255);
            int greygreen = (green.R + green.G + green.B) / 3;
            int threshold = trackBar1.Value;
            resultImage = new Bitmap(imageA.Width, imageA.Height);

            for (int x = 0; x < imageA.Width; x++)
            {
                for (int y = 0; y < imageA.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);

                    int grey = (pixel.R + pixel.G + backpixel.B) / 3;
                    int subtractValue = Math.Abs(grey - greygreen);

                    if (subtractValue > threshold)
                    {
                        resultImage.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, backpixel);
                    }
                }
            }
            pictureBox3.Image = resultImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color green = Color.FromArgb(0, 0, 255);
            int greygreen = (green.R+green.G+green.B)/3;
            int threshold = 10;
            resultImage = new Bitmap(imageA.Width, imageA.Height);

            for(int x = 0; x < imageA.Width; x++)
            {
                for(int y = 0;y<imageA.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);

                    int grey = (pixel.R + pixel.G + backpixel.B)/3;
                    int subtractValue = Math.Abs(grey - greygreen);

                    if(subtractValue > threshold)
                    {
                        resultImage.SetPixel(x,y,pixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x,y,backpixel);
                    }
                }
            }
            pictureBox3.Image = resultImage;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
                imageB = new Bitmap(openFileDialog2.FileName);
                pictureBox2.Image = imageB;
        }

        
    }
}
