using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WinForms.Forms
{

    enum Operations
    {
        None,
        Plus,
        Minus,
        Multiply,
        Divide,

    }

    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        public static bool SignBlocker { get; set; }
        public static Logger log { get; set; }
        private static Operations operations;

        static Calculator()
        {
            operations = Operations.None;
            log=LogManager.GetCurrentClassLogger();
            SignBlocker = true;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Operations_Click(object sender, EventArgs e)
        {

            var button = sender as Button;
            if (button == null)
            {
                log.Fatal($"Sender error ({sender})");
                return;
            }
            else if (button == buttonPlus)
            {
                operations = Operations.Plus;
            }
            else if (button == buttonMinus)
            {
                operations = Operations.Minus;
            }
            else if (button == buttonMultiply)
            {
                operations = Operations.Multiply;
            }
            else if (button == buttonDivide)
            {
                operations = Operations.Divide;
            }
            else
            {
                log.Fatal($"Undefined button ({button.Text})");
                return;
            }

            if(operations == Operations.Plus)
            {
                richTextBox1.Text += "+";
            }
            else if(operations == Operations.Minus)
            {
                richTextBox1.Text += "-";
            }
            else if(operations== Operations.Multiply)
            {
                richTextBox1.Text += "x";
            }
            else if(operations== Operations.Divide)
            {
                richTextBox1.Text += "-";
            }

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
                if (!SignBlocker)
                {
                    richTextBox1.Text = richTextBox1.Text + clicked.Text;
                    SignBlocker=true;
                }
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
            SignBlocker = false;
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
