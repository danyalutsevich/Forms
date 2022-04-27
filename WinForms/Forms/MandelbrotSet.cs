using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinForms.Forms
{
    public partial class MandelbrotSetForm : Form
    {
        public MandelbrotSetForm()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBoxFractal.Width, pictureBoxFractal.Height);
        }

        private void MandelbrotSetForm_Load(object sender, EventArgs e)
        {
            labelZoom.Text = "Zoom: " + Zoom.ToString();
            labelIterations.Text = "Iterations: " + MaxIterations.ToString();
            textBoxPow.Enabled = false;
        }
        
        private Color[] colors = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(66,30,15),
            Color.FromArgb(25, 7, 26),
            Color.FromArgb(9, 1, 47),
            Color.FromArgb(4, 4, 73),
            Color.FromArgb(0, 7, 100),
            Color.FromArgb(12, 44, 138),
            Color.FromArgb(24, 82, 177),
            Color.FromArgb(57, 125, 209),
            Color.FromArgb(134, 181, 229),
            Color.FromArgb(211, 236, 248),
            Color.FromArgb(241, 233, 191),
            Color.FromArgb(248, 201, 95),
            Color.FromArgb(255, 170, 0),
            Color.FromArgb(204, 128, 0),
            Color.FromArgb(153, 87, 0),
            Color.FromArgb(106, 52, 3),
        };

        private Bitmap bitmap;

        private int MaxIterations = 100;
        private double Zoom = 0.8;
        private float Cx = 0;
        private float Cy = 0;
        private float Mx = 0;
        private float My = 0;

        private Complex C;

        private float Map(float value, float min1, float max1, float min2, float max2)
        {
            return (min2 + (value - min1) * (max2 - min2) / (max1 - min1));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void Draw(int pow)
        {
            C = new Complex { Im = Cy, Re = Cx };

            for (int i = 0; i < pictureBoxFractal.Width; i++)
            {
                for (int j = 0; j < pictureBoxFractal.Height; j++)
                {

                    CalculateComplex(i, j, pow);

                }
            }

            pictureBoxFractal.Image = bitmap;
        }

        private void CalculateComplex(int i, int j, int pow)
        {

            // calculate the point in the complex plane
            var Z = new Complex
            {
                Im = Map(j, 0, pictureBoxFractal.Height, -2, 2),
                Re = Map(i, 0, pictureBoxFractal.Width, -2, 2)
            };

            int n = 0;

            do
            {
                n++;
                Z = Z.Pow(pow) + C;

            } while (n < MaxIterations && Z.Abs < 4);

            // set color of pixel
            var color = (int)Map(n, 0, MaxIterations, 0, 255);
            bitmap.SetPixel(i, j, Color.FromArgb(color, color, color));
        }

        private async Task DrawAsync(int pow)
        {
            C = new Complex { Im = Cy, Re = Cx };

            List<Task<int>> tasks = new List<Task<int>>();

            for (int i = 0; i < pictureBoxFractal.Width; i++)
            {
                for (int j = 0; j < pictureBoxFractal.Height; j++)
                {

                    tasks.Add(CalculateComplexAsync(new Coord { x = i, y = j, pow = pow }));

                }
            }


            for (int i = 0; i < pictureBoxFractal.Width; i++)
            {
                for (int j = 0; j < pictureBoxFractal.Height; j++)
                {
                    var color = await tasks[i * pictureBoxFractal.Height + j];
                    bitmap.SetPixel(i, j, Color.FromArgb(color, color, color));

                }
            }

            pictureBoxFractal.Image = bitmap;
        }

        private async Task<int> CalculateComplexAsync(object cord)
        {
            return await Task.Run(() =>
            {
                Coord coord = (Coord)cord;

                int i = coord.x;
                int j = coord.y;

                // calculate the point in the complex plane
                var Z = new Complex
                {
                    Im = Map(j, 0, pictureBoxFractal.Height, -2, 2),
                    Re = Map(i, 0, pictureBoxFractal.Width, -2, 2)
                };

                int n = 0;

                do
                {
                    n++;
                    Z = Z.Pow(coord.pow) + C;

                } while (n < MaxIterations && Z.Abs < 4);

                // set color of pixel
                var color = (int)Map(n, 0, MaxIterations, 0, 255);
                return color;
            });

        }

        private void DrawWithPool(int pow)
        {
            C = new Complex { Im = Cy, Re = Cx };

            for (int i = 0; i < pictureBoxFractal.Width; i++)
            {
                for (int j = 0; j < pictureBoxFractal.Height; j++)
                {
                    ThreadPool.QueueUserWorkItem(CalculateComplexWithPool, new Coord { x = i, y = j, pow = pow });
                }
            }
            while (Process.GetCurrentProcess().Threads.Count > 15)
            {
                Thread.Sleep(100);
            }
            pictureBoxFractal.Image = bitmap;
        }

        private void CalculateComplexWithPool(object cord)
        {
            Coord coord = (Coord)cord;

            int i = coord.x;
            int j = coord.y;

            // calculate the point in the complex plane
            var Z = new Complex
            {
                Im = Map(j, 0, pictureBoxFractal.Height, -2, 2),
                Re = Map(i, 0, pictureBoxFractal.Width, -2, 2)
            };

            int n = 0;

            do
            {
                n++;
                Z = Z.Pow(coord.pow) + C;

            } while (n < MaxIterations && Z.Abs < 4);

            // set color of pixel
            var color = (int)Map(n, 0, MaxIterations, 0, 255);

            lock (bitmap)
            {
                bitmap.SetPixel(i, j, Color.FromArgb(color, color, color));
            }
        }

        private void DrawWithZoom(int pow)
        {

            C = new Complex { Im = Cy, Re = Cx };

            for (int i = 0; i < pictureBoxFractal.Width; i++)
            {
                for (int j = 0; j < pictureBoxFractal.Height; j++)
                {

                    CalculateComplexWithZoom(i, j, pow);

                }
            }

            pictureBoxFractal.Image = bitmap;

        }

        private void CalculateComplexWithZoom(int i, int j, int pow)
        {
            // calculate the point in the complex plane
            var Z = new Complex
            {
                Im = Map(j, 0, pictureBoxFractal.Height, -2, 2) * Zoom+My,
                Re = Map(i, 0, pictureBoxFractal.Width, -2, 2) * Zoom+Mx
            };

            int n = 0;

            do
            {
                n++;
                Z = Z.Pow(pow) + C;

            } while (n < MaxIterations && Z.Abs < 4);

            // set color of pixel
            var color = (int)Map(n, 0, MaxIterations, 0, colors.Length - 1);
            bitmap.SetPixel(i, j, colors[color]);

        }

        private void pictureBoxFractal_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBoxFractal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Cx = Map(e.X, 0, pictureBoxFractal.Width, -2, 2);
                Cy = Map(e.Y, 0, pictureBoxFractal.Height, -2, 2);

                //Cx = 0.415f;
                //Cy = 0.311f;

                labelCx.Text = "Cx: " + Cx.ToString("0.000");
                labelCy.Text = "Cy: " + Cy.ToString("0.000");

                Task.Run(() => { DrawWithZoom(Convert.ToInt32(textBoxPow.Text)); });

            }
        }

        private void MandelbrotSetForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Zoom -= 0.01;
                labelZoom.Text = Zoom.ToString("0.00");
            }
            else if (e.KeyCode == Keys.Right)
            {
                Zoom += 0.01;
                labelZoom.Text = Zoom.ToString("0.00");
            }
            else if (e.KeyCode == Keys.Up)
            {
                MaxIterations++;
                labelIterations.Text = "Iterations: " + MaxIterations.ToString();
            }
            else if (e.KeyCode == Keys.Down)
            {
                MaxIterations--;
                labelIterations.Text = "Iterations: " + MaxIterations.ToString();
            }
            else if (e.KeyCode == Keys.W)
            {
                My -= 0.01f;
            }
            else if (e.KeyCode == Keys.S)
            {
                My += 0.01f;
            }
            else if (e.KeyCode == Keys.A)
            {
                Mx += 0.01f;
            }
            else if (e.KeyCode == Keys.D)
            {
                Mx -= 0.01f;
            }

            else if (e.KeyCode == Keys.P)
            {
                textBoxPow.Enabled = !textBoxPow.Enabled;
            }
            else if(e.KeyCode == Keys.S)
            {
                bitmap.Save("fractal.png");
            }

            Task.Run(() => { DrawWithZoom(Convert.ToInt32(textBoxPow.Text)); });

        }

        private void textBoxPow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                textBoxPow.Enabled = false;
            }
        }
    }

    class Coord
    {
        public int x { get; set; }
        public int y { get; set; }
        public int pow { get; set; }
    }

    class Complex
    {

        public double Re { get; set; }
        public double Im { get; set; }

        public double Abs
        {
            get => Math.Sqrt(Re * Re + Im * Im);
        }

        public Complex Pow(int n)
        {
            Complex result = this;

            for (int i = 0; i < n - 1; i++)
            {
                result *= this;
            }

            return result;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex
            {
                Re = a.Re + b.Re,
                Im = a.Im + b.Im
            };
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex
            {
                Re = a.Re * b.Re - a.Im * b.Im,
                Im = a.Re * b.Im + a.Im * b.Re
            };
        }

    }

}
