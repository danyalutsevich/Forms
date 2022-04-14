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

        // https://docs.microsoft.com/en-us/previous-versions/ff728861(v=vs.85)
        delegate void TimerCallback(UInt32 uTimerID, UInt32 uMsg, ref UInt32 dwUser, UInt32 dw1, UInt32 dw2); // https://docs.microsoft.com/en-us/previous-versions/dd757634(v=vs.85)

        [DllImport("winmm.dll", SetLastError = true, EntryPoint = "timeSetEvent")]
        static extern UInt32 TimeSetEvent(UInt32 uDelay, UInt32 uResolution, TimerCallback lpTimeProc, ref UInt32 dwUser, UInt32 eventType);

        [DllImport("winmm.dll", SetLastError = true, EntryPoint = "timeKillEvent")]
        static extern void TimeKillEvent(UInt32 uTimerId);

        const int TIME_ONESHOT = 0;
        const int TIME_PERIODIC = 1;

        private uint uDelay, uResolution;

        UInt32 dwUser = 0;

        TimerCallback timerCallback;
        GCHandle timerHandle;
        private UInt32 timerId; void Timer_Tick(UInt32 id, UInt32 msg, ref UInt32 userCtx, UInt32 rsv1, UInt32 rsv2)
        {
            if (!this.IsDisposed) Invoke((Action)IncLabel);

        }

        void IncLabel()
        {
            if (!this.IsDisposed) this.Text = (int.Parse(this.Text) + 1).ToString();
        }

        private void TimerStart()
        {
            this.Text = "1";
            uDelay = 10;
            uResolution = 10;
            dwUser = 0;
            timerCallback = new TimerCallback(Timer_Tick);
            timerHandle = GCHandle.Alloc(timerCallback);


            timerId = TimeSetEvent(uDelay, uResolution, timerCallback, ref dwUser, TIME_PERIODIC);
        }

        private void StopTimer()
        {
            TimeKillEvent(timerId);
            timerHandle.Free();
        }


        #endregion

        Brush MouseBrush;

        List<Ball> balls;
        Rocket rocket;

        Stopwatch timer;

        public static GDI clone;
        public static Random rand;

        public bool Stop = false;

        public GDI(Random random)
        {
            InitializeComponent();

            timer = Stopwatch.StartNew();
            rand = random;

            MouseBrush = new SolidBrush(Color.Red);

            clone = this;

            rocket = new Rocket
            {
                H = 20,
                W = 100,
                V = 15,
                X = Width / 2
            };

            balls = new List<Ball>();

            int ballsAmount = rand.Next(30);

            for (int i = 0; i < ballsAmount; i++)
            {
                balls.Add(new Ball
                {
                    //61 so it wont cover score panel
                    Y = rand.Next(61,clone.Height - 50),
                    X = rand.Next(clone.Width),
                    W = 20,
                    H = 20,
                    // Vertical speed can't be less then 3,
                    // Prevent constantly moving balls
                    Vx = rand.Next(3,10),
                    Vy = rand.Next(3,10),


                });
            }

        }

        private void GDI_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //TimerStart();
        }

        private void GDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            //StopTimer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int w = 300;
            int h = 300;

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
            EncoderParameter ep = new(System.Drawing.Imaging.Encoder.Compression, (long)EncoderValue.CompressionLZW);

            eps.Param[0] = ep;

            ImageCodecInfo iCi = GetEncoderInfo("image/tiff");


            bmp.Save("bmp.tiff", iCi, eps);

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


        static Point mouseCoord;
        int losed = 0;
        int score = 0;

        private void GDI_Paint(object sender, PaintEventArgs e)
        {

            foreach (var ball in balls)
            {
                if (!Stop)
                {
                    ball.Move();
                }

                ball.PaintBall(e);
            }


            if (mouseMoved)
            {
                rocket.MouseMove(e.Graphics);
                mouseMoved = false;
            }

            rocket.KeyBoardMove(e.Graphics);


            //Rocket collision
            Ball toRemove = null;

            foreach (var ball in balls)
            {

                if (ball.Y >= rocket.Y + rocket.H)
                {
                    toRemove = ball;
                }

                else if (ball.Y + ball.H >= rocket.Y &&
                     ball.Y + ball.H <= rocket.Y + rocket.H)
                {
                    if (ball.X + ball.W / 2 >= rocket.X &&
                        ball.X + ball.W / 2 <= rocket.X + rocket.W)
                    {
                        score++;

                        ball.Vy = -ball.Vy;
                    }


                }

            }
            if (toRemove != null)
            {
                losed++;
                balls.Remove(toRemove);
            }
            if (balls.Count <= 0)
            {
                MessageBox.Show("Game Over");
                timerAddBall.Stop();
            }

            var time = TimeSpan.FromMilliseconds(timer.ElapsedMilliseconds);

            label1.Text = score.ToString();
            label2.Text = losed.ToString();
            label3.Text = $"{time.Hours}:{time.Minutes}:{time.Seconds}";
        }

        static RocketDirection rocketDirection;

        bool mouseMoved = false;

        private void GDI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                rocketDirection = RocketDirection.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                rocketDirection = RocketDirection.Right;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (Stop)
                {
                    timerAddBall.Start();
                }
                else
                {
                    timerAddBall.Stop();
                }
                Stop = !Stop;
            }
        }

        private void GDI_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && rocketDirection == RocketDirection.Left)
            {
                rocketDirection = RocketDirection.None;
            }
            else if (e.KeyCode == Keys.Right && rocketDirection == RocketDirection.Right)
            {
                rocketDirection = RocketDirection.None;
            }

        }

        private void GDI_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoved = true;
            mouseCoord = e.Location;
        }

        private void timerAddBall_Tick(object sender, EventArgs e)
        {
            //Adding new Ball every Tick
            balls.Add(new Ball
            {
                Y = rand.Next(clone.Height / 2),
                X = rand.Next(clone.Width / 2),
                W = 20,
                H = 20,
                Vx = rand.Next(10),
                Vy = rand.Next(10),
            });
        }

        class Ball
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int W { get; set; }
            public int H { get; set; }
            public int Vx { get; set; }
            public int Vy { get; set; }
            public Color color { get; set; }

            Brush clearBrush;
            Brush ballBrush;
            Pen clearPen;
            Pen ballPen;

            public Ball()
            {
                color = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
                clearBrush = new SolidBrush(Color.White);
                ballBrush = new SolidBrush(color);

                clearPen = new Pen(Color.White);
                ballPen = new Pen(color);
            }

            public void Move()
            {
                X += Vx;
                Y += Vy;

                if (X < 0)
                {
                    Vx = -Vx;
                }

                if (Y < 60)
                {
                    Vy = -Vy;
                }

                if (X + W >= GDI.clone.Width)
                {
                    Vx = -Vx;
                }

            }

            public void PaintBall(PaintEventArgs e)
            {
                //e.Graphics.FillEllipse(clearBrush, X, Y, H, W);
                //e.Graphics.DrawEllipse(clearPen, X, Y, H, W);
                //Move();
                e.Graphics.FillEllipse(ballBrush, X, Y, H, W);
                e.Graphics.DrawEllipse(ballPen, X, Y, H, W);
            }
        }

        enum RocketDirection
        {
            None,
            Left,
            Right,
        }
        
        class Rocket
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int V { get; set; }
            public int W { get; set; }
            public int H { get; set; }

            public Brush Brush { get; set; }
            public Brush CrearBrush { get; set; }

            public Rectangle rect;

            public Rocket()
            {
                Brush = new SolidBrush(Color.Green);
                CrearBrush = new SolidBrush(Color.White);
                Y = 440;
            }

            public void MouseMove(Graphics g)
            {
                if (rocketDirection == RocketDirection.None)
                {
                    g.FillRectangle(CrearBrush, rect);
                    rect.Width = W;
                    rect.Height = H;
                    X = mouseCoord.X;
                    rect.X = X;
                    rect.Y = Y;
                    g.FillRectangle(Brush, rect);

                }

            }

            public void KeyBoardMove(Graphics g)
            {

                if (rocketDirection == RocketDirection.Left)
                {
                    X -= V;
                    rect.X = X;

                }
                else if (rocketDirection == RocketDirection.Right)
                {
                    X += V;
                    rect.X = X;
                }


                g.FillRectangle(Brush, rect);
            }

        }

    }
}
