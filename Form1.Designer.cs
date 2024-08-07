namespace Typing_Club
{
    partial class frmMain
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
            this.cbQuateLength = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfQuates = new System.Windows.Forms.Label();
            this.btnNewQuate = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerCountTime = new System.Windows.Forms.Timer(this.components);
            this.rtxtTyping = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRatioWordsPerQuateLength = new System.Windows.Forms.Label();
            this.cmsTxt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnSemicolon = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnSingleQuatetion = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnForwardSlash = new System.Windows.Forms.Button();
            this.btnFullStop = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnLeftShift = new System.Windows.Forms.Button();
            this.btnOpenSquareBracket = new System.Windows.Forms.Button();
            this.btnCloseSquareBracket = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnCapsLock = new System.Windows.Forms.Button();
            this.btnTab = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmsTxt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbQuateLength
            // 
            this.cbQuateLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuateLength.FormattingEnabled = true;
            this.cbQuateLength.Location = new System.Drawing.Point(649, 24);
            this.cbQuateLength.Name = "cbQuateLength";
            this.cbQuateLength.Size = new System.Drawing.Size(166, 33);
            this.cbQuateLength.TabIndex = 0;
            this.cbQuateLength.SelectedIndexChanged += new System.EventHandler(this.cbQuateLength_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(786, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quates";
            // 
            // lblNumberOfQuates
            // 
            this.lblNumberOfQuates.AutoSize = true;
            this.lblNumberOfQuates.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNumberOfQuates.Location = new System.Drawing.Point(818, 364);
            this.lblNumberOfQuates.Name = "lblNumberOfQuates";
            this.lblNumberOfQuates.Size = new System.Drawing.Size(40, 25);
            this.lblNumberOfQuates.TabIndex = 3;
            this.lblNumberOfQuates.Text = "0/0";
            // 
            // btnNewQuate
            // 
            this.btnNewQuate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewQuate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewQuate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewQuate.Location = new System.Drawing.Point(127, 24);
            this.btnNewQuate.Name = "btnNewQuate";
            this.btnNewQuate.Size = new System.Drawing.Size(145, 33);
            this.btnNewQuate.TabIndex = 1;
            this.btnNewQuate.Text = "New Quate";
            this.btnNewQuate.UseVisualStyleBackColor = false;
            this.btnNewQuate.Click += new System.EventHandler(this.btnNewQuate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTime.Location = new System.Drawing.Point(143, 364);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 25);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "0s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(143, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Timer";
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(416, 337);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 33);
            this.btnStart.TabIndex = 2;
            this.btnStart.Tag = "0";
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerCountTime
            // 
            this.timerCountTime.Interval = 1000;
            this.timerCountTime.Tick += new System.EventHandler(this.timerCountTime_Tick);
            // 
            // rtxtTyping
            // 
            this.rtxtTyping.ContextMenuStrip = this.cmsTxt;
            this.rtxtTyping.Location = new System.Drawing.Point(41, 83);
            this.rtxtTyping.Name = "rtxtTyping";
            this.rtxtTyping.ReadOnly = true;
            this.rtxtTyping.Size = new System.Drawing.Size(906, 212);
            this.rtxtTyping.TabIndex = 8;
            this.rtxtTyping.TabStop = false;
            this.rtxtTyping.Text = "";
            this.rtxtTyping.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtTyping_KeyDown);
            this.rtxtTyping.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtTyping_KeyPress);
            this.rtxtTyping.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtxtTyping_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quate Length:";
            // 
            // lblRatioWordsPerQuateLength
            // 
            this.lblRatioWordsPerQuateLength.AutoSize = true;
            this.lblRatioWordsPerQuateLength.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRatioWordsPerQuateLength.Location = new System.Drawing.Point(470, 389);
            this.lblRatioWordsPerQuateLength.Name = "lblRatioWordsPerQuateLength";
            this.lblRatioWordsPerQuateLength.Size = new System.Drawing.Size(40, 25);
            this.lblRatioWordsPerQuateLength.TabIndex = 10;
            this.lblRatioWordsPerQuateLength.Text = "0/0";
            this.lblRatioWordsPerQuateLength.Visible = false;
            // 
            // cmsTxt
            // 
            this.cmsTxt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.cmsTxt.Name = "cmsTxt";
            this.cmsTxt.Size = new System.Drawing.Size(104, 48);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowEffects = false;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSpace);
            this.panel1.Controls.Add(this.btnTab);
            this.panel1.Controls.Add(this.btnCapsLock);
            this.panel1.Controls.Add(this.btnBackSpace);
            this.panel1.Controls.Add(this.btnCloseSquareBracket);
            this.panel1.Controls.Add(this.btnOpenSquareBracket);
            this.panel1.Controls.Add(this.btnLeftShift);
            this.panel1.Controls.Add(this.btnForwardSlash);
            this.panel1.Controls.Add(this.btnFullStop);
            this.panel1.Controls.Add(this.btnComma);
            this.panel1.Controls.Add(this.btnM);
            this.panel1.Controls.Add(this.btnN);
            this.panel1.Controls.Add(this.btnB);
            this.panel1.Controls.Add(this.btnV);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnZ);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.btnSingleQuatetion);
            this.panel1.Controls.Add(this.btnSemicolon);
            this.panel1.Controls.Add(this.btnL);
            this.panel1.Controls.Add(this.btnK);
            this.panel1.Controls.Add(this.btnJ);
            this.panel1.Controls.Add(this.btnH);
            this.panel1.Controls.Add(this.btnG);
            this.panel1.Controls.Add(this.btnF);
            this.panel1.Controls.Add(this.btnS);
            this.panel1.Controls.Add(this.btnD);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Controls.Add(this.btnP);
            this.panel1.Controls.Add(this.btnO);
            this.panel1.Controls.Add(this.btnI);
            this.panel1.Controls.Add(this.btnU);
            this.panel1.Controls.Add(this.btnY);
            this.panel1.Controls.Add(this.btnT);
            this.panel1.Controls.Add(this.btnR);
            this.panel1.Controls.Add(this.btnE);
            this.panel1.Controls.Add(this.btnW);
            this.panel1.Controls.Add(this.btnQ);
            this.panel1.Location = new System.Drawing.Point(138, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 148);
            this.panel1.TabIndex = 12;
            // 
            // btnQ
            // 
            this.btnQ.Enabled = false;
            this.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(130, 19);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(34, 26);
            this.btnQ.TabIndex = 0;
            this.btnQ.TabStop = false;
            this.btnQ.Text = "q";
            this.btnQ.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            this.btnW.Enabled = false;
            this.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(170, 19);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(34, 26);
            this.btnW.TabIndex = 1;
            this.btnW.TabStop = false;
            this.btnW.Text = "w";
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Enabled = false;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(210, 19);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(34, 26);
            this.btnE.TabIndex = 2;
            this.btnE.TabStop = false;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.Enabled = false;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(250, 19);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(34, 26);
            this.btnR.TabIndex = 3;
            this.btnR.TabStop = false;
            this.btnR.Text = "r";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            this.btnT.Enabled = false;
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(290, 19);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(34, 26);
            this.btnT.TabIndex = 4;
            this.btnT.TabStop = false;
            this.btnT.Text = "t";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            this.btnP.Enabled = false;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(490, 19);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(34, 26);
            this.btnP.TabIndex = 9;
            this.btnP.TabStop = false;
            this.btnP.Text = "p";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            this.btnO.Enabled = false;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(450, 19);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(34, 26);
            this.btnO.TabIndex = 8;
            this.btnO.TabStop = false;
            this.btnO.Text = "o";
            this.btnO.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            this.btnI.Enabled = false;
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(410, 19);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(34, 26);
            this.btnI.TabIndex = 7;
            this.btnI.TabStop = false;
            this.btnI.Text = "i";
            this.btnI.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.Enabled = false;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(370, 19);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(34, 26);
            this.btnU.TabIndex = 6;
            this.btnU.TabStop = false;
            this.btnU.Text = "u";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            this.btnY.Enabled = false;
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(330, 19);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(34, 26);
            this.btnY.TabIndex = 5;
            this.btnY.TabStop = false;
            this.btnY.Text = "y";
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // btnSemicolon
            // 
            this.btnSemicolon.Enabled = false;
            this.btnSemicolon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemicolon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemicolon.Location = new System.Drawing.Point(509, 51);
            this.btnSemicolon.Name = "btnSemicolon";
            this.btnSemicolon.Size = new System.Drawing.Size(34, 26);
            this.btnSemicolon.TabIndex = 19;
            this.btnSemicolon.TabStop = false;
            this.btnSemicolon.Text = ";";
            this.btnSemicolon.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            this.btnL.Enabled = false;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(469, 51);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(34, 26);
            this.btnL.TabIndex = 18;
            this.btnL.TabStop = false;
            this.btnL.Text = "l";
            this.btnL.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            this.btnK.Enabled = false;
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(429, 51);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(34, 26);
            this.btnK.TabIndex = 17;
            this.btnK.TabStop = false;
            this.btnK.Text = "k";
            this.btnK.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            this.btnJ.Enabled = false;
            this.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(389, 51);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(34, 26);
            this.btnJ.TabIndex = 16;
            this.btnJ.TabStop = false;
            this.btnJ.Text = "j";
            this.btnJ.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            this.btnH.Enabled = false;
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(349, 51);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(34, 26);
            this.btnH.TabIndex = 15;
            this.btnH.TabStop = false;
            this.btnH.Text = "h";
            this.btnH.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            this.btnG.Enabled = false;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(309, 51);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(34, 26);
            this.btnG.TabIndex = 14;
            this.btnG.TabStop = false;
            this.btnG.Text = "g";
            this.btnG.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            this.btnF.Enabled = false;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(269, 51);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(34, 26);
            this.btnF.TabIndex = 13;
            this.btnF.TabStop = false;
            this.btnF.Text = "f";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.Enabled = false;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(189, 51);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(34, 26);
            this.btnS.TabIndex = 12;
            this.btnS.TabStop = false;
            this.btnS.Text = "s";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Enabled = false;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(229, 51);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(34, 26);
            this.btnD.TabIndex = 11;
            this.btnD.TabStop = false;
            this.btnD.Text = "d";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(149, 51);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(34, 26);
            this.btnA.TabIndex = 10;
            this.btnA.TabStop = false;
            this.btnA.Text = "a";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnSingleQuatetion
            // 
            this.btnSingleQuatetion.Enabled = false;
            this.btnSingleQuatetion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleQuatetion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleQuatetion.Location = new System.Drawing.Point(549, 51);
            this.btnSingleQuatetion.Name = "btnSingleQuatetion";
            this.btnSingleQuatetion.Size = new System.Drawing.Size(34, 26);
            this.btnSingleQuatetion.TabIndex = 20;
            this.btnSingleQuatetion.TabStop = false;
            this.btnSingleQuatetion.Text = "\'";
            this.btnSingleQuatetion.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Enabled = false;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(589, 51);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(74, 26);
            this.btnEnter.TabIndex = 21;
            this.btnEnter.TabStop = false;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnForwardSlash
            // 
            this.btnForwardSlash.Enabled = false;
            this.btnForwardSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForwardSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForwardSlash.Location = new System.Drawing.Point(518, 83);
            this.btnForwardSlash.Name = "btnForwardSlash";
            this.btnForwardSlash.Size = new System.Drawing.Size(34, 26);
            this.btnForwardSlash.TabIndex = 31;
            this.btnForwardSlash.TabStop = false;
            this.btnForwardSlash.Text = "/";
            this.btnForwardSlash.UseVisualStyleBackColor = true;
            // 
            // btnFullStop
            // 
            this.btnFullStop.Enabled = false;
            this.btnFullStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullStop.Location = new System.Drawing.Point(478, 83);
            this.btnFullStop.Name = "btnFullStop";
            this.btnFullStop.Size = new System.Drawing.Size(34, 26);
            this.btnFullStop.TabIndex = 30;
            this.btnFullStop.TabStop = false;
            this.btnFullStop.Text = ".";
            this.btnFullStop.UseVisualStyleBackColor = true;
            // 
            // btnComma
            // 
            this.btnComma.Enabled = false;
            this.btnComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Location = new System.Drawing.Point(438, 83);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(34, 26);
            this.btnComma.TabIndex = 29;
            this.btnComma.TabStop = false;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.Enabled = false;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(398, 83);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(34, 26);
            this.btnM.TabIndex = 28;
            this.btnM.TabStop = false;
            this.btnM.Text = "m";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            this.btnN.Enabled = false;
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(358, 83);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(34, 26);
            this.btnN.TabIndex = 27;
            this.btnN.TabStop = false;
            this.btnN.Text = "n";
            this.btnN.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Enabled = false;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(318, 83);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(34, 26);
            this.btnB.TabIndex = 26;
            this.btnB.TabStop = false;
            this.btnB.Text = "b";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            this.btnV.Enabled = false;
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(278, 83);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(34, 26);
            this.btnV.TabIndex = 25;
            this.btnV.TabStop = false;
            this.btnV.Text = "v";
            this.btnV.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.Enabled = false;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(198, 83);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(34, 26);
            this.btnX.TabIndex = 24;
            this.btnX.TabStop = false;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Enabled = false;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(238, 83);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(34, 26);
            this.btnC.TabIndex = 23;
            this.btnC.TabStop = false;
            this.btnC.Text = "c";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            this.btnZ.Enabled = false;
            this.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(158, 83);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(34, 26);
            this.btnZ.TabIndex = 22;
            this.btnZ.TabStop = false;
            this.btnZ.Text = "z";
            this.btnZ.UseVisualStyleBackColor = true;
            // 
            // btnLeftShift
            // 
            this.btnLeftShift.Enabled = false;
            this.btnLeftShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftShift.Location = new System.Drawing.Point(47, 83);
            this.btnLeftShift.Name = "btnLeftShift";
            this.btnLeftShift.Size = new System.Drawing.Size(105, 26);
            this.btnLeftShift.TabIndex = 33;
            this.btnLeftShift.TabStop = false;
            this.btnLeftShift.Text = "Shift";
            this.btnLeftShift.UseVisualStyleBackColor = true;
            // 
            // btnOpenSquareBracket
            // 
            this.btnOpenSquareBracket.Enabled = false;
            this.btnOpenSquareBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSquareBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSquareBracket.Location = new System.Drawing.Point(530, 19);
            this.btnOpenSquareBracket.Name = "btnOpenSquareBracket";
            this.btnOpenSquareBracket.Size = new System.Drawing.Size(34, 26);
            this.btnOpenSquareBracket.TabIndex = 35;
            this.btnOpenSquareBracket.TabStop = false;
            this.btnOpenSquareBracket.Text = "[";
            this.btnOpenSquareBracket.UseVisualStyleBackColor = true;
            // 
            // btnCloseSquareBracket
            // 
            this.btnCloseSquareBracket.Enabled = false;
            this.btnCloseSquareBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSquareBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSquareBracket.Location = new System.Drawing.Point(570, 19);
            this.btnCloseSquareBracket.Name = "btnCloseSquareBracket";
            this.btnCloseSquareBracket.Size = new System.Drawing.Size(34, 26);
            this.btnCloseSquareBracket.TabIndex = 36;
            this.btnCloseSquareBracket.TabStop = false;
            this.btnCloseSquareBracket.Text = "]";
            this.btnCloseSquareBracket.UseVisualStyleBackColor = true;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Enabled = false;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.Location = new System.Drawing.Point(610, 19);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(53, 26);
            this.btnBackSpace.TabIndex = 37;
            this.btnBackSpace.TabStop = false;
            this.btnBackSpace.Text = "<---";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            // 
            // btnCapsLock
            // 
            this.btnCapsLock.Enabled = false;
            this.btnCapsLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapsLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapsLock.Location = new System.Drawing.Point(47, 51);
            this.btnCapsLock.Name = "btnCapsLock";
            this.btnCapsLock.Size = new System.Drawing.Size(99, 26);
            this.btnCapsLock.TabIndex = 38;
            this.btnCapsLock.TabStop = false;
            this.btnCapsLock.Text = "Caps Lock";
            this.btnCapsLock.UseVisualStyleBackColor = true;
            // 
            // btnTab
            // 
            this.btnTab.Enabled = false;
            this.btnTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab.Location = new System.Drawing.Point(47, 19);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(77, 26);
            this.btnTab.TabIndex = 39;
            this.btnTab.TabStop = false;
            this.btnTab.Text = "Tab";
            this.btnTab.UseVisualStyleBackColor = true;
            // 
            // btnSpace
            // 
            this.btnSpace.Enabled = false;
            this.btnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.Location = new System.Drawing.Point(238, 115);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(194, 26);
            this.btnSpace.TabIndex = 40;
            this.btnSpace.TabStop = false;
            this.btnSpace.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(558, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 26);
            this.button1.TabIndex = 41;
            this.button1.TabStop = false;
            this.button1.Text = "Shift";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRatioWordsPerQuateLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtTyping);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNewQuate);
            this.Controls.Add(this.lblNumberOfQuates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuateLength);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Typing Club";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsTxt.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbQuateLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfQuates;
        private System.Windows.Forms.Button btnNewQuate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerCountTime;
        private System.Windows.Forms.RichTextBox rtxtTyping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRatioWordsPerQuateLength;
        private System.Windows.Forms.ContextMenuStrip cmsTxt;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnSemicolon;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnLeftShift;
        private System.Windows.Forms.Button btnForwardSlash;
        private System.Windows.Forms.Button btnFullStop;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnSingleQuatetion;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnCloseSquareBracket;
        private System.Windows.Forms.Button btnOpenSquareBracket;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Button btnCapsLock;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button button1;
    }
}

