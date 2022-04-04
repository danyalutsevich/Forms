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
            this.SuspendLayout();
            // 
            // Intro
            // 
            this.Intro.AutoSize = true;
            this.Intro.Font = new System.Drawing.Font("Monument Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Intro.Location = new System.Drawing.Point(12, 41);
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
            this.Calculator.Location = new System.Drawing.Point(12, 78);
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
            this.ProgressLink.Location = new System.Drawing.Point(12, 113);
            this.ProgressLink.Name = "ProgressLink";
            this.ProgressLink.Size = new System.Drawing.Size(157, 25);
            this.ProgressLink.TabIndex = 0;
            this.ProgressLink.TabStop = true;
            this.ProgressLink.Text = "Progress";
            this.ProgressLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProgressLink_LinkClicked);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}