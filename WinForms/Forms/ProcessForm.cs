using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
        }

        Process notepad;

        bool IsRuning = false;

        private void buttonNotepadStart_Click(object sender, EventArgs e)
        {
            if (!IsRuning)
            {
                notepad = Process.Start("notepad.exe");
                IsRuning = true;
            }
            else
            {
                MessageBox.Show("Close the runing window");
            }
            
        }

        private void buttonNotepadStop_Click(object sender, EventArgs e)
        {
            if (notepad != null)
            {
                notepad.Kill();
                IsRuning = false;
            }
            else
            {
                MessageBox.Show("Notepad running");
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", Application.StartupPath + "log.txt");
        }
        
        private void buttonChromeStart_Click(object sender, EventArgs e)
        {
                
        }

        private void ProcessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notepad != null)
            {
                notepad.Kill();
            }
        }
    }
}
