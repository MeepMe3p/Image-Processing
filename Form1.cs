using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;
using ImageProcess2;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        CameraFeed cameraFeed;
        Bitmap loaded, processed;
        Device []devices;
        int cameraFunction= -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
            
        }



        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Copy(ref loaded, ref processed);
            pictureBox2.Image = processed;

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void grayscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int avg;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    // get the average for the rgb to make it gray
                    avg = (int)(pixel.R + pixel.G + pixel.B)/3 ;
                    Color gray = Color.FromArgb(avg, avg, avg);
                    processed.SetPixel(i, j, gray);
                }
            }
            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    // subtract 255 in rgb to get the inverse
                    Color gray = Color.FromArgb(255-pixel.R, 255-pixel.G, 255-pixel.B);
                    processed.SetPixel(i, j, gray);
                }
            }
            pictureBox2.Image = processed;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Hist(ref loaded, ref processed); // need nay ref so anything function perform is reflected by each bitmap object
            pictureBox2.Image = processed;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // dobol click the form 
            // calls the devices.. 
            devices = DeviceManager.GetAllDevices(); // lists all the devices connected in the device
            Console.WriteLine("the size of devices is"+devices.Length);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(cameraFunction == -1)
                BasicDIP.Brightness(ref loaded, ref processed,trackBar1.Value);
                pictureBox2.Image = processed;
            
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Equalisation(ref loaded, ref processed, trackBar2.Value / 100);
            pictureBox2.Image = processed;
        }

        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    processed.SetPixel((loaded.Width-1)-i, j, pixel);
                }
            }
            pictureBox2.Image = processed;
        }

        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    processed.SetPixel( i, (loaded.Height-1)-j, pixel);
                }
            }
            pictureBox2.Image = processed;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            BasicDIP.Rotate(ref loaded, ref processed, trackBar3.Value);
            pictureBox2.Image = processed;
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Scale(ref loaded, ref processed,100,100);
            pictureBox2.Image = processed;
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //thresholding get the whitish ones and make them full white and blackish to black
            // for very basic edge detection systems
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int avg;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    //get the grayscale
                    avg = (int)(pixel.R + pixel.G + pixel.B) / 3;

                    if(avg < 180) 
                        processed.SetPixel(i, j, Color.Black);
                    else
                        processed.SetPixel(i,j,Color.White);

                }
            }
            pictureBox2.Image = processed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int red, green, blue;
            Color color;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                // haaattps://stackoverflow.com/questions/9448478/what-is-wrong-with-this-sepia-tone-conversion-algorithm/9448635#9448635/
                    pixel = loaded.GetPixel(i, j);
                    red = (int)Math.Min((.393 * pixel.R) + (.769 * pixel.G)+ (.189*pixel.B), 255);
                    green = (int)Math.Min((.349 * pixel.R) + (.685 * pixel.G)+ (.168*pixel.B), 255);
                    blue = (int)Math.Min((.272 * pixel.R) + (.534 * pixel.G)+ (.131*pixel.B), 255);
                    color = Color.FromArgb(red, green, blue);
                    processed.SetPixel(i, j, color);

                }
            }
            pictureBox2.Image = processed;
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.FileName = ".jpg";
            saveFileDialog1.Filter = "jpg files (*.jpg) | *.jpg";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                processed = new Bitmap(loaded.Width, loaded.Height);

                processed.Save(Name, ImageFormat.Png);

            }
            
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //devices[0].ShowWindow(pictureBox1); // gets the first device then puts it on picture box1 ---- itag an2 daw (?)
            cameraFeed = new CameraFeed(pictureBox1);
            cameraFeed.Start();
            

        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //devices[0].Stop(); // stops
            cameraFeed.Stop();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cameraFunction = 1;


        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Bitmap b = new Bitmap(pictureBox1.Image);
            switch (cameraFunction) {
                case 1:
                    BitmapFilter.GrayScale(b);
                    break;
                case 2:
                    BitmapFilter.Contrast(b,(sbyte)trackBar2.Value);
                    break;
                case 3:
                    BitmapFilter.Brightness(b,trackBar1.Value);
                    break;
                case 4:
                    BitmapFilter.Invert(b);
                    break;
                case 5:
                    BasicDIP.Hist(ref b, ref b); // edit meh cuz me slow
                    break;
                case 6:
                    
                    //modify me
                    break;
            }
            pictureBox2.Image = b;
        }

        private void contrastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cameraFunction = 2;
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cameraFunction = 3;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
            cameraFunction = 4;
        }

        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cameraFunction = 5;
        }

        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cameraFunction = 6;
        }

        private void shrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitmapFilter.GaussianBlur(loaded, 4);
            pictureBox2.Image = loaded;
            

        }

        private void shrinkToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConvMatrix m =  new ConvMatrix();
            BitmapFilter.Conv3x3(loaded, m);
            pictureBox2.Image = loaded;
        }

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitmapFilter.Smooth(loaded, 1);
            pictureBox2.Image = loaded;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           BitmapFilter.Sharpen(loaded,11);
            pictureBox2.Image = loaded;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitmapFilter.MeanRemoval(loaded, 9);
            pictureBox2.Image = loaded;
        }

        private void embossLaplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitmapFilter.EmbossLaplacian(loaded);
            pictureBox2.Image = loaded;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(cameraFeed != null)
                cameraFeed.Stop();  
            base.OnFormClosing(e);
        }
    }
}
