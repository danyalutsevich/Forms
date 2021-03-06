using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace WinForms.Forms
{
    public partial class FileCipher : Form
    {
        private const string sampleFile = "sample.txt";
        private const string sampleContent = "This is sample text.";
        private const char passwordChar = '●';

        CipherData cipherData;
        CancellationTokenSource? cts;

        public FileCipher()
        {
            InitializeComponent();

            cipherData = new CipherData();
            cts = null;
            buttonCancelCipher.Enabled = false;

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

        private int symNum = 0;
        private long fileSize;

        private void Cipher(object data)
        {
            buttonCipher.Enabled = false;
            buttonCancelCipher.Enabled = true;

            if (data is not ThreadData || data is null)
            {
                return;
            }

            var threadData = data as ThreadData;
            // open source file for reading 

            if (threadData.Data.SourceFile is null) { return; }

            var source = threadData.Data.SourceFile;
            string dest = source + ".ciphered";

            if (threadData.Data.DestinationFile == null)
            {
                dest = threadData.Data.DestinationFile;
            }

            try
            {

                fileSize = new FileInfo(source).Length;

                if (threadData.Data.Password == "" || threadData.Data.Password is null)
                {
                    throw new Exception("Enter a password");
                }

                using (var sr = new StreamReader(threadData.Data.SourceFile))
                {
                    // open destination file for writing 
                    using (var sw = new StreamWriter(dest))
                    {
                        // read a line of text 
                        while (!sr.EndOfStream)
                        {
                            // write the text to the destination file 
                            char symT = (char)sr.Read();
                            char symP = threadData.Data.Password[symNum % threadData.Data.Password.Length];
                            char symC = (char)(symT ^ symP);
                            sw.Write(symC);

                            if (threadData.cts.IsCancellationRequested)
                            {
                                if (DialogResult.Yes == MessageBox.Show("Quit cipher?", "Ciphering stoped", MessageBoxButtons.YesNo))
                                {
                                    threadData.cts.ThrowIfCancellationRequested();
                                }
                                else
                                {
                                    cts = new CancellationTokenSource();
                                    threadData.cts = cts.Token;
                                }
                            }

                            //Thread.Sleep(100);
                            symNum++;
                            Invoke((Action)UpdateProgress);
                        }
                    }
                }

                var res = MessageBox.Show("Open in Notepad?", "Done", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("notepad.exe", dest);
                }

                MessageBox.Show("Done");



            }
            catch (IOException) // IO problem
            {
                MessageBox.Show("Error while reading or writing file");
            }
            catch (OperationCanceledException) // cancellation
            {
                MessageBox.Show("Operation was canceled");
                // delete destination file
                if (File.Exists(threadData.Data.DestinationFile))
                {
                    File.Delete(dest);
                    MessageBox.Show("deleted");
                }

            }
            catch (Exception ex) // other problem
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                labelDestinationFile.Text = "";
                labelFileName.Text = "";
                progressBarEncription.Value = 0;
                textBoxPassword.Text = "";
                buttonCipher.Enabled = true;
                buttonCancelCipher.Enabled = false;
            }
        }

       

        private void UpdateProgress()
        {
            lock (progressBarEncription)
            {
                progressBarEncription.Value = Map(symNum, 0, fileSize, 0, 100);
            }
        }

        private async void buttonCipher_Click(object sender, EventArgs e)
        {

            cipherData.Password = textBoxPassword.Text;
            cts = new CancellationTokenSource();

            cipherData.DestinationFile = saveFileDialog1.FileName;
            cipherData.SourceFile = openFileDialog1.FileName;

            new Thread(Cipher).Start(new ThreadData
            {
                Data = cipherData,
                cts = cts.Token
            });
            #region cipher

            // XOR encryption with password from textboxPassword

            // await Task.Run(() =>
            //{
            //    string password = textBoxPassword.Text;
            //    string fileName = openFileDialog1.FileName;

            //    if (password == "")
            //    {
            //        MessageBox.Show("Enter password");
            //        return;
            //    }

            //    if (fileName == "")
            //    {
            //        MessageBox.Show("Select file");
            //        return;
            //    }

            //    var content = System.IO.File.ReadAllBytes(fileName);
            //    var encrypted = new byte[content.Length];

            //    for (int i = 0; i < content.Length; i++)
            //    {
            //        encrypted[i] = (byte)(content[i] ^ password[i % password.Length]);

            //        progressBarEncription.Value = Map(i, 0, content.Length, progressBarEncription.Minimum, progressBarEncription.Maximum);
            //    }

            //    if (saveFileDialog1.FileName == "")
            //    {
            //       // Write encrypted content to file if destination is not specified
            //       System.IO.File.WriteAllBytes("encrypted_" + Path.GetFileName(fileName), encrypted);
            //    }
            //    else
            //    {
            //       // Write encrypted content to file if destination is specified
            //       System.IO.File.WriteAllBytes(saveFileDialog1.FileName, encrypted);
            //    }

            //});
            #endregion

        }

        private void buttonCancelCipher_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
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
            _ = textBoxPassword.PasswordChar == '\0' ? textBoxPassword.PasswordChar = passwordChar
                : textBoxPassword.PasswordChar = '\0';
        }

    }

    class ThreadData
    {
        public CipherData? Data { get; set; }
        public CancellationToken cts { get; set; }
    }

    class CipherData
    {
        public string? Password { get; set; }
        public string? SourceFile { get; set; }
        public string? DestinationFile { get; set; }
    }

}
