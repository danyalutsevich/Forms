using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hash;

namespace WinForms.Forms
{
    public partial class HashForm : Form
    {
        public HashForm()
        {
            InitializeComponent();
        }


        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            textBoxMd5.Text =  Hasher.Md5(textBoxText.Text);
            textBoxSha1.Text = Hasher.Sha1(textBoxText.Text);
            textBoxSha2.Text = Hasher.Sha2(textBoxText.Text);
        }
    }
}
