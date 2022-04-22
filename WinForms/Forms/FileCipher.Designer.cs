namespace WinForms.Forms
{
    partial class FileCipher
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSourceFile = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCipher = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDestinationFile = new System.Windows.Forms.Label();
            this.buttonDestinationFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBarEncription = new System.Windows.Forms.ProgressBar();
            this.buttonShowPass = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeSampleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // makeSampleToolStripMenuItem
            // 
            this.makeSampleToolStripMenuItem.Name = "makeSampleToolStripMenuItem";
            this.makeSampleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.makeSampleToolStripMenuItem.Text = "Make sample";
            this.makeSampleToolStripMenuItem.Click += new System.EventHandler(this.makeSampleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source File";
            // 
            // buttonSourceFile
            // 
            this.buttonSourceFile.Location = new System.Drawing.Point(82, 37);
            this.buttonSourceFile.Name = "buttonSourceFile";
            this.buttonSourceFile.Size = new System.Drawing.Size(26, 19);
            this.buttonSourceFile.TabIndex = 2;
            this.buttonSourceFile.Text = "...";
            this.buttonSourceFile.UseVisualStyleBackColor = true;
            this.buttonSourceFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(94, 144);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(188, 23);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // buttonCipher
            // 
            this.buttonCipher.Location = new System.Drawing.Point(347, 144);
            this.buttonCipher.Name = "buttonCipher";
            this.buttonCipher.Size = new System.Drawing.Size(56, 23);
            this.buttonCipher.TabIndex = 2;
            this.buttonCipher.Text = "Cipher";
            this.buttonCipher.UseVisualStyleBackColor = true;
            this.buttonCipher.Click += new System.EventHandler(this.buttonCipher_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(12, 64);
            this.labelFileName.MaximumSize = new System.Drawing.Size(120, 15);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(56, 15);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "file name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Destinaton File";
            // 
            // labelDestinationFile
            // 
            this.labelDestinationFile.AutoSize = true;
            this.labelDestinationFile.Location = new System.Drawing.Point(12, 112);
            this.labelDestinationFile.MaximumSize = new System.Drawing.Size(120, 15);
            this.labelDestinationFile.Name = "labelDestinationFile";
            this.labelDestinationFile.Size = new System.Drawing.Size(56, 15);
            this.labelDestinationFile.TabIndex = 1;
            this.labelDestinationFile.Text = "file name";
            // 
            // buttonDestinationFile
            // 
            this.buttonDestinationFile.Location = new System.Drawing.Point(103, 86);
            this.buttonDestinationFile.Name = "buttonDestinationFile";
            this.buttonDestinationFile.Size = new System.Drawing.Size(26, 19);
            this.buttonDestinationFile.TabIndex = 2;
            this.buttonDestinationFile.Text = "...";
            this.buttonDestinationFile.UseVisualStyleBackColor = true;
            this.buttonDestinationFile.Click += new System.EventHandler(this.buttonDestinationFile_Click);
            // 
            // progressBarEncription
            // 
            this.progressBarEncription.Location = new System.Drawing.Point(13, 173);
            this.progressBarEncription.Name = "progressBarEncription";
            this.progressBarEncription.Size = new System.Drawing.Size(390, 23);
            this.progressBarEncription.TabIndex = 4;
            // 
            // buttonShowPass
            // 
            this.buttonShowPass.Location = new System.Drawing.Point(288, 144);
            this.buttonShowPass.Name = "buttonShowPass";
            this.buttonShowPass.Size = new System.Drawing.Size(28, 23);
            this.buttonShowPass.TabIndex = 5;
            this.buttonShowPass.Text = "👁";
            this.buttonShowPass.UseVisualStyleBackColor = true;
            this.buttonShowPass.Click += new System.EventHandler(this.buttonShowPass_Click);
            // 
            // FileCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 585);
            this.Controls.Add(this.buttonShowPass);
            this.Controls.Add(this.progressBarEncription);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonCipher);
            this.Controls.Add(this.buttonDestinationFile);
            this.Controls.Add(this.buttonSourceFile);
            this.Controls.Add(this.labelDestinationFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileCipher";
            this.Text = "FileCipher";
            this.Load += new System.EventHandler(this.FileCipher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSourceFile;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCipher;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDestinationFile;
        private System.Windows.Forms.Button buttonDestinationFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBarEncription;
        private System.Windows.Forms.Button buttonShowPass;
    }
}