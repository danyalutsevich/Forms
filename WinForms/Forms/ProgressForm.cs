using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class ProgressForm : Form
    {
        private NLog.Logger logger { get; set; }
        private Random random { get; set; }
        private bool stopPressed { get; set; }
        private int progressState { get; set; }
        private string progressTimeText { get; set; }
        private int progressMaximum { get; set; }
        private bool progressContinue { get; set; }
        private bool progressReverse { get; set; }

        CancellationTokenSource cts { get; set; }

        public ProgressForm(NLog.Logger loger, Random random)
        {
            stopPressed = false;
            progressContinue = false;
            progressReverse = false;
            this.logger = loger;
            this.random = random;
            cts = null!;

            InitializeComponent();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressMaximum = 100;

            comboBoxStyles.Items.Add(new BarStyle { color = Color.Green, name = "Green" });
            comboBoxStyles.Items.Add(new BarStyle { color = Color.Red, name = "Red" });
            comboBoxStyles.Items.Add(new BarStyle { color = Color.Yellow, name = "Yellow" });
            comboBoxStyles.SelectedIndex = 0;

            ProgressTime.Items.Add(1000d);
            ProgressTime.Items.Add(2000d);
            ProgressTime.Items.Add(4000d);
            ProgressTime.SelectedIndex = 0;

            buttonContinue.Enabled = false;
            buttonReverse.Enabled = false;
            buttonStop.Enabled = false;
        }

        private void comboBoxStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(progressBar, comboBoxStyles.SelectedIndex + 1);
        }

        private void UpdateProgress()
        {
            progressBar.Value = progressState;
        }

        private void UpdateTimeText()
        {
            WokringTime.Text = progressTimeText;
        }

        private void StartHandler(object o)
        {
            if (o is not CancellationToken)
            {
                return;
            }

            CancellationToken cts = (CancellationToken)o;

            buttonRun.Enabled = false;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            buttonContinue.Enabled = false;
            buttonReverse.Enabled = false;

            if (!progressContinue)
            {
                progressBar.Value = progressBar.Minimum;
            }
            progressContinue = false;



            for (int i = progressBar.Value; i <= progressBar.Maximum; i++)
            {
                if (cts.IsCancellationRequested) break;

                //this.Invoke(new Action(() => {
                //progressBar.Value = i;
                //}));

                progressState = i;
                this.Invoke((Action)UpdateProgress);

                progressTimeText = stopwatch.ElapsedMilliseconds.ToString();
                this.Invoke((Action)UpdateTimeText);

                var timeToWait = (double)ProgressTime.SelectedItem / progressMaximum;
                var time = TimeSpan.FromMilliseconds(timeToWait);
                Task.Delay(time).Wait();

            }


            progressReverse = false;

            stopwatch.Stop();
        }

        private void comboBoxTime_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // так как у меня время в миллисекундах то я изменю допустимый промежуток с (0 ; 10) сек
                // на (0 ; 10000) мс

                double timeToAdd = 0;
                try
                {
                    timeToAdd = Convert.ToDouble(ProgressTime.Text.Replace(".", ","));
                    if (timeToAdd > 0 && timeToAdd < 10000)
                    {
                        ProgressTime.Items.Add(timeToAdd);
                        ProgressTime.SelectedIndex = ProgressTime.Items.Count - 1;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid input, enter number greater than 0 and less than 10000");
                }
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            Task.Run(() => StartHandler(cts.Token));
            buttonStop.Enabled = true;
            doubleStop = false;
            //new Thread(StartHandler).Start();
        }

        public bool doubleStop { get; set; }

        private void Stop_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            buttonRun.Enabled = true;
            buttonContinue.Enabled = true;
            buttonReverse.Enabled = true;


            if (doubleStop)
            {
                progressBar.Value = progressBar.Minimum;
            }
            doubleStop = !doubleStop;

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            progressContinue = true;
            doubleStop = false;
            cts = new CancellationTokenSource();
            Task.Run(() => StartHandler(cts.Token));
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            progressReverse = true;

            buttonRun.Enabled = false;
            buttonReverse.Enabled = false;
            buttonContinue.Enabled = false;
            buttonStop.Enabled = false;

            Task.Run(() =>
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = progressBar.Value; i >= progressBar.Minimum; i--)
                {

                    progressState = i;
                    this.Invoke((Action)UpdateProgress);

                    progressTimeText = stopwatch.ElapsedMilliseconds.ToString();
                    this.Invoke((Action)UpdateTimeText);
                    var timeToWait = (double)ProgressTime.SelectedItem / progressMaximum;
                    var time = TimeSpan.FromMilliseconds(timeToWait);
                    Task.Delay(time).Wait();
                }

                stopwatch.Stop();
                buttonRun.Enabled = true;
                buttonReverse.Enabled = true;
                buttonContinue.Enabled = true;
                buttonStop.Enabled = true;

            });
        }
    }

    public static class ModifyProgressBarColor
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }


    class BarStyle
    {
        public string name { get; set; }
        public Color color { get; set; }
        public override string ToString()
        {
            return name ?? "---";
        }
    }


}
