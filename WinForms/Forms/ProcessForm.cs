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

        // starts notepad process
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

        // kills notepad process
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

        // opens program log in notepad
        private void buttonLog_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", Application.StartupPath + "log.txt");
        }
        
        // closing notepad before form closing
        private void ProcessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notepad != null)
            {
                notepad.Kill();
            }
        }

        // adds information about processes in treeView 
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();

            foreach (var p in processes.OrderBy(i => i.ProcessName).GroupBy(i => i.ProcessName, (n, g) => new { Name = n, Processes = g.ToList() }))
            {
                TreeNode node = new TreeNode();
                node.Text = p.Name + " " + p.Processes.Count;

                foreach (var proc in p.Processes)
                {
                    TreeNode subNode = new TreeNode();

                    subNode.Text = $"Proc# {proc.Id} ({proc.Threads.Count}) Priority {proc.BasePriority}";
                    foreach (ProcessThread t in proc.Threads)
                    {
                        subNode.Nodes.Add(new TreeNode($"Thread# {t.Id}"));
                    }

                    subNode.Tag = proc;
                    node.Nodes.Add(subNode);

                }

                treeViewProcesses.Nodes.Add(node);
            }
        }

        // Killing process on mouse right button double click
        private void treeViewProcesses_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var res = MessageBox.Show($"Kill {e.Node.Text}", e.Node.Text, MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    (e.Node.Tag as Process).Kill();

                }

            }

        }

        // updating tree with new processes
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            var processes = Process.GetProcesses();

            for (int i = 0; i < processes.Length; i++)
            {
                var nodes = treeViewProcesses.Nodes;

                bool contains = false;

                for (int j = 0; j < nodes.Count; j++)
                {

                    if (nodes[j].Text.Contains(processes[i].ProcessName))
                    {
                        contains = true;
                    }

                }

                if (!contains)
                {
                    treeViewProcesses.Nodes.Add(new TreeNode(processes[i].ProcessName));
                }
            }
        }

        // opens chome with defined website
        private void linkLabelITStep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://itstep.org/");
        }

        private void linkLabelOdITStep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://od.itstep.org/");
        }
    }
}
