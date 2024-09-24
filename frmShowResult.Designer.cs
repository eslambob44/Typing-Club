namespace Typing_Club
{
    partial class frmShowResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWordsPerSecond = new System.Windows.Forms.Label();
            this.pbAccuracy = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pbAccuracy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accuracy:";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAccuracy.ForeColor = System.Drawing.Color.Black;
            this.lblAccuracy.Location = new System.Drawing.Point(65, 84);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(64, 25);
            this.lblAccuracy.TabIndex = 2;
            this.lblAccuracy.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Words Per Second:";
            // 
            // lblWordsPerSecond
            // 
            this.lblWordsPerSecond.AutoSize = true;
            this.lblWordsPerSecond.Location = new System.Drawing.Point(395, 358);
            this.lblWordsPerSecond.Name = "lblWordsPerSecond";
            this.lblWordsPerSecond.Size = new System.Drawing.Size(64, 25);
            this.lblWordsPerSecond.TabIndex = 4;
            this.lblWordsPerSecond.Text = "label2";
            // 
            // pbAccuracy
            // 
            this.pbAccuracy.Controls.Add(this.lblAccuracy);
            this.pbAccuracy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pbAccuracy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pbAccuracy.ForeColor = System.Drawing.Color.White;
            this.pbAccuracy.Location = new System.Drawing.Point(284, 91);
            this.pbAccuracy.Minimum = 0;
            this.pbAccuracy.Name = "pbAccuracy";
            this.pbAccuracy.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbAccuracy.Size = new System.Drawing.Size(190, 190);
            this.pbAccuracy.TabIndex = 5;
            this.pbAccuracy.Text = "guna2CircleProgressBar1";
            // 
            // frmShowResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(692, 410);
            this.Controls.Add(this.pbAccuracy);
            this.Controls.Add(this.lblWordsPerSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmShowResult";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.frmShowResult_Load);
            this.pbAccuracy.ResumeLayout(false);
            this.pbAccuracy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWordsPerSecond;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbAccuracy;
    }
}