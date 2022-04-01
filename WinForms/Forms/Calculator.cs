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
        Dot,
        PlusMinus,

    }

    public partial class Calculator : Form
    {
        public double FirstArgument { get; set; }
        public double SecondArgument { get; set; }
        private bool SignBlocker { get; set; }
        private Logger log { get; set; }
        private Operations operations;

        public Calculator(Logger logger)
        {
            InitializeComponent();
            log = logger;
            operations = Operations.None;
            SignBlocker = true;
            FirstArgument = 0;
            SecondArgument = 0;

        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 1)
            {
                Display.Text = Display.Text.Substring(0, (Display.Text.Length - 1));
            }
            else
            {
                Display.Text = "0";
            }

        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            Story.Text = "0";
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            Story.Text = String.Empty;

            //foreach(var b in Controls)
            //{
            //    if(b is Button)
            //    {
            //        System.Drawing.Rectangle rect;
            //        rect.Inflate(10, 10);
            //        (b as Button).Bounds=;
            //    }

            //}

        }

        private void Operations_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                log.Error($"Sender error ({sender})");
                return;
            }
            else if (button == buttonPlus)
            {
                operations = Operations.Plus;
                SignBlocker = false;
            }
            else if (button == buttonMinus)
            {
                operations = Operations.Minus;
                SignBlocker = false;
            }
            else if (button == buttonMultiply)
            {
                operations = Operations.Multiply;
                SignBlocker = false;
            }
            else if (button == buttonDivide)
            {
                operations = Operations.Divide;
                SignBlocker = false;
            }
            else if (button == buttonDot)
            {
                Display.Text += ".";
                operations = Operations.Dot;
            }
            else if (button == buttonPlusMinus)
            {
                if (!Display.Text.Equals("0"))
                {
                    if (Display.Text.StartsWith("-"))
                    {
                        Display.Text = Display.Text.Substring(1);
                    }
                    else
                    {
                        Display.Text = "-" + Display.Text;
                    }
                }

                operations = Operations.PlusMinus;
            }
            else
            {
                log.Error($"Undefined button ({button})");
                return;
            }

            if (!button.Text.Equals("+/-"))
            {
                Story.Text = Display.Text + button.Text;
            }

            FirstArgument = Convert.ToDouble(Display.Text.Replace(".", ","));
            if (operations == Operations.Plus|| operations == Operations.Minus|| operations == Operations.Divide|| operations == Operations.Multiply)
            {
                buttonEquals_Click(sender, e);
            }
        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            var clicked = sender as Button;
            if (clicked == null)
            {
                return;
            }

            if (Display.Text.Equals("0"))
            {
                Display.Text = "";
            }

            if (SignBlocker)
            {
                Display.Text += clicked.Text;
            }
            else
            {
                Display.Text = clicked.Text;
                SignBlocker = true;
            }
        }

        private void buttonEqualsCompute_Click(object sender, EventArgs e)
        {
            var answer = new DataTable().Compute(Display.Text.Replace('x', '*').Replace('÷', '/'), null);
            Story.Text = Display.Text;
            Display.Text = answer.ToString();
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {

            SecondArgument = Convert.ToDouble(Display.Text.Replace(".", ","));
            Story.Text += $"{SecondArgument}=";

            double result = 0;

            switch (operations)
            {
                case Operations.None:
                    MessageBox.Show("No Operation");
                    break;
                case Operations.Plus:
                    result = FirstArgument + SecondArgument;
                    break;
                case Operations.Minus:
                    result = FirstArgument - SecondArgument;
                    break;
                case Operations.Multiply:
                    result = FirstArgument * SecondArgument;
                    break;
                case Operations.Divide:
                    result = FirstArgument / SecondArgument;
                    break;
            }

            Display.Text = result.ToString().Replace(".", ",");

        }
    }
}
