namespace WinForms.Forms
{
    partial class ProgressForm
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.BarStyle = new System.Windows.Forms.Label();
            this.comboBoxStyles = new System.Windows.Forms.ComboBox();
            this.WokringTime = new System.Windows.Forms.Label();
            this.ProgressTime = new System.Windows.Forms.ComboBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(357, 226);
            this.progressBar.TabIndex = 0;
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRun.Location = new System.Drawing.Point(12, 244);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStop.Location = new System.Drawing.Point(294, 244);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // BarStyle
            // 
            this.BarStyle.AutoSize = true;
            this.BarStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BarStyle.Location = new System.Drawing.Point(97, 248);
            this.BarStyle.Name = "BarStyle";
            this.BarStyle.Size = new System.Drawing.Size(42, 14);
            this.BarStyle.TabIndex = 3;
            this.BarStyle.Text = "Style";
            // 
            // comboBoxStyles
            // 
            this.comboBoxStyles.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxStyles.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStyles.FormattingEnabled = true;
            this.comboBoxStyles.Location = new System.Drawing.Point(145, 244);
            this.comboBoxStyles.Name = "comboBoxStyles";
            this.comboBoxStyles.Size = new System.Drawing.Size(143, 22);
            this.comboBoxStyles.TabIndex = 4;
            this.comboBoxStyles.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyles_SelectedIndexChanged);
            // 
            // WokringTime
            // 
            this.WokringTime.AutoSize = true;
            this.WokringTime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WokringTime.Location = new System.Drawing.Point(164, 334);
            this.WokringTime.Name = "WokringTime";
            this.WokringTime.Size = new System.Drawing.Size(35, 14);
            this.WokringTime.TabIndex = 5;
            this.WokringTime.Text = "Time";
            // 
            // ProgressTime
            // 
            this.ProgressTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ProgressTime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgressTime.FormattingEnabled = true;
            this.ProgressTime.Location = new System.Drawing.Point(145, 351);
            this.ProgressTime.Name = "ProgressTime";
            this.ProgressTime.Size = new System.Drawing.Size(77, 150);
            this.ProgressTime.TabIndex = 7;
            this.ProgressTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxTime_KeyUp);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContinue.Location = new System.Drawing.Point(97, 283);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 8;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReverse.Location = new System.Drawing.Point(213, 283);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(75, 23);
            this.buttonReverse.TabIndex = 9;
            this.buttonReverse.Text = "Reverse";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(381, 592);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.ProgressTime);
            this.Controls.Add(this.WokringTime);
            this.Controls.Add(this.comboBoxStyles);
            this.Controls.Add(this.BarStyle);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.progressBar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Name = "ProgressForm";
            this.Text = "ProgressForm";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label BarStyle;
        private System.Windows.Forms.ComboBox comboBoxStyles;
        private System.Windows.Forms.Label WokringTime;
        private System.Windows.Forms.ComboBox ProgressTime;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonReverse;
    }
}