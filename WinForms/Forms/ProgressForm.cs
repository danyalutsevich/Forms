using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class ProgressForm : Form
    {
        public NLog.Logger logger { get; set; }
        public Random random { get; set; }

        public ProgressForm(NLog.Logger loger, Random random)
        {
            this.logger = loger;
            this.random = random;

            InitializeComponent();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;

            comboBoxStyles.Items.Add(new BarStyle { color = Color.Green, name = "Green" });
            comboBoxStyles.Items.Add(new BarStyle { color = Color.Red, name = "Red" });
            comboBoxStyles.Items.Add(new BarStyle { color = Color.Yellow, name = "Yellow" });
            comboBoxStyles.SelectedIndex = 0;

            ProgressTime.Items.Add(1000);
            ProgressTime.Items.Add(2000);
            ProgressTime.Items.Add(5000);
            ProgressTime.SelectedIndex = 0;

        }

        private void comboBoxStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(progressBar, comboBoxStyles.SelectedIndex + 1);
        }


        private async void buttonRun_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = progressBar.Minimum; i <= progressBar.Maximum; i++)
            {
                progressBar.Value = i;
                WokringTime.Text = stopwatch.ElapsedMilliseconds.ToString();
                await Task.Delay(((int)ProgressTime.SelectedItem)/progressBar.Maximum);

            }
            stopwatch.Stop();
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
