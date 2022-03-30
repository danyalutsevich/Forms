using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static long count { get; set; }

        static Form1()
        {
            count = 0;
        }

        private void ButtonDemo_Click(object sender, EventArgs e)
        {

            count++;

            ListBoxDemo.Items.Add(count.ToString());

            if (count % 10 > 1 && count % 10 < 5 && count < 10)
            {
                labelTitle.Text = $"Кнопка нажата {count} раза";
            }
            else
            {
                labelTitle.Text = $"Кнопка нажата {count} раз";
            }

            text.Text = "button pressed";

        }

        private void Notifications_CheckedChanged(object sender, EventArgs e)
        {

            if (Notifications.Checked)
            {
                GetNotifications.ForeColor = Color.Green;
            }
            else
            {
                GetNotifications.ForeColor = Color.Red;
            }

        }

        private void ListBoxDemo_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Input.Text = textBox1.Text;

        }
    }
}
