namespace WinForms.Forms
{
    partial class MandelbrotSetForm
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
            this.pictureBoxFractal = new System.Windows.Forms.PictureBox();
            this.labelCx = new System.Windows.Forms.Label();
            this.labelCy = new System.Windows.Forms.Label();
            this.labelZoom = new System.Windows.Forms.Label();
            this.labelIterations = new System.Windows.Forms.Label();
            this.textBoxPow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFractal
            // 
            this.pictureBoxFractal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFractal.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFractal.Name = "pictureBoxFractal";
            this.pictureBoxFractal.Size = new System.Drawing.Size(484, 460);
            this.pictureBoxFractal.TabIndex = 0;
            this.pictureBoxFractal.TabStop = false;
            this.pictureBoxFractal.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxFractal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFractal_MouseDown);
            this.pictureBoxFractal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFractal_MouseMove);
            // 
            // labelCx
            // 
            this.labelCx.AutoSize = true;
            this.labelCx.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCx.Location = new System.Drawing.Point(12, 471);
            this.labelCx.Name = "labelCx";
            this.labelCx.Size = new System.Drawing.Size(21, 14);
            this.labelCx.TabIndex = 1;
            this.labelCx.Text = "Cx";
            // 
            // labelCy
            // 
            this.labelCy.AutoSize = true;
            this.labelCy.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCy.Location = new System.Drawing.Point(12, 497);
            this.labelCy.Name = "labelCy";
            this.labelCy.Size = new System.Drawing.Size(21, 14);
            this.labelCy.TabIndex = 1;
            this.labelCy.Text = "Cy";
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZoom.Location = new System.Drawing.Point(12, 523);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(35, 14);
            this.labelZoom.TabIndex = 1;
            this.labelZoom.Text = "Zoom";
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIterations.Location = new System.Drawing.Point(12, 549);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(77, 14);
            this.labelIterations.TabIndex = 3;
            this.labelIterations.Text = "Iterations";
            // 
            // textBoxPow
            // 
            this.textBoxPow.Location = new System.Drawing.Point(47, 571);
            this.textBoxPow.Name = "textBoxPow";
            this.textBoxPow.Size = new System.Drawing.Size(36, 23);
            this.textBoxPow.TabIndex = 4;
            this.textBoxPow.Text = "2";
            this.textBoxPow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPow_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pow";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(354, 470);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(42, 14);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Time:";
            // 
            // MandelbrotSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 626);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPow);
            this.Controls.Add(this.labelIterations);
            this.Controls.Add(this.labelZoom);
            this.Controls.Add(this.labelCy);
            this.Controls.Add(this.labelCx);
            this.Controls.Add(this.pictureBoxFractal);
            this.Name = "MandelbrotSetForm";
            this.Text = "MandelbrotSet";
            this.Load += new System.EventHandler(this.MandelbrotSetForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MandelbrotSetForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFractal;
        private System.Windows.Forms.Label labelCx;
        private System.Windows.Forms.Label labelCy;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.TextBox textBoxPow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
    }
}