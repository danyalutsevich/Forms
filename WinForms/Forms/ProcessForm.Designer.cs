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
            this.labelNotepad = new System.Windows.Forms.Label();
            this.labelChrome = new System.Windows.Forms.Label();
            this.buttonNotepadStart = new System.Windows.Forms.Button();
            this.buttonChromeStart = new System.Windows.Forms.Button();
            this.buttonNotepadStop = new System.Windows.Forms.Button();
            this.buttonChromeStop = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
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
            // labelChrome
            // 
            this.labelChrome.AutoSize = true;
            this.labelChrome.Location = new System.Drawing.Point(12, 73);
            this.labelChrome.Name = "labelChrome";
            this.labelChrome.Size = new System.Drawing.Size(50, 15);
            this.labelChrome.TabIndex = 1;
            this.labelChrome.Text = "Chrome";
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
            // buttonChromeStart
            // 
            this.buttonChromeStart.Location = new System.Drawing.Point(71, 69);
            this.buttonChromeStart.Name = "buttonChromeStart";
            this.buttonChromeStart.Size = new System.Drawing.Size(75, 23);
            this.buttonChromeStart.TabIndex = 2;
            this.buttonChromeStart.Text = "Start";
            this.buttonChromeStart.UseVisualStyleBackColor = true;
            this.buttonChromeStart.Click += new System.EventHandler(this.buttonChromeStart_Click);
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
            // buttonChromeStop
            // 
            this.buttonChromeStop.Location = new System.Drawing.Point(152, 69);
            this.buttonChromeStop.Name = "buttonChromeStop";
            this.buttonChromeStop.Size = new System.Drawing.Size(75, 23);
            this.buttonChromeStop.TabIndex = 2;
            this.buttonChromeStop.Text = "Start";
            this.buttonChromeStop.UseVisualStyleBackColor = true;
            this.buttonChromeStop.Click += new System.EventHandler(this.buttonChromeStart_Click);
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
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 568);
            this.Controls.Add(this.buttonChromeStop);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonNotepadStop);
            this.Controls.Add(this.buttonChromeStart);
            this.Controls.Add(this.buttonNotepadStart);
            this.Controls.Add(this.labelChrome);
            this.Controls.Add(this.labelNotepad);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNotepad;
        private System.Windows.Forms.Label labelChrome;
        private System.Windows.Forms.Button buttonNotepadStart;
        private System.Windows.Forms.Button buttonChromeStart;
        private System.Windows.Forms.Button buttonNotepadStop;
        private System.Windows.Forms.Button buttonChromeStop;
        private System.Windows.Forms.Button buttonLog;
    }
}