using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamLib;
using ImageProcess2;
using System.Windows.Forms;
namespace Image_Processing
{
    static class BasicDIP
    {
        // turns it to gray scale then performs the contrast cuz takes too much if the color jud
        public static void Equalisation(ref Bitmap a, ref Bitmap b,int degree)
        {
            
            int height = a.Height;
            int width = a.Width;
            int numSamples, histSum; 
            int[] yMap = new int[256];
            int[] hist = new int[256];
            int percent = degree;

            //compute the histogram from the sub image
            Color nakuha;
            Color gray;
            Byte graydata;
            //Convert to grayscale
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    nakuha = a.GetPixel(i, j);
                    graydata = (byte)((nakuha.R + nakuha.G + nakuha.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(i, j, gray);
                }
            }
            // histogram 1d data  -- to remap  the intensity and magnitude whether increase of decrease
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    nakuha = a.GetPixel(i, j);
                    hist[nakuha.B]++;
                }
            }
            //remap the Ys, use the maximum contrast (percent == 100)
            numSamples = (a.Width * a.Height);
            histSum = 0;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    histSum += hist[i];
                    yMap[i] = histSum * 255/numSamples;
                }
            }
            // if ccontrast is not maximum (percent <100) then adjust mapping
            if(percent < 100)
            {
                for (int i = 0; i<256; i++)
                {
                    yMap[i] = i + ((int)yMap[i] - i) * percent / 100;
                }
            }
            b = new Bitmap(width, height);
            for(int i = 0; i < width; i++)
            {
                for(int j = 0;j < height; j++)
                {
                    Color temp = Color.FromArgb(yMap[a.GetPixel(i, j).R], yMap[a.GetPixel(i, j).G], yMap[a.GetPixel(i, j).B]);
                    b.SetPixel(i, j, temp);
                }
            }
        }
        public static void Copy(ref Bitmap a, ref Bitmap b)
        {
            b = new Bitmap(a.Width, a.Height);
            Color pixel;
            for (int i = 0; i < a.Width; i++)
            {
                for (int j = 0; j < a.Height; j++)
                {
                    pixel = a.GetPixel(i, j);
                    b.SetPixel(i, j, pixel);
                }
            }
        }
        // loaded image at a and processed image at b
        public static void Hist(ref Bitmap a, ref Bitmap b)
        {
            Color sample;
            Color gray;
            Byte graydata;


            for (int i = 0; i < a.Width; i++)
            {
                for (int j = 0; j < a.Height; j++)
                {
                    sample = a.GetPixel(i, j);
                    // get the average for the rgb to make it gray
                    graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(i, j, gray);
                }
            }
            int[] histdata = new int[256];
            for (int i = 0; i < a.Width; i++)
            {
                for (int j = 0; j < a.Height; j++)
                {
                    sample = a.GetPixel(i, j);
                    histdata[sample.R]++; // this can be any color property r,g,b
                }
            }
            b = new Bitmap(256, 800); // x is intensity from 0 -255 maximum is 800

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    b.SetPixel(i, j, Color.White); // turn all to white
                }
            }
            // plotting the points based from histdata
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0;j< Math.Min(histdata[i] / 5, b.Height-1); j++) // math.min took histogramdata divide 5 to fit the count of intensity 800
                {
                    b.SetPixel(i, (b.Height - 1) - j, Color.Black);
                }
            }
        }
        public static void Brightness(ref Bitmap a, ref Bitmap b, int value) // the value is what we add to the rgb
        {
            b = new Bitmap(a.Width, a.Height);
            // explore le pixelz
            for (int i = 0; i < a.Width; i++)
            {
                for (int j = 0; j < a.Height; j++)
                {
                    Color temp = a.GetPixel(i, j);
                    // in order to calculate the brightness if nihayag or darken
                    Color changed;
                    //pabright naol bright
                    if (value > 0)
                        changed = Color.FromArgb(Math.Min(temp.R + value, 255), Math.Min(temp.G + value, 255), Math.Min(temp.B + value, 255)); // naay limit to 255 cuz di dapat bright kaayu
                    else
                        changed = Color.FromArgb(Math.Max(temp.R + value, 0), Math.Max(temp.G + value, 0), Math.Max(temp.B + value, 0)); // daapt limit kay 0
                    b.SetPixel(i,j, changed);
                }
            }
        }

        public static void Rotate(ref Bitmap a, ref Bitmap b, int value)
        {
            float angleRadians = (float)(value * Math.PI / 180); // prog languages dont accept by degrees, they accept by radians 
            int xCenter = (int)(a.Width / 2); //  rotate it based on the cener.. get the center then translate it to the upper
            int yCenter = (int)(a.Height / 2);//  left corner cuz naa dira ang (0,0) dili sa tunga
            int width, height, xs, ys, xp, yp, x0, y0;
            float cosA, sinA;
            cosA = (float)Math.Cos(angleRadians);
            sinA = (float)Math.Sin(angleRadians);
            width = a.Width;
            height = a.Height;
            b = new Bitmap(width, height);

            // translate it to 0,0
            for (xp = 0; xp < a.Width; xp++)
            {
                for (yp = 0; yp < a.Height; yp++)
                {
                    // translate around (0,0)
                    x0 = xp - xCenter;
                    y0 = yp - yCenter;
                    // rotate around the origin
                    xs = (int)(x0 * cosA + y0 * sinA);
                    ys = (int)(-x0 * sinA + y0 * cosA);
                    // return it bacl
                    xs = (int)(xs + xCenter);
                    ys = (int)(ys + yCenter);
                    // if mulapas force it at the corner
                    xs = Math.Max(0,Math.Min(width-1,xs));
                    ys = Math.Max(0, Math.Min(height-1,ys));
                    b.SetPixel(xp, yp, a.GetPixel(xs, ys));
                }
            }
        }

        public static void Scale(ref Bitmap a, ref Bitmap b,int nwidth,int nheight)
        {
            //desired width and height
            int targetWidth = nwidth;
            int targetHeight = nheight;
            int xTarget,yTarget,xSource,ySource;
            int width = a.Width;
            int height = a.Height;
            b = new Bitmap(targetWidth,targetHeight);

            for (xTarget = 0; xTarget < targetWidth; xTarget++)
            {
                for (yTarget = 0; yTarget < targetHeight; yTarget++)
                {
                    //formula to scale
                    xSource = yTarget * width / targetWidth;
                    ySource = xTarget * height / targetHeight;
                    b.SetPixel(xTarget,yTarget,a.GetPixel(xSource,ySource));
                }
            }
        }

    }
}
