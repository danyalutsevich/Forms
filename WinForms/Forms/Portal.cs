using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }

        private void Intro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void Calculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Calculator().ShowDialog();
        }
    }
}
