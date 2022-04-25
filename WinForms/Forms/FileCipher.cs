using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForms.Forms
{
    public partial class FileCipher : Form
    {
        private const string sampleFile = "sample.txt";
        private const string sampleContent = "This is a sample text file.";
        private const char passwordChar = '●';
        
        public FileCipher()
        {
            InitializeComponent();
        }

        private void FileCipher_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = passwordChar;
            progressBarEncription.Minimum = 0;
            progressBarEncription.Maximum = 100;
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "All files|*.*|Text files|*.txt";
            openFileDialog1.FilterIndex = 1;

            var res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                labelFileName.Text = fileName;
            }
        }

        // Creates file "sample.txt" in the same folder as the program
        private void makeSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(sampleFile, sampleContent);
        }

        // Map value
        private int Map(float value, float min1, float max1, float min2, float max2)
        {
            return (int)(min2 + (value - min1) * (max2 - min2) / (max1 - min1));
        }


        private async void buttonCipher_Click(object sender, EventArgs e)
        {
            // XOR encryption with password from textboxPassword

           await Task.Run(() =>
            {
                string password = textBoxPassword.Text;
                string fileName = openFileDialog1.FileName;

                if (password == "")
                {
                    MessageBox.Show("Enter password");
                    return;
                }

                if (fileName == "")
                {
                    MessageBox.Show("Select file");
                    return;
                }

                var content = System.IO.File.ReadAllBytes(fileName);
                var encrypted = new byte[content.Length];

                for (int i = 0; i < content.Length; i++)
                {
                    encrypted[i] = (byte)(content[i] ^ password[i % password.Length]);

                    progressBarEncription.Value = Map(i, 0, content.Length, progressBarEncription.Minimum, progressBarEncription.Maximum);
                }

                if (saveFileDialog1.FileName == "")
                {
                    // Write encrypted content to file if destination is not specified
                    System.IO.File.WriteAllBytes("encrypted_" + Path.GetFileName(fileName), encrypted);
                }
                else
                {
                    // Write encrypted content to file if destination is specified
                    System.IO.File.WriteAllBytes(saveFileDialog1.FileName, encrypted);
                }

            });

        }

        private void buttonDestinationFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.Filter = "All files|*.*|Text files|*.txt";
            saveFileDialog1.FilterIndex = 1;

            var res = saveFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                string fileName = Path.GetFileName(saveFileDialog1.FileName);
                labelDestinationFile.Text = fileName;
            }
        }

        private void buttonShowPass_Click(object sender, EventArgs e)
        {
            _=textBoxPassword.PasswordChar == '\0' ? textBoxPassword.PasswordChar = passwordChar
                : textBoxPassword.PasswordChar = '\0';
        }
    }

}
