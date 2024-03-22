namespace FinalProject
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
            this.ReportBlack = new System.Windows.Forms.Button();
            this.CheckBlack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportBlack
            // 
            this.ReportBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBlack.Location = new System.Drawing.Point(398, 374);
            this.ReportBlack.Name = "ReportBlack";
            this.ReportBlack.Size = new System.Drawing.Size(169, 50);
            this.ReportBlack.TabIndex = 0;
            this.ReportBlack.Text = "แจ้งผู้ขายที่ควรระวัง";
            this.ReportBlack.UseVisualStyleBackColor = true;
            this.ReportBlack.Click += new System.EventHandler(this.ReportBlack_Click);
            // 
            // CheckBlack
            // 
            this.CheckBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBlack.Location = new System.Drawing.Point(849, 374);
            this.CheckBlack.Name = "CheckBlack";
            this.CheckBlack.Size = new System.Drawing.Size(169, 50);
            this.CheckBlack.TabIndex = 0;
            this.CheckBlack.Text = "ตรวจสอบบัญชี/ผู้ขาย";
            this.CheckBlack.UseVisualStyleBackColor = true;
            this.CheckBlack.Click += new System.EventHandler(this.CheckBlack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.BlacklistPNG;
            this.pictureBox1.Location = new System.Drawing.Point(579, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 689);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckBlack);
            this.Controls.Add(this.ReportBlack);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReportBlack;
        private System.Windows.Forms.Button CheckBlack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

