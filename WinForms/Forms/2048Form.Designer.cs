namespace WinForms.Forms
{
    partial class _2048Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2048Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cell00 = new System.Windows.Forms.Label();
            this.Cell01 = new System.Windows.Forms.Label();
            this.Cell02 = new System.Windows.Forms.Label();
            this.Cell03 = new System.Windows.Forms.Label();
            this.Cell10 = new System.Windows.Forms.Label();
            this.Cell11 = new System.Windows.Forms.Label();
            this.Cell12 = new System.Windows.Forms.Label();
            this.Cell13 = new System.Windows.Forms.Label();
            this.Cell20 = new System.Windows.Forms.Label();
            this.Cell21 = new System.Windows.Forms.Label();
            this.Cell22 = new System.Windows.Forms.Label();
            this.Cell23 = new System.Windows.Forms.Label();
            this.Cell30 = new System.Windows.Forms.Label();
            this.Cell31 = new System.Windows.Forms.Label();
            this.Cell32 = new System.Windows.Forms.Label();
            this.Cell33 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.labelScrollValue = new System.Windows.Forms.Label();
            this.hScrollBarR = new System.Windows.Forms.HScrollBar();
            this.hScrollBarG = new System.Windows.Forms.HScrollBar();
            this.hScrollBarB = new System.Windows.Forms.HScrollBar();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.checkBoxControls = new System.Windows.Forms.CheckBox();
            this.labelMousePos = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOnClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.animateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelRecord = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.Cell00);
            this.panel1.Controls.Add(this.Cell01);
            this.panel1.Controls.Add(this.Cell02);
            this.panel1.Controls.Add(this.Cell03);
            this.panel1.Controls.Add(this.Cell10);
            this.panel1.Controls.Add(this.Cell11);
            this.panel1.Controls.Add(this.Cell12);
            this.panel1.Controls.Add(this.Cell13);
            this.panel1.Controls.Add(this.Cell20);
            this.panel1.Controls.Add(this.Cell21);
            this.panel1.Controls.Add(this.Cell22);
            this.panel1.Controls.Add(this.Cell23);
            this.panel1.Controls.Add(this.Cell30);
            this.panel1.Controls.Add(this.Cell31);
            this.panel1.Controls.Add(this.Cell32);
            this.panel1.Controls.Add(this.Cell33);
            this.panel1.Location = new System.Drawing.Point(12, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 437);
            this.panel1.TabIndex = 0;
            // 
            // Cell00
            // 
            this.Cell00.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell00.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell00.Location = new System.Drawing.Point(9, 9);
            this.Cell00.Margin = new System.Windows.Forms.Padding(3);
            this.Cell00.Name = "Cell00";
            this.Cell00.Size = new System.Drawing.Size(100, 100);
            this.Cell00.TabIndex = 0;
            this.Cell00.Text = "2";
            this.Cell00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell01
            // 
            this.Cell01.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell01.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell01.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cell01.Location = new System.Drawing.Point(115, 9);
            this.Cell01.Margin = new System.Windows.Forms.Padding(3);
            this.Cell01.Name = "Cell01";
            this.Cell01.Size = new System.Drawing.Size(100, 100);
            this.Cell01.TabIndex = 0;
            this.Cell01.Text = "4";
            this.Cell01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell02
            // 
            this.Cell02.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell02.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell02.Location = new System.Drawing.Point(221, 9);
            this.Cell02.Margin = new System.Windows.Forms.Padding(3);
            this.Cell02.Name = "Cell02";
            this.Cell02.Size = new System.Drawing.Size(100, 100);
            this.Cell02.TabIndex = 0;
            this.Cell02.Text = "8";
            this.Cell02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell03
            // 
            this.Cell03.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell03.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell03.Location = new System.Drawing.Point(327, 9);
            this.Cell03.Margin = new System.Windows.Forms.Padding(3);
            this.Cell03.Name = "Cell03";
            this.Cell03.Size = new System.Drawing.Size(100, 100);
            this.Cell03.TabIndex = 0;
            this.Cell03.Text = "16";
            this.Cell03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell10
            // 
            this.Cell10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell10.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell10.Location = new System.Drawing.Point(9, 115);
            this.Cell10.Margin = new System.Windows.Forms.Padding(3);
            this.Cell10.Name = "Cell10";
            this.Cell10.Size = new System.Drawing.Size(100, 100);
            this.Cell10.TabIndex = 0;
            this.Cell10.Text = "32";
            this.Cell10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell11
            // 
            this.Cell11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell11.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell11.Location = new System.Drawing.Point(115, 115);
            this.Cell11.Margin = new System.Windows.Forms.Padding(3);
            this.Cell11.Name = "Cell11";
            this.Cell11.Size = new System.Drawing.Size(100, 100);
            this.Cell11.TabIndex = 0;
            this.Cell11.Text = "64";
            this.Cell11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell12
            // 
            this.Cell12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell12.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell12.Location = new System.Drawing.Point(221, 115);
            this.Cell12.Margin = new System.Windows.Forms.Padding(3);
            this.Cell12.Name = "Cell12";
            this.Cell12.Size = new System.Drawing.Size(100, 100);
            this.Cell12.TabIndex = 0;
            this.Cell12.Text = "128";
            this.Cell12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell13
            // 
            this.Cell13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell13.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell13.Location = new System.Drawing.Point(327, 115);
            this.Cell13.Margin = new System.Windows.Forms.Padding(3);
            this.Cell13.Name = "Cell13";
            this.Cell13.Size = new System.Drawing.Size(100, 100);
            this.Cell13.TabIndex = 0;
            this.Cell13.Text = "256";
            this.Cell13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell20
            // 
            this.Cell20.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell20.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell20.Location = new System.Drawing.Point(9, 221);
            this.Cell20.Margin = new System.Windows.Forms.Padding(3);
            this.Cell20.Name = "Cell20";
            this.Cell20.Size = new System.Drawing.Size(100, 100);
            this.Cell20.TabIndex = 0;
            this.Cell20.Text = "512";
            this.Cell20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell21
            // 
            this.Cell21.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell21.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell21.Location = new System.Drawing.Point(115, 221);
            this.Cell21.Margin = new System.Windows.Forms.Padding(3);
            this.Cell21.Name = "Cell21";
            this.Cell21.Size = new System.Drawing.Size(100, 100);
            this.Cell21.TabIndex = 0;
            this.Cell21.Text = "1024";
            this.Cell21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell22
            // 
            this.Cell22.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell22.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell22.Location = new System.Drawing.Point(221, 221);
            this.Cell22.Margin = new System.Windows.Forms.Padding(3);
            this.Cell22.Name = "Cell22";
            this.Cell22.Size = new System.Drawing.Size(100, 100);
            this.Cell22.TabIndex = 0;
            this.Cell22.Text = "2048";
            this.Cell22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell23
            // 
            this.Cell23.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell23.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell23.Location = new System.Drawing.Point(327, 221);
            this.Cell23.Margin = new System.Windows.Forms.Padding(3);
            this.Cell23.Name = "Cell23";
            this.Cell23.Size = new System.Drawing.Size(100, 100);
            this.Cell23.TabIndex = 0;
            this.Cell23.Text = "0";
            this.Cell23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell30
            // 
            this.Cell30.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell30.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell30.Location = new System.Drawing.Point(9, 327);
            this.Cell30.Margin = new System.Windows.Forms.Padding(3);
            this.Cell30.Name = "Cell30";
            this.Cell30.Size = new System.Drawing.Size(100, 100);
            this.Cell30.TabIndex = 0;
            this.Cell30.Text = "0";
            this.Cell30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell31
            // 
            this.Cell31.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell31.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell31.Location = new System.Drawing.Point(115, 327);
            this.Cell31.Margin = new System.Windows.Forms.Padding(3);
            this.Cell31.Name = "Cell31";
            this.Cell31.Size = new System.Drawing.Size(100, 100);
            this.Cell31.TabIndex = 0;
            this.Cell31.Text = "16";
            this.Cell31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell32
            // 
            this.Cell32.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell32.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell32.Location = new System.Drawing.Point(221, 327);
            this.Cell32.Margin = new System.Windows.Forms.Padding(3);
            this.Cell32.Name = "Cell32";
            this.Cell32.Size = new System.Drawing.Size(100, 100);
            this.Cell32.TabIndex = 0;
            this.Cell32.Text = "0";
            this.Cell32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell33
            // 
            this.Cell33.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cell33.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cell33.Location = new System.Drawing.Point(327, 327);
            this.Cell33.Margin = new System.Windows.Forms.Padding(3);
            this.Cell33.Name = "Cell33";
            this.Cell33.Size = new System.Drawing.Size(100, 100);
            this.Cell33.TabIndex = 0;
            this.Cell33.Text = "0";
            this.Cell33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Enabled = false;
            this.hScrollBar1.Location = new System.Drawing.Point(233, 37);
            this.hScrollBar1.Maximum = 1000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(216, 17);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Value = 450;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.hScrollBar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this._2048Form_KeyDown);
            // 
            // labelScrollValue
            // 
            this.labelScrollValue.AutoSize = true;
            this.labelScrollValue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScrollValue.Location = new System.Drawing.Point(213, 40);
            this.labelScrollValue.Name = "labelScrollValue";
            this.labelScrollValue.Size = new System.Drawing.Size(14, 14);
            this.labelScrollValue.TabIndex = 2;
            this.labelScrollValue.Text = "0";
            // 
            // hScrollBarR
            // 
            this.hScrollBarR.Enabled = false;
            this.hScrollBarR.Location = new System.Drawing.Point(233, 63);
            this.hScrollBarR.Maximum = 255;
            this.hScrollBarR.Name = "hScrollBarR";
            this.hScrollBarR.Size = new System.Drawing.Size(216, 17);
            this.hScrollBarR.TabIndex = 1;
            this.hScrollBarR.Value = 50;
            this.hScrollBarR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.hScrollBarR.KeyDown += new System.Windows.Forms.KeyEventHandler(this._2048Form_KeyDown);
            // 
            // hScrollBarG
            // 
            this.hScrollBarG.Enabled = false;
            this.hScrollBarG.Location = new System.Drawing.Point(233, 89);
            this.hScrollBarG.Maximum = 255;
            this.hScrollBarG.Name = "hScrollBarG";
            this.hScrollBarG.Size = new System.Drawing.Size(216, 17);
            this.hScrollBarG.TabIndex = 1;
            this.hScrollBarG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.hScrollBarG.KeyDown += new System.Windows.Forms.KeyEventHandler(this._2048Form_KeyDown);
            // 
            // hScrollBarB
            // 
            this.hScrollBarB.Enabled = false;
            this.hScrollBarB.Location = new System.Drawing.Point(233, 115);
            this.hScrollBarB.Maximum = 255;
            this.hScrollBarB.Name = "hScrollBarB";
            this.hScrollBarB.Size = new System.Drawing.Size(216, 17);
            this.hScrollBarB.TabIndex = 100;
            this.hScrollBarB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.hScrollBarB.KeyDown += new System.Windows.Forms.KeyEventHandler(this._2048Form_KeyDown);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelR.Location = new System.Drawing.Point(213, 66);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(14, 14);
            this.labelR.TabIndex = 2;
            this.labelR.Text = "0";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelG.Location = new System.Drawing.Point(213, 92);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(14, 14);
            this.labelG.TabIndex = 2;
            this.labelG.Text = "0";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelB.Location = new System.Drawing.Point(213, 118);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 14);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "0";
            // 
            // checkBoxControls
            // 
            this.checkBoxControls.AutoSize = true;
            this.checkBoxControls.Checked = true;
            this.checkBoxControls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxControls.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxControls.Location = new System.Drawing.Point(127, 88);
            this.checkBoxControls.Name = "checkBoxControls";
            this.checkBoxControls.Size = new System.Drawing.Size(82, 18);
            this.checkBoxControls.TabIndex = 4;
            this.checkBoxControls.Text = "Controls";
            this.checkBoxControls.UseVisualStyleBackColor = true;
            this.checkBoxControls.CheckedChanged += new System.EventHandler(this.checkBoxControls_CheckedChanged);
            this.checkBoxControls.KeyDown += new System.Windows.Forms.KeyEventHandler(this._2048Form_KeyDown);
            // 
            // labelMousePos
            // 
            this.labelMousePos.AutoSize = true;
            this.labelMousePos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMousePos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMousePos.Location = new System.Drawing.Point(127, 40);
            this.labelMousePos.Name = "labelMousePos";
            this.labelMousePos.Size = new System.Drawing.Size(35, 14);
            this.labelMousePos.TabIndex = 101;
            this.labelMousePos.Text = "MPos";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.Location = new System.Drawing.Point(127, 66);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(63, 14);
            this.labelTimer.TabIndex = 102;
            this.labelTimer.Text = "00:00:00";
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Enabled = true;
            this.timerAnimation.Interval = 10;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 23);
            this.menuStrip1.TabIndex = 103;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOnClickToolStripMenuItem,
            this.topmostToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // checkOnClickToolStripMenuItem
            // 
            this.checkOnClickToolStripMenuItem.CheckOnClick = true;
            this.checkOnClickToolStripMenuItem.Name = "checkOnClickToolStripMenuItem";
            this.checkOnClickToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F24)));
            this.checkOnClickToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.checkOnClickToolStripMenuItem.Text = "CheckOnClick";
            // 
            // topmostToolStripMenuItem
            // 
            this.topmostToolStripMenuItem.CheckOnClick = true;
            this.topmostToolStripMenuItem.Name = "topmostToolStripMenuItem";
            this.topmostToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.topmostToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.topmostToolStripMenuItem.Text = "Topmost";
            this.topmostToolStripMenuItem.Click += new System.EventHandler(this.topmostToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.undoToolStripMenuItem1,
            this.animateToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem1.Text = "Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // animateToolStripMenuItem
            // 
            this.animateToolStripMenuItem.Checked = true;
            this.animateToolStripMenuItem.CheckOnClick = true;
            this.animateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.animateToolStripMenuItem.Name = "animateToolStripMenuItem";
            this.animateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.animateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animateToolStripMenuItem.Text = "Animate";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.recordToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordToolStripMenuItem.Text = "Record";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecord.Location = new System.Drawing.Point(127, 118);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(49, 14);
            this.labelRecord.TabIndex = 104;
            this.labelRecord.Text = "Record";
            // 
            // _2048Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(461, 599);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelMousePos);
            this.Controls.Add(this.checkBoxControls);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelScrollValue);
            this.Controls.Add(this.hScrollBarB);
            this.Controls.Add(this.hScrollBarG);
            this.Controls.Add(this.hScrollBarR);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "_2048Form";
            this.Text = "2048";
            this.Load += new System.EventHandler(this._2048Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this._2048Form_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this._2048Form_MouseDown);
            this.MouseEnter += new System.EventHandler(this._2048Form_MouseEnter);
            this.MouseLeave += new System.EventHandler(this._2048Form_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this._2048Form_MouseUp);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Cell33;
        private System.Windows.Forms.Label Cell11;
        private System.Windows.Forms.Label Cell32;
        private System.Windows.Forms.Label Cell00;
        private System.Windows.Forms.Label Cell30;
        private System.Windows.Forms.Label Cell01;
        private System.Windows.Forms.Label Cell31;
        private System.Windows.Forms.Label Cell02;
        private System.Windows.Forms.Label Cell23;
        private System.Windows.Forms.Label Cell03;
        private System.Windows.Forms.Label Cell22;
        private System.Windows.Forms.Label Cell10;
        private System.Windows.Forms.Label Cell21;
        private System.Windows.Forms.Label Cell12;
        private System.Windows.Forms.Label Cell20;
        private System.Windows.Forms.Label Cell13;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label labelScrollValue;
        private System.Windows.Forms.HScrollBar hScrollBarR;
        private System.Windows.Forms.HScrollBar hScrollBarG;
        private System.Windows.Forms.HScrollBar hScrollBarB;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.CheckBox checkBoxControls;
        private System.Windows.Forms.Label labelMousePos;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOnClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem animateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelRecord;
    }
}