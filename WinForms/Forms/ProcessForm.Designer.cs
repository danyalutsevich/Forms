namespace WinForms.Forms
{
    partial class ProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNotepad = new System.Windows.Forms.Label();
            this.buttonNotepadStart = new System.Windows.Forms.Button();
            this.buttonNotepadStop = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.treeViewProcesses = new System.Windows.Forms.TreeView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.linkLabelITStep = new System.Windows.Forms.LinkLabel();
            this.linkLabelOdITStep = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelNotepad
            // 
            this.labelNotepad.AutoSize = true;
            this.labelNotepad.Location = new System.Drawing.Point(12, 37);
            this.labelNotepad.Name = "labelNotepad";
            this.labelNotepad.Size = new System.Drawing.Size(53, 15);
            this.labelNotepad.TabIndex = 0;
            this.labelNotepad.Text = "Notepad";
            // 
            // buttonNotepadStart
            // 
            this.buttonNotepadStart.Location = new System.Drawing.Point(71, 33);
            this.buttonNotepadStart.Name = "buttonNotepadStart";
            this.buttonNotepadStart.Size = new System.Drawing.Size(75, 23);
            this.buttonNotepadStart.TabIndex = 2;
            this.buttonNotepadStart.Text = "Start";
            this.buttonNotepadStart.UseVisualStyleBackColor = true;
            this.buttonNotepadStart.Click += new System.EventHandler(this.buttonNotepadStart_Click);
            // 
            // buttonNotepadStop
            // 
            this.buttonNotepadStop.Location = new System.Drawing.Point(152, 33);
            this.buttonNotepadStop.Name = "buttonNotepadStop";
            this.buttonNotepadStop.Size = new System.Drawing.Size(75, 23);
            this.buttonNotepadStop.TabIndex = 2;
            this.buttonNotepadStop.Text = "Stop";
            this.buttonNotepadStop.UseVisualStyleBackColor = true;
            this.buttonNotepadStop.Click += new System.EventHandler(this.buttonNotepadStop_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(233, 33);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // treeViewProcesses
            // 
            this.treeViewProcesses.Location = new System.Drawing.Point(12, 157);
            this.treeViewProcesses.Name = "treeViewProcesses";
            this.treeViewProcesses.Size = new System.Drawing.Size(457, 399);
            this.treeViewProcesses.TabIndex = 3;
            this.treeViewProcesses.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewProcesses_NodeMouseDoubleClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 128);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 5000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // linkLabelITStep
            // 
            this.linkLabelITStep.AutoSize = true;
            this.linkLabelITStep.Location = new System.Drawing.Point(71, 77);
            this.linkLabelITStep.Name = "linkLabelITStep";
            this.linkLabelITStep.Size = new System.Drawing.Size(57, 15);
            this.linkLabelITStep.TabIndex = 5;
            this.linkLabelITStep.TabStop = true;
            this.linkLabelITStep.Text = "itstep.org";
            this.linkLabelITStep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelITStep_LinkClicked);
            // 
            // linkLabelOdITStep
            // 
            this.linkLabelOdITStep.AutoSize = true;
            this.linkLabelOdITStep.Location = new System.Drawing.Point(152, 77);
            this.linkLabelOdITStep.Name = "linkLabelOdITStep";
            this.linkLabelOdITStep.Size = new System.Drawing.Size(74, 15);
            this.linkLabelOdITStep.TabIndex = 5;
            this.linkLabelOdITStep.TabStop = true;
            this.linkLabelOdITStep.Text = "od.itstep.org";
            this.linkLabelOdITStep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOdITStep_LinkClicked);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 568);
            this.Controls.Add(this.linkLabelOdITStep);
            this.Controls.Add(this.linkLabelITStep);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.treeViewProcesses);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonNotepadStop);
            this.Controls.Add(this.buttonNotepadStart);
            this.Controls.Add(this.labelNotepad);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNotepad;
        private System.Windows.Forms.Button buttonNotepadStart;
        private System.Windows.Forms.Button buttonNotepadStop;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.TreeView treeViewProcesses;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.LinkLabel linkLabelITStep;
        private System.Windows.Forms.LinkLabel linkLabelOdITStep;
    }
}