﻿using System;
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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        public static bool BlockOperator { get; set; }

        static Calculator()
        {
            BlockOperator = true;
        }


        private void buttonEquals_Click(object sender, EventArgs e)
        {
            var answer = new DataTable().Compute(richTextBox1.Text.Replace('x', '*').Replace('÷', '/'), null);
            History.Text = richTextBox1.Text;
            richTextBox1.Text = answer.ToString();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            var clicked = sender as Button;
            if (clicked == null)
            {
                return;
            }

            if (clicked.Text.Equals("+/-"))
            {
                if (richTextBox1.Text.StartsWith("-"))
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
                else
                {
                    richTextBox1.Text = "-" + richTextBox1.Text;
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + clicked.Text;
            }
        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            var clicked = sender as Button;
            if (clicked == null)
            {
                return;
            }

            if (richTextBox1.Text.Equals("0"))
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += clicked.Text;
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, (richTextBox1.Text.Length - 1));
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            History.Text = "0";
        }
    }
}
