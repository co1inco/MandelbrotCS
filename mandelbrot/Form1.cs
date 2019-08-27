using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace mandelbrot
{
    public partial class Form1 : Form
    {
        Bitmap canvase = new Bitmap(750, 750);

        public Form1()
        {
            InitializeComponent();

            CalculateMandelbrot();
 //           CalculateJulia(new ImgNumber());

        }

        public void CalculateMandelbrot()
        {
            double zoom = (double) numericUpDown_zoom.Value;

            double xMin = 0 - zoom + (double) numericUpDown_xOffset.Value;
            double xMax = 0 + zoom + (double) numericUpDown_xOffset.Value;

            double yMin = 0 - zoom - (double) numericUpDown_yOffset.Value;
            double yMax = 0 + zoom - (double)numericUpDown_yOffset.Value;

            int maxIterations = (int) numericUpDown_Iterations.Value;

            for (int i = 0; i < canvase.Width; i++)
            {
                for (int j = 0; j < canvase.Height; j++)
                {
                    double re = map(i, 0, canvase.Width, xMin, xMax);
                    double img = map(j, 0, canvase.Height, yMin, yMax);
                    
                    /*
                    if ((re < 1.01 && re > 0.99) && ((re < 0.01 && re > -0.01) || (img < 0.01 && img > -0.01)) ||
                        (re > -1.01 && re < -0.99) && ((re < 0.01 && re > -0.01) || (img < 0.01 && img > -0.01)) ||
                        (img > -1.01 && img < -0.99) && ((re < 0.01 && re > -0.01) || (img < 0.01 && img > -0.01)) ||
                        (img < 1.01 && img > 0.99) && ((re < 0.01 && re > -0.01) || (img < 0.01 && img > -0.01)))
                    {
                        canvase.SetPixel(i, j, Color.Blue);
                        continue;
                    }
                    else if ((re < 0.01 && re > -0.01) || (img < 0.01 && img > -0.01))
                    {
                        canvase.SetPixel(i, j, Color.Red);
                        continue;
                    }
                    */

                    ImgNumber c = new ImgNumber(re, img);

                    int it = GetExit(new ImgNumber(), c, maxIterations);
                    //int it = GetExit(c, new ImgNumber(0, -1), maxIterations);



                    Color pixelColor = new Color();

                    if (it == -1)
                        pixelColor = Color.Black;
                    else if (it == 1)
                        pixelColor = Color.Gray;
                    else
                    {
                        int colorGrad = (int) map(it, 0, maxIterations, 30, 255);
                        pixelColor = Color.FromArgb(colorGrad, colorGrad, colorGrad);
                    }

                    canvase.SetPixel(i, j, pixelColor);
                }
            }
            this.pictureBox1.Image = canvase;
        }

        public void CalculateJulia(ImgNumber z)
        {

            double zoom = (double)numericUpDown_zoom.Value;

            double xMin = 0 - zoom + (double)numericUpDown_xOffset.Value;
            double xMax = 0 + zoom + (double)numericUpDown_xOffset.Value;

            double yMin = 0 - zoom - (double)numericUpDown_yOffset.Value;
            double yMax = 0 + zoom - (double)numericUpDown_yOffset.Value;

            int maxIterations = (int)numericUpDown_Iterations.Value;

            for (int i = 0; i < canvase.Width; i++)
            {
                for (int j = 0; j < canvase.Height; j++)
                {
                    double re = map(i, 0, canvase.Width, xMin, xMax);
                    double img = map(j, 0, canvase.Height, yMin, yMax);

                    ImgNumber c = new ImgNumber(re, img);

                    //int it = GetExit(new ImgNumber(), c, maxIterations);
                    int it = GetExit(c, z, maxIterations);

                    Color pixelColor = new Color();

                    if (it == -1)
                        pixelColor = Color.Black;
                    else if (it == 1)
                        pixelColor = Color.Gray;
                    else
                    {
                        int colorGrad = (int)map(it, 0, maxIterations, 30, 255);
                        pixelColor = Color.FromArgb(colorGrad, colorGrad, colorGrad);
                    }

                    canvase.SetPixel(i, j, pixelColor);
                }
            }
            this.pictureBox1.Image = canvase;
            
        }

        private int GetExit(ImgNumber start, ImgNumber c, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                if (start.Length() > 2)
                    return i;

                start.Mul(start);
                start.Add(c);
            }

            return -1;

        }

        public double map(double x, double in_min, double in_max, double out_min, double out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }

        private void numericUpDown_zoom_ValueChanged(object sender, EventArgs e)
        {
            CalculateMandelbrot();
        }

        private void numericUpDown_Iterations_ValueChanged(object sender, EventArgs e)
        {
            CalculateMandelbrot();
        }

        private void numericUpDown_xOffset_ValueChanged(object sender, EventArgs e)
        {
            CalculateMandelbrot();
        }

        private void numericUpDown_yOffset_ValueChanged(object sender, EventArgs e)
        {
            CalculateMandelbrot();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = pictureBox1.PointToClient(Cursor.Position);
            if (Control.MouseButtons == MouseButtons.Left && false)
            {
                double re = map(pos.X, 0, canvase.Width, -2, 2);
                double img = map(pos.Y, 0, canvase.Height, -2, 2);

                CalculateJulia(new ImgNumber(re, img));
            }
        }
    }

    public class ImgNumber
    {
        public double Re;
        public double Img;

        public ImgNumber(int re, int img)
        {
            this.Re = re;
            this.Img = img;
        }

        public ImgNumber(double re, double img)
        {
            this.Re = re;
            this.Img = img;
        }

        public ImgNumber(ImgNumber num)
        {
            this.Re = num.Re;
            this.Img = num.Img;
        }

        public ImgNumber()
        {
            this.Re = 0;
            this.Img = 0;
        }

        public void Add(ImgNumber num)
        {
            Re = Re + num.Re;
            Img = Img + num.Img;
        }

        public void Sub(ImgNumber num)
        {
            Re = Re - num.Re;
            Img = Img - num.Img;
        }

        public void Mul(ImgNumber num)
        {
            double newRe = Re * num.Re - Img * num.Img;
            double newImg = Re * num.Img + Img * num.Re;

            this.Re = newRe;
            this.Img = newImg;
        }

        public double Length()
        {
            return Math.Sqrt(Re * Re + Img * Img);
        }
    }

}
