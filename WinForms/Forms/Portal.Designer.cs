namespace WinForms.Forms
{
    partial class Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
            this.Intro = new System.Windows.Forms.LinkLabel();
            this.Calculator = new System.Windows.Forms.LinkLabel();
            this.ProgressLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel2048 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelMVPatterns = new System.Windows.Forms.LinkLabel();
            this.linkLabelHooks = new System.Windows.Forms.LinkLabel();
            this.linkLabelChipher = new System.Windows.Forms.LinkLabel();
            this.linkLabelMandelbrot = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Intro
            // 
            this.Intro.AutoSize = true;
            this.Intro.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Intro.Location = new System.Drawing.Point(-15, 18);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(88, 25);
            this.Intro.TabIndex = 0;
            this.Intro.TabStop = true;
            this.Intro.Text = "Intro";
            this.Intro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Intro_LinkClicked);
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.Location = new System.Drawing.Point(177, 53);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(174, 25);
            this.Calculator.TabIndex = 0;
            this.Calculator.TabStop = true;
            this.Calculator.Text = "Calculator";
            this.Calculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Calculator_LinkClicked);
            // 
            // ProgressLink
            // 
            this.ProgressLink.AutoSize = true;
            this.ProgressLink.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgressLink.Location = new System.Drawing.Point(106, 132);
            this.ProgressLink.Name = "ProgressLink";
            this.ProgressLink.Size = new System.Drawing.Size(157, 25);
            this.ProgressLink.TabIndex = 0;
            this.ProgressLink.TabStop = true;
            this.ProgressLink.Text = "Progress";
            this.ProgressLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProgressLink_LinkClicked);
            // 
            // linkLabel2048
            // 
            this.linkLabel2048.AutoSize = true;
            this.linkLabel2048.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2048.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2048.Location = new System.Drawing.Point(229, 132);
            this.linkLabel2048.Name = "linkLabel2048";
            this.linkLabel2048.Size = new System.Drawing.Size(91, 25);
            this.linkLabel2048.TabIndex = 0;
            this.linkLabel2048.TabStop = true;
            this.linkLabel2048.Text = "2048";
            this.linkLabel2048.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2048_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(312, 370);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 25);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GDI";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.Location = new System.Drawing.Point(39, 181);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(142, 25);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Process";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelMVPatterns
            // 
            this.linkLabelMVPatterns.AutoSize = true;
            this.linkLabelMVPatterns.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelMVPatterns.Location = new System.Drawing.Point(12, 229);
            this.linkLabelMVPatterns.Name = "linkLabelMVPatterns";
            this.linkLabelMVPatterns.Size = new System.Drawing.Size(203, 25);
            this.linkLabelMVPatterns.TabIndex = 0;
            this.linkLabelMVPatterns.TabStop = true;
            this.linkLabelMVPatterns.Text = "MVPatterns";
            this.linkLabelMVPatterns.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMVPatterns_LinkClicked);
            // 
            // linkLabelHooks
            // 
            this.linkLabelHooks.AutoSize = true;
            this.linkLabelHooks.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelHooks.Location = new System.Drawing.Point(209, 194);
            this.linkLabelHooks.Name = "linkLabelHooks";
            this.linkLabelHooks.Size = new System.Drawing.Size(111, 25);
            this.linkLabelHooks.TabIndex = 0;
            this.linkLabelHooks.TabStop = true;
            this.linkLabelHooks.Text = "Hooks";
            this.linkLabelHooks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHooks_LinkClicked);
            // 
            // linkLabelChipher
            // 
            this.linkLabelChipher.AutoSize = true;
            this.linkLabelChipher.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelChipher.Location = new System.Drawing.Point(12, 275);
            this.linkLabelChipher.Name = "linkLabelChipher";
            this.linkLabelChipher.Size = new System.Drawing.Size(136, 25);
            this.linkLabelChipher.TabIndex = 0;
            this.linkLabelChipher.TabStop = true;
            this.linkLabelChipher.Text = "Chipher";
            this.linkLabelChipher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChipher_LinkClicked);
            // 
            // linkLabelMandelbrot
            // 
            this.linkLabelMandelbrot.AutoSize = true;
            this.linkLabelMandelbrot.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelMandelbrot.Location = new System.Drawing.Point(79, 317);
            this.linkLabelMandelbrot.Name = "linkLabelMandelbrot";
            this.linkLabelMandelbrot.Size = new System.Drawing.Size(254, 25);
            this.linkLabelMandelbrot.TabIndex = 0;
            this.linkLabelMandelbrot.TabStop = true;
            this.linkLabelMandelbrot.Text = "Mabdelbrot Set";
            this.linkLabelMandelbrot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMandelbrot_LinkClicked);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.linkLabelHooks);
            this.Controls.Add(this.linkLabelMandelbrot);
            this.Controls.Add(this.linkLabelChipher);
            this.Controls.Add(this.linkLabelMVPatterns);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel2048);
            this.Controls.Add(this.ProgressLink);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.Intro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Portal";
            this.Text = "Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Intro;
        private System.Windows.Forms.LinkLabel Calculator;
        private System.Windows.Forms.LinkLabel ProgressLink;
        private System.Windows.Forms.LinkLabel linkLabel2048;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabelMVPatterns;
        private System.Windows.Forms.LinkLabel linkLabelHooks;
        private System.Windows.Forms.LinkLabel linkLabelChipher;
        private System.Windows.Forms.LinkLabel linkLabelMandelbrot;
    }
}