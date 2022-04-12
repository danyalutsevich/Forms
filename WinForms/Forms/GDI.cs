using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class GDI : Form
    {
        #region Timer

        //// https://docs.microsoft.com/en-us/previous-versions/ff728861(v=vs.85)
        //delegate void TimerCallback(UInt32 uTimerID, UInt32 uMsg, ref UInt32 dwUser, UInt32 dw1, UInt32 dw2); // https://docs.microsoft.com/en-us/previous-versions/dd757634(v=vs.85)

        //[DllImport("winmm.dll", SetLastError = true, EntryPoint = "timeSetEvent")]
        //static extern UInt32 TimeSetEvent(UInt32 uDelay, UInt32 uResolution, TimerCallback lpTimeProc, ref UInt32 dwUser, UInt32 eventType);

        //[DllImport("winmm.dll", SetLastError = true, EntryPoint = "timeKillEvent")]
        //static extern void TimeKillEvent(UInt32 uTimerId);

        //const int TIME_ONESHOT = 0;
        //const int TIME_PERIODIC = 1;

        //private uint uDelay, uResolution;

        //UInt32 dwUser = 0;

        //private UInt32 timerId; void Timer_Tick(UInt32 id, UInt32 msg, ref UInt32 userCtx, UInt32 rsv1, UInt32 rsv2)
        //{
        //    Invoke((Action)IncLabel);
        //    TimeKillEvent(timerId);

        //    timerId = TimeSetEvent(uDelay, uResolution, Timer_Tick, ref dwUser, TIME_PERIODIC);
        //}

        //void IncLabel()
        //{
        //    if (!this.IsDisposed) this.Text = (int.Parse(this.Text) + 1).ToString();
        //}

        //private void GDI_Load(object sender, EventArgs e)
        //{
        //    this.Text = "1";
        //    uDelay = 10;
        //    uResolution = 10;
        //    dwUser = 0;

        //    timerId = TimeSetEvent(uDelay, uResolution, Timer_Tick, ref dwUser, TIME_PERIODIC);


        //}

        //private void GDI_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    TimeKillEvent(timerId);
        //}
        #endregion

        Brush MouseBrush;

        Ball ball;

        public int x;
        public int y;
        public int w;
        public int h;


        public static int width { get; set; }
        public static int height { get; set; }

        public GDI()
        {

            MouseBrush = new SolidBrush(Color.Red);

            height = Height;
            width = Width;

            x = this.Width / 2;
            y = this.Height / 2;

            w = 20;
            h = 20;
            ball = new Ball
            {
                Y = y,
                X = x,
                W = w,
                H = h,
                Vx = 2,
                Vy = 2,

            };
            InitializeComponent();
        }

        private void GDI_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void GDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int w = 3000;
            int h = 3000;

            Bitmap bmp = new Bitmap(w, h);


            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
                }
            }

            var graphics = this.CreateGraphics();

            graphics.DrawImage(bmp, 0, 0);

            EncoderParameters eps = new();
            EncoderParameter ep = new(System.Drawing.Imaging.Encoder.Compression,(long)EncoderValue.CompressionLZW);

            eps.Param[0] = ep;

            ImageCodecInfo iCi = GetEncoderInfo("image/tiff");


            bmp.Save("bmp.tiff",iCi, eps);

            pictureBox1.Image = bmp;
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                {
                    return encoders[j];
                }
            }
            return null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Invalidate();
        }

        Rectangle rect;
        Point mouseCoord;
        private void GDI_Paint(object sender, PaintEventArgs e)
        {

            ball.PaintBall(e);
            if (mouseMoved)
            {
                rect.Width = 20;
                rect.Height = 60;
                rect.X = 400;
                rect.Y = mouseCoord.Y;
                e.Graphics.FillRectangle(MouseBrush, rect);


                mouseMoved = false;
            }

        }
        bool mouseMoved = false;

        private void GDI_MouseMove(object sender, MouseEventArgs e)
        {

            mouseMoved = true;
            mouseCoord = e.Location;
        }


        class Ball
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int W { get; set; }
            public int H { get; set; }
            public int Vx { get; set; }
            public int Vy { get; set; }

            Brush clearBrush = new SolidBrush(Color.White);
            Brush ballBrush = new SolidBrush(Color.Aqua);

            Pen clearPen = new Pen(Color.White);
            Pen ballPen = new Pen(Color.Aqua);

            public void Move()
            {
                X += Vx;
                Y += Vy;

                if (X < 0 || X > GDI.width)
                {
                    Vx = -Vx;
                }

                if (Y < 0 || Y > GDI.height)
                {
                    Vy = -Vy;
                }

            }

            public void PaintBall(PaintEventArgs e)
            {
                e.Graphics.FillEllipse(clearBrush, X, Y, H, W);
                e.Graphics.DrawEllipse(clearPen, X, Y, H, W);
                Move();
                e.Graphics.FillEllipse(ballBrush, X, Y, H, W);
                e.Graphics.DrawEllipse(ballPen, X, Y, H, W);
            }
        }

    }
}
