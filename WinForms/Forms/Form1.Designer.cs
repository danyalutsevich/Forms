namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.ButtonDemo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.Notifications = new System.Windows.Forms.CheckBox();
            this.GetNotifications = new System.Windows.Forms.Label();
            this.ListBoxDemo = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("FuturaMediumC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(344, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(85, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "LABEL";
            // 
            // ButtonDemo
            // 
            this.ButtonDemo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDemo.Location = new System.Drawing.Point(114, 88);
            this.ButtonDemo.Name = "ButtonDemo";
            this.ButtonDemo.Size = new System.Drawing.Size(75, 23);
            this.ButtonDemo.TabIndex = 1;
            this.ButtonDemo.Text = "Press me";
            this.ButtonDemo.UseVisualStyleBackColor = true;
            this.ButtonDemo.Click += new System.EventHandler(this.ButtonDemo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Programme Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Button:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(114, 121);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(115, 23);
            this.text.TabIndex = 4;
            this.text.Text = "What a nice text";
            // 
            // Notifications
            // 
            this.Notifications.AutoSize = true;
            this.Notifications.Location = new System.Drawing.Point(114, 149);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(15, 14);
            this.Notifications.TabIndex = 5;
            this.Notifications.UseVisualStyleBackColor = true;
            this.Notifications.CheckedChanged += new System.EventHandler(this.Notifications_CheckedChanged);
            // 
            // GetNotifications
            // 
            this.GetNotifications.AutoSize = true;
            this.GetNotifications.Location = new System.Drawing.Point(12, 148);
            this.GetNotifications.Name = "GetNotifications";
            this.GetNotifications.Size = new System.Drawing.Size(96, 15);
            this.GetNotifications.TabIndex = 6;
            this.GetNotifications.Text = "Get Notifications";
            // 
            // ListBoxDemo
            // 
            this.ListBoxDemo.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxDemo.FormattingEnabled = true;
            this.ListBoxDemo.ItemHeight = 19;
            this.ListBoxDemo.Location = new System.Drawing.Point(417, 44);
            this.ListBoxDemo.Name = "ListBoxDemo";
            this.ListBoxDemo.Size = new System.Drawing.Size(371, 384);
            this.ListBoxDemo.TabIndex = 7;
            this.ListBoxDemo.DoubleClick += new System.EventHandler(this.ListBoxDemo_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(12, 172);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(35, 15);
            this.Input.TabIndex = 9;
            this.Input.Text = "Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListBoxDemo);
            this.Controls.Add(this.GetNotifications);
            this.Controls.Add(this.Notifications);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonDemo);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button ButtonDemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.CheckBox Notifications;
        private System.Windows.Forms.Label GetNotifications;
        private System.Windows.Forms.ListBox ListBoxDemo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Input;
    }
}
