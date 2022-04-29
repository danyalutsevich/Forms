namespace WinForms.Forms
{
    partial class HashForm
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxMd5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSha1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSha2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxText.Location = new System.Drawing.Point(12, 12);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(388, 143);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // textBoxMd5
            // 
            this.textBoxMd5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMd5.Location = new System.Drawing.Point(70, 161);
            this.textBoxMd5.Name = "textBoxMd5";
            this.textBoxMd5.ReadOnly = true;
            this.textBoxMd5.Size = new System.Drawing.Size(330, 22);
            this.textBoxMd5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "md5";
            // 
            // textBoxSha1
            // 
            this.textBoxSha1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSha1.Location = new System.Drawing.Point(70, 190);
            this.textBoxSha1.Name = "textBoxSha1";
            this.textBoxSha1.ReadOnly = true;
            this.textBoxSha1.Size = new System.Drawing.Size(330, 22);
            this.textBoxSha1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "sha1";
            // 
            // textBoxSha2
            // 
            this.textBoxSha2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSha2.Location = new System.Drawing.Point(70, 219);
            this.textBoxSha2.Multiline = true;
            this.textBoxSha2.Name = "textBoxSha2";
            this.textBoxSha2.ReadOnly = true;
            this.textBoxSha2.Size = new System.Drawing.Size(330, 86);
            this.textBoxSha2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "sha2";
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSha2);
            this.Controls.Add(this.textBoxSha1);
            this.Controls.Add(this.textBoxMd5);
            this.Controls.Add(this.textBoxText);
            this.Name = "HashForm";
            this.Text = "HashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxMd5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSha2;
        private System.Windows.Forms.Label label3;
    }
}