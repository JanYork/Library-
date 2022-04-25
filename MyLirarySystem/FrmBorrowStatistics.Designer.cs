namespace MyLirarySystem
{
    partial class FrmBorrowStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorrowStatistics));
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCountSum = new System.Windows.Forms.Label();
            this.lblSumBooks = new System.Windows.Forms.Label();
            this.lblSumShu = new System.Windows.Forms.Label();
            this.lblShu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.btnBorOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.ForeColor = System.Drawing.Color.Black;
            this.lblBooks.Location = new System.Drawing.Point(27, 58);
            this.lblBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(136, 21);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "借阅图书总册：";
            // 
            // lblBorrow
            // 
            this.lblBorrow.AutoSize = true;
            this.lblBorrow.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrow.ForeColor = System.Drawing.Color.Black;
            this.lblBorrow.Location = new System.Drawing.Point(27, 97);
            this.lblBorrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(136, 21);
            this.lblBorrow.TabIndex = 1;
            this.lblBorrow.Text = "在借人数汇总：";
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdue.ForeColor = System.Drawing.Color.Black;
            this.lblOverdue.Location = new System.Drawing.Point(63, 136);
            this.lblOverdue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(100, 21);
            this.lblOverdue.TabIndex = 2;
            this.lblOverdue.Text = "逾期人数：";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Black;
            this.lblCount.Location = new System.Drawing.Point(45, 19);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(118, 21);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "借阅总人数：";
            // 
            // lblCountSum
            // 
            this.lblCountSum.AutoSize = true;
            this.lblCountSum.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSum.ForeColor = System.Drawing.Color.Black;
            this.lblCountSum.Location = new System.Drawing.Point(193, 19);
            this.lblCountSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountSum.Name = "lblCountSum";
            this.lblCountSum.Size = new System.Drawing.Size(17, 21);
            this.lblCountSum.TabIndex = 5;
            this.lblCountSum.Text = "1";
            // 
            // lblSumBooks
            // 
            this.lblSumBooks.AutoSize = true;
            this.lblSumBooks.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumBooks.ForeColor = System.Drawing.Color.Black;
            this.lblSumBooks.Location = new System.Drawing.Point(193, 58);
            this.lblSumBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumBooks.Name = "lblSumBooks";
            this.lblSumBooks.Size = new System.Drawing.Size(24, 21);
            this.lblSumBooks.TabIndex = 6;
            this.lblSumBooks.Text = "8";
            // 
            // lblSumShu
            // 
            this.lblSumShu.AutoSize = true;
            this.lblSumShu.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumShu.ForeColor = System.Drawing.Color.Black;
            this.lblSumShu.Location = new System.Drawing.Point(193, 97);
            this.lblSumShu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumShu.Name = "lblSumShu";
            this.lblSumShu.Size = new System.Drawing.Size(17, 21);
            this.lblSumShu.TabIndex = 7;
            this.lblSumShu.Text = "1";
            // 
            // lblShu
            // 
            this.lblShu.AutoSize = true;
            this.lblShu.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShu.ForeColor = System.Drawing.Color.Black;
            this.lblShu.Location = new System.Drawing.Point(193, 136);
            this.lblShu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShu.Name = "lblShu";
            this.lblShu.Size = new System.Drawing.Size(23, 21);
            this.lblShu.TabIndex = 8;
            this.lblShu.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 204);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblBorrow);
            this.panel1.Controls.Add(this.lblBooks);
            this.panel1.Controls.Add(this.lblShu);
            this.panel1.Controls.Add(this.lblOverdue);
            this.panel1.Controls.Add(this.lblSumShu);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.lblSumBooks);
            this.panel1.Controls.Add(this.lblCountSum);
            this.panel1.Font = new System.Drawing.Font("ZCOOL KuaiLe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(243, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 174);
            this.panel1.TabIndex = 10;
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // btnBorOut
            // 
            this.btnBorOut.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorOut.Location = new System.Drawing.Point(434, 275);
            this.btnBorOut.Name = "btnBorOut";
            this.btnBorOut.Size = new System.Drawing.Size(76, 32);
            this.btnBorOut.TabIndex = 11;
            this.btnBorOut.Text = "退 出";
            this.btnBorOut.UseVisualStyleBackColor = true;
            this.btnBorOut.Click += new System.EventHandler(this.btnBorOut_Click);
            // 
            // FrmBorrowStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(552, 351);
            this.ControlBox = false;
            this.Controls.Add(this.btnBorOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(552, 351);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(552, 351);
            this.Name = "FrmBorrowStatistics";
            this.Padding = new System.Windows.Forms.Padding(27, 75, 27, 25);
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmBorrowStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCountSum;
        private System.Windows.Forms.Label lblSumBooks;
        private System.Windows.Forms.Label lblSumShu;
        private System.Windows.Forms.Label lblShu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnBorOut;
    }
}