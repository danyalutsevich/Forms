using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace WinForms.Forms
{
    public partial class Portal : Form
    {
        private NLog.Logger logger;

        public Portal(NLog.Logger logger)
        {
            InitializeComponent();
            this.logger = logger;
        }

        private void Intro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void Calculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Calculator(logger).ShowDialog();
        }

        private void ProgressLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Container.Resolve<Forms.ProgressForm>().ShowDialog();
        }

        private void linkLabel2048_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Container.Resolve<Forms._2048Form>().ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Container.Resolve<Forms.GDI>().ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Container.Resolve<Forms.ProcessForm>().ShowDialog();
        }

        private void linkLabelMVPatterns_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Container.Resolve<Forms.MVPatternsForm>().ShowDialog();
        }

        private void linkLabelHooks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Container.Resolve<Forms.HookForms>().ShowDialog();
        }

        private void linkLabelChipher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Visible = false;
            Program.Container.Resolve<Forms.FileCipher>().ShowDialog();
            this.Show(); // Visible = true;
        }
        
        private void linkLabelMandelbrot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Program.Container.Resolve<Forms.MandelbrotSetForm>().ShowDialog();
            this.Show();
        }
    }
}
