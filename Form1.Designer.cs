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
            this.button2 = new System.Windows.Forms.Button();
            this.timerCountTime = new System.Windows.Forms.Timer(this.components);
            this.rtxtTyping = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cbQuateLength
            // 
            this.cbQuateLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuateLength.FormattingEnabled = true;
            this.cbQuateLength.Location = new System.Drawing.Point(649, 24);
            this.cbQuateLength.Name = "cbQuateLength";
            this.cbQuateLength.Size = new System.Drawing.Size(166, 33);
            this.cbQuateLength.TabIndex = 1;
            this.cbQuateLength.SelectedIndexChanged += new System.EventHandler(this.cbQuateLength_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(785, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quates";
            // 
            // lblNumberOfQuates
            // 
            this.lblNumberOfQuates.AutoSize = true;
            this.lblNumberOfQuates.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNumberOfQuates.Location = new System.Drawing.Point(817, 462);
            this.lblNumberOfQuates.Name = "lblNumberOfQuates";
            this.lblNumberOfQuates.Size = new System.Drawing.Size(40, 25);
            this.lblNumberOfQuates.TabIndex = 3;
            this.lblNumberOfQuates.Text = "0/0";
            // 
            // btnNewQuate
            // 
            this.btnNewQuate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewQuate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewQuate.Location = new System.Drawing.Point(127, 24);
            this.btnNewQuate.Name = "btnNewQuate";
            this.btnNewQuate.Size = new System.Drawing.Size(145, 33);
            this.btnNewQuate.TabIndex = 4;
            this.btnNewQuate.Text = "New Quate";
            this.btnNewQuate.UseVisualStyleBackColor = true;
            this.btnNewQuate.Click += new System.EventHandler(this.btnNewQuate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTime.Location = new System.Drawing.Point(142, 462);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 25);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "0s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(142, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Timer";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(415, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerCountTime
            // 
            this.timerCountTime.Interval = 1000;
            this.timerCountTime.Tick += new System.EventHandler(this.timerCountTime_Tick);
            // 
            // txtTyping
            // 
            this.rtxtTyping.Location = new System.Drawing.Point(41, 83);
            this.rtxtTyping.Name = "rtxtTyping";
            this.rtxtTyping.Size = new System.Drawing.Size(906, 309);
            this.rtxtTyping.TabIndex = 8;
            this.rtxtTyping.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(981, 537);
            this.Controls.Add(this.rtxtTyping);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerCountTime;
        private System.Windows.Forms.RichTextBox rtxtTyping;
    }
}

