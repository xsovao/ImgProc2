namespace ImgP
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxlabel = new System.Windows.Forms.Label();
            this.minlabel = new System.Windows.Forms.Label();
            this.img_hist = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fSHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writetxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniform3x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamond13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplace4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplace8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.img_main = new System.Windows.Forms.PictureBox();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numK = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numomg = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numiter = new System.Windows.Forms.NumericUpDown();
            this.numtol = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numh = new System.Windows.Forms.NumericUpDown();
            this.numsteps = new System.Windows.Forms.NumericUpDown();
            this.numt = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pmedge = new System.Windows.Forms.RadioButton();
            this.pm = new System.Windows.Forms.RadioButton();
            this.hflux = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_hist)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numomg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxlabel);
            this.groupBox2.Controls.Add(this.minlabel);
            this.groupBox2.Controls.Add(this.img_hist);
            this.groupBox2.Location = new System.Drawing.Point(671, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(275, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histogram";
            // 
            // maxlabel
            // 
            this.maxlabel.AutoSize = true;
            this.maxlabel.Location = new System.Drawing.Point(229, 22);
            this.maxlabel.Name = "maxlabel";
            this.maxlabel.Size = new System.Drawing.Size(33, 17);
            this.maxlabel.TabIndex = 2;
            this.maxlabel.Text = "max";
            // 
            // minlabel
            // 
            this.minlabel.AutoSize = true;
            this.minlabel.Location = new System.Drawing.Point(7, 22);
            this.minlabel.Name = "minlabel";
            this.minlabel.Size = new System.Drawing.Size(30, 17);
            this.minlabel.TabIndex = 1;
            this.minlabel.Text = "min";
            // 
            // img_hist
            // 
            this.img_hist.Location = new System.Drawing.Point(5, 49);
            this.img_hist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_hist.Name = "img_hist";
            this.img_hist.Size = new System.Drawing.Size(256, 256);
            this.img_hist.TabIndex = 0;
            this.img_hist.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.originalToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.convolveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_open});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(120, 26);
            this.menu_open.Text = "Open";
            this.menu_open.Click += new System.EventHandler(this.menu_open_Click);
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fSHSToolStripMenuItem,
            this.equalizeToolStripMenuItem,
            this.writetxtToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.operationToolStripMenuItem.Text = "HistOp";
            // 
            // fSHSToolStripMenuItem
            // 
            this.fSHSToolStripMenuItem.Name = "fSHSToolStripMenuItem";
            this.fSHSToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.fSHSToolStripMenuItem.Text = "FSHS";
            this.fSHSToolStripMenuItem.Click += new System.EventHandler(this.fSHSToolStripMenuItem_Click);
            // 
            // equalizeToolStripMenuItem
            // 
            this.equalizeToolStripMenuItem.Name = "equalizeToolStripMenuItem";
            this.equalizeToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.equalizeToolStripMenuItem.Text = "Equalize";
            this.equalizeToolStripMenuItem.Click += new System.EventHandler(this.equalizeToolStripMenuItem_Click);
            // 
            // writetxtToolStripMenuItem
            // 
            this.writetxtToolStripMenuItem.Name = "writetxtToolStripMenuItem";
            this.writetxtToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.writetxtToolStripMenuItem.Text = "Write .txt";
            this.writetxtToolStripMenuItem.Click += new System.EventHandler(this.writetxtToolStripMenuItem_Click);
            // 
            // convolveToolStripMenuItem
            // 
            this.convolveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.edgeDetectToolStripMenuItem,
            this.embossToolStripMenuItem});
            this.convolveToolStripMenuItem.Name = "convolveToolStripMenuItem";
            this.convolveToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.convolveToolStripMenuItem.Text = "Convolve";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uniform3x3ToolStripMenuItem,
            this.diamond13ToolStripMenuItem});
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            // 
            // uniform3x3ToolStripMenuItem
            // 
            this.uniform3x3ToolStripMenuItem.Name = "uniform3x3ToolStripMenuItem";
            this.uniform3x3ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.uniform3x3ToolStripMenuItem.Text = "uniform 3x3 ";
            this.uniform3x3ToolStripMenuItem.Click += new System.EventHandler(this.uniform3x3ToolStripMenuItem_Click);
            // 
            // diamond13ToolStripMenuItem
            // 
            this.diamond13ToolStripMenuItem.Name = "diamond13ToolStripMenuItem";
            this.diamond13ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.diamond13ToolStripMenuItem.Text = "diamond /13";
            this.diamond13ToolStripMenuItem.Click += new System.EventHandler(this.diamond13ToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.x5ToolStripMenuItem});
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.x3ToolStripMenuItem.Text = "[3x3]";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.x5ToolStripMenuItem.Text = "[5x5]";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            // 
            // edgeDetectToolStripMenuItem
            // 
            this.edgeDetectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplace4ToolStripMenuItem,
            this.laplace8ToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.diagonalToolStripMenuItem});
            this.edgeDetectToolStripMenuItem.Name = "edgeDetectToolStripMenuItem";
            this.edgeDetectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.edgeDetectToolStripMenuItem.Text = "Edge Detect";
            // 
            // laplace4ToolStripMenuItem
            // 
            this.laplace4ToolStripMenuItem.Name = "laplace4ToolStripMenuItem";
            this.laplace4ToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.laplace4ToolStripMenuItem.Text = "Laplace 4";
            this.laplace4ToolStripMenuItem.Click += new System.EventHandler(this.laplace4ToolStripMenuItem_Click);
            // 
            // laplace8ToolStripMenuItem
            // 
            this.laplace8ToolStripMenuItem.Name = "laplace8ToolStripMenuItem";
            this.laplace8ToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.laplace8ToolStripMenuItem.Text = "Laplace 8";
            this.laplace8ToolStripMenuItem.Click += new System.EventHandler(this.laplace8ToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // diagonalToolStripMenuItem
            // 
            this.diagonalToolStripMenuItem.Name = "diagonalToolStripMenuItem";
            this.diagonalToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.diagonalToolStripMenuItem.Text = "Diagonal";
            this.diagonalToolStripMenuItem.Click += new System.EventHandler(this.diagonalToolStripMenuItem_Click);
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem1,
            this.x5ToolStripMenuItem1});
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.embossToolStripMenuItem.Text = "Emboss";
            // 
            // x3ToolStripMenuItem1
            // 
            this.x3ToolStripMenuItem1.Name = "x3ToolStripMenuItem1";
            this.x3ToolStripMenuItem1.Size = new System.Drawing.Size(117, 26);
            this.x3ToolStripMenuItem1.Text = "[3x3]";
            this.x3ToolStripMenuItem1.Click += new System.EventHandler(this.x3ToolStripMenuItem1_Click);
            // 
            // x5ToolStripMenuItem1
            // 
            this.x5ToolStripMenuItem1.Name = "x5ToolStripMenuItem1";
            this.x5ToolStripMenuItem1.Size = new System.Drawing.Size(117, 26);
            this.x5ToolStripMenuItem1.Text = "[5x5]";
            this.x5ToolStripMenuItem1.Click += new System.EventHandler(this.x5ToolStripMenuItem1_Click);
            // 
            // img_main
            // 
            this.img_main.BackColor = System.Drawing.SystemColors.ControlDark;
            this.img_main.Location = new System.Drawing.Point(23, 33);
            this.img_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_main.Name = "img_main";
            this.img_main.Size = new System.Drawing.Size(643, 615);
            this.img_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_main.TabIndex = 3;
            this.img_main.TabStop = false;
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(23, 652);
            this.txtlog.Margin = new System.Windows.Forms.Padding(4);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(921, 22);
            this.txtlog.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.numK);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numomg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numiter);
            this.groupBox1.Controls.Add(this.numtol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.calc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numh);
            this.groupBox1.Controls.Add(this.numsteps);
            this.groupBox1.Controls.Add(this.numt);
            this.groupBox1.Location = new System.Drawing.Point(671, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(281, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Num Solver";
            // 
            // numK
            // 
            this.numK.DecimalPlaces = 2;
            this.numK.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numK.Location = new System.Drawing.Point(57, 189);
            this.numK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numK.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numK.Name = "numK";
            this.numK.Size = new System.Drawing.Size(80, 22);
            this.numK.TabIndex = 19;
            this.numK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "K =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "omg = ";
            // 
            // numomg
            // 
            this.numomg.DecimalPlaces = 2;
            this.numomg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numomg.Location = new System.Drawing.Point(205, 189);
            this.numomg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numomg.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numomg.Name = "numomg";
            this.numomg.Size = new System.Drawing.Size(68, 22);
            this.numomg.TabIndex = 16;
            this.numomg.Value = new decimal(new int[] {
            125,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Implicit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "calculate\r\nimplicit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "iter = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = " tol = 10E-";
            // 
            // numiter
            // 
            this.numiter.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numiter.Location = new System.Drawing.Point(206, 160);
            this.numiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numiter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numiter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numiter.Name = "numiter";
            this.numiter.Size = new System.Drawing.Size(68, 22);
            this.numiter.TabIndex = 10;
            this.numiter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numtol
            // 
            this.numtol.Location = new System.Drawing.Point(234, 133);
            this.numtol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numtol.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numtol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numtol.Name = "numtol";
            this.numtol.Size = new System.Drawing.Size(40, 22);
            this.numtol.TabIndex = 8;
            this.numtol.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Explicit";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(6, 253);
            this.calc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(124, 42);
            this.calc.TabIndex = 6;
            this.calc.Text = "calculate\r\nexplicit";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "steps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "h =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "tau=";
            // 
            // numh
            // 
            this.numh.DecimalPlaces = 2;
            this.numh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numh.Location = new System.Drawing.Point(57, 160);
            this.numh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numh.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numh.Name = "numh";
            this.numh.Size = new System.Drawing.Size(80, 22);
            this.numh.TabIndex = 2;
            this.numh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numsteps
            // 
            this.numsteps.Location = new System.Drawing.Point(121, 224);
            this.numsteps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numsteps.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numsteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numsteps.Name = "numsteps";
            this.numsteps.Size = new System.Drawing.Size(80, 22);
            this.numsteps.TabIndex = 1;
            this.numsteps.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numt
            // 
            this.numt.DecimalPlaces = 2;
            this.numt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numt.Location = new System.Drawing.Point(57, 133);
            this.numt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numt.Name = "numt";
            this.numt.Size = new System.Drawing.Size(80, 22);
            this.numt.TabIndex = 0;
            this.numt.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pmedge);
            this.panel1.Controls.Add(this.pm);
            this.panel1.Controls.Add(this.hflux);
            this.panel1.Location = new System.Drawing.Point(10, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 20;
            // 
            // pmedge
            // 
            this.pmedge.AutoSize = true;
            this.pmedge.Location = new System.Drawing.Point(3, 57);
            this.pmedge.Name = "pmedge";
            this.pmedge.Size = new System.Drawing.Size(194, 21);
            this.pmedge.TabIndex = 25;
            this.pmedge.Text = "Perona-Malik Edge Detect";
            this.pmedge.UseVisualStyleBackColor = true;
            // 
            // pm
            // 
            this.pm.AutoSize = true;
            this.pm.Location = new System.Drawing.Point(3, 30);
            this.pm.Name = "pm";
            this.pm.Size = new System.Drawing.Size(112, 21);
            this.pm.TabIndex = 24;
            this.pm.Text = "Perona-Malik";
            this.pm.UseVisualStyleBackColor = true;
            // 
            // hflux
            // 
            this.hflux.AutoSize = true;
            this.hflux.Checked = true;
            this.hflux.Location = new System.Drawing.Point(3, 3);
            this.hflux.Name = "hflux";
            this.hflux.Size = new System.Drawing.Size(88, 21);
            this.hflux.TabIndex = 23;
            this.hflux.TabStop = true;
            this.hflux.Text = "Heat Flux";
            this.hflux.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.hflux.UseVisualStyleBackColor = true;
            this.hflux.CheckedChanged += new System.EventHandler(this.hflux_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 687);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.img_main);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "IMG_Sova";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_hist)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numomg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.PictureBox img_hist;
        private System.Windows.Forms.PictureBox img_main;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fSHSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizeToolStripMenuItem;
        private System.Windows.Forms.Label maxlabel;
        private System.Windows.Forms.Label minlabel;
        private System.Windows.Forms.ToolStripMenuItem convolveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniform3x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diamond13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplace4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplace8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writetxtToolStripMenuItem;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numomg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numiter;
        private System.Windows.Forms.NumericUpDown numtol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numh;
        private System.Windows.Forms.NumericUpDown numsteps;
        private System.Windows.Forms.NumericUpDown numt;
        private System.Windows.Forms.NumericUpDown numK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton pmedge;
        private System.Windows.Forms.RadioButton pm;
        private System.Windows.Forms.RadioButton hflux;
    }
}

