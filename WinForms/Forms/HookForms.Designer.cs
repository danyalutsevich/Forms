namespace WinForms.Forms
{
    partial class HookForms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKeyboard = new System.Windows.Forms.TabPage();
            this.richTextBoxKB = new System.Windows.Forms.RichTextBox();
            this.buttonStopKB = new System.Windows.Forms.Button();
            this.buttonStartKB = new System.Windows.Forms.Button();
            this.tabPageMouse = new System.Windows.Forms.TabPage();
            this.labelMsY = new System.Windows.Forms.Label();
            this.labelMsX = new System.Windows.Forms.Label();
            this.listBoxMS = new System.Windows.Forms.ListBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageKeyboard.SuspendLayout();
            this.tabPageMouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageKeyboard);
            this.tabControl1.Controls.Add(this.tabPageMouse);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 584);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "true";
            // 
            // tabPageKeyboard
            // 
            this.tabPageKeyboard.Controls.Add(this.richTextBoxKB);
            this.tabPageKeyboard.Controls.Add(this.buttonStopKB);
            this.tabPageKeyboard.Controls.Add(this.buttonStartKB);
            this.tabPageKeyboard.Location = new System.Drawing.Point(4, 24);
            this.tabPageKeyboard.Name = "tabPageKeyboard";
            this.tabPageKeyboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeyboard.Size = new System.Drawing.Size(402, 556);
            this.tabPageKeyboard.TabIndex = 0;
            this.tabPageKeyboard.Tag = true;
            this.tabPageKeyboard.Text = "Keyboard";
            this.tabPageKeyboard.UseVisualStyleBackColor = true;
            // 
            // richTextBoxKB
            // 
            this.richTextBoxKB.Location = new System.Drawing.Point(87, 58);
            this.richTextBoxKB.Name = "richTextBoxKB";
            this.richTextBoxKB.Size = new System.Drawing.Size(309, 269);
            this.richTextBoxKB.TabIndex = 1;
            this.richTextBoxKB.Text = "";
            // 
            // buttonStopKB
            // 
            this.buttonStopKB.Location = new System.Drawing.Point(6, 87);
            this.buttonStopKB.Name = "buttonStopKB";
            this.buttonStopKB.Size = new System.Drawing.Size(75, 23);
            this.buttonStopKB.TabIndex = 0;
            this.buttonStopKB.Text = "Stop";
            this.buttonStopKB.UseVisualStyleBackColor = true;
            this.buttonStopKB.Click += new System.EventHandler(this.buttonStopKB_Click);
            // 
            // buttonStartKB
            // 
            this.buttonStartKB.Location = new System.Drawing.Point(6, 58);
            this.buttonStartKB.Name = "buttonStartKB";
            this.buttonStartKB.Size = new System.Drawing.Size(75, 23);
            this.buttonStartKB.TabIndex = 0;
            this.buttonStartKB.Text = "Start";
            this.buttonStartKB.UseVisualStyleBackColor = true;
            this.buttonStartKB.Click += new System.EventHandler(this.buttonStartKB_Click);
            // 
            // tabPageMouse
            // 
            this.tabPageMouse.Controls.Add(this.pictureBox1);
            this.tabPageMouse.Controls.Add(this.labelMsY);
            this.tabPageMouse.Controls.Add(this.labelMsX);
            this.tabPageMouse.Controls.Add(this.listBoxMS);
            this.tabPageMouse.Controls.Add(this.buttonStop);
            this.tabPageMouse.Controls.Add(this.buttonStart);
            this.tabPageMouse.Location = new System.Drawing.Point(4, 24);
            this.tabPageMouse.Name = "tabPageMouse";
            this.tabPageMouse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMouse.Size = new System.Drawing.Size(402, 556);
            this.tabPageMouse.TabIndex = 1;
            this.tabPageMouse.Tag = true;
            this.tabPageMouse.Text = "Mouse";
            this.tabPageMouse.UseVisualStyleBackColor = true;
            // 
            // labelMsY
            // 
            this.labelMsY.AutoSize = true;
            this.labelMsY.Location = new System.Drawing.Point(68, 93);
            this.labelMsY.Name = "labelMsY";
            this.labelMsY.Size = new System.Drawing.Size(13, 15);
            this.labelMsY.TabIndex = 2;
            this.labelMsY.Text = "y";
            // 
            // labelMsX
            // 
            this.labelMsX.AutoSize = true;
            this.labelMsX.Location = new System.Drawing.Point(6, 93);
            this.labelMsX.Name = "labelMsX";
            this.labelMsX.Size = new System.Drawing.Size(13, 15);
            this.labelMsX.TabIndex = 2;
            this.labelMsX.Text = "x";
            // 
            // listBoxMS
            // 
            this.listBoxMS.FormattingEnabled = true;
            this.listBoxMS.ItemHeight = 15;
            this.listBoxMS.Location = new System.Drawing.Point(118, 38);
            this.listBoxMS.Name = "listBoxMS";
            this.listBoxMS.Size = new System.Drawing.Size(238, 154);
            this.listBoxMS.TabIndex = 1;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(6, 67);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 38);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 220);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // HookForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 608);
            this.Controls.Add(this.tabControl1);
            this.Name = "HookForms";
            this.Text = "HookForms";
            this.tabControl1.ResumeLayout(false);
            this.tabPageKeyboard.ResumeLayout(false);
            this.tabPageMouse.ResumeLayout(false);
            this.tabPageMouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageKeyboard;
        private System.Windows.Forms.RichTextBox richTextBoxKB;
        private System.Windows.Forms.Button buttonStopKB;
        private System.Windows.Forms.Button buttonStartKB;
        private System.Windows.Forms.TabPage tabPageMouse;
        private System.Windows.Forms.ListBox listBoxMS;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelMsY;
        private System.Windows.Forms.Label labelMsX;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}