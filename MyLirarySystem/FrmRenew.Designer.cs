﻿namespace MyLirarySystem
{
    partial class FrmRenew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenew));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.txtBorrowDate = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtRenewDate = new System.Windows.Forms.TextBox();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.lblReaderID = new System.Windows.Forms.Label();
            this.lblRenew = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(455, 546);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Location = new System.Drawing.Point(328, 546);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(100, 29);
            this.btnRenew.TabIndex = 12;
            this.btnRenew.Text = "续  借";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(47, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 62);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtReturnDate);
            this.panel2.Controls.Add(this.txtBorrowDate);
            this.panel2.Controls.Add(this.txtBookID);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.txtReaderID);
            this.panel2.Controls.Add(this.lblPwd);
            this.panel2.Controls.Add(this.txtReaderName);
            this.panel2.Controls.Add(this.lblReaderName);
            this.panel2.Controls.Add(this.lblReturnDate);
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Controls.Add(this.txtRenewDate);
            this.panel2.Controls.Add(this.lblBorrow);
            this.panel2.Controls.Add(this.lblReaderID);
            this.panel2.Controls.Add(this.lblRenew);
            this.panel2.Location = new System.Drawing.Point(47, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 431);
            this.panel2.TabIndex = 14;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Location = new System.Drawing.Point(152, 302);
            this.txtReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.ReadOnly = true;
            this.txtReturnDate.Size = new System.Drawing.Size(284, 25);
            this.txtReturnDate.TabIndex = 19;
            // 
            // txtBorrowDate
            // 
            this.txtBorrowDate.Location = new System.Drawing.Point(152, 249);
            this.txtBorrowDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrowDate.Name = "txtBorrowDate";
            this.txtBorrowDate.ReadOnly = true;
            this.txtBorrowDate.Size = new System.Drawing.Size(284, 25);
            this.txtBorrowDate.TabIndex = 23;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(152, 195);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(284, 25);
            this.txtBookID.TabIndex = 17;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(152, 141);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(284, 25);
            this.txtBookName.TabIndex = 22;
            // 
            // txtReaderID
            // 
            this.txtReaderID.Location = new System.Drawing.Point(152, 34);
            this.txtReaderID.Margin = new System.Windows.Forms.Padding(4);
            this.txtReaderID.Name = "txtReaderID";
            this.txtReaderID.ReadOnly = true;
            this.txtReaderID.Size = new System.Drawing.Size(284, 25);
            this.txtReaderID.TabIndex = 15;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPwd.Location = new System.Drawing.Point(59, 200);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(82, 15);
            this.lblPwd.TabIndex = 11;
            this.lblPwd.Text = "图书编号：";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(152, 88);
            this.txtReaderName.Margin = new System.Windows.Forms.Padding(4);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.ReadOnly = true;
            this.txtReaderName.Size = new System.Drawing.Size(284, 25);
            this.txtReaderName.TabIndex = 21;
            // 
            // lblReaderName
            // 
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.BackColor = System.Drawing.Color.Transparent;
            this.lblReaderName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReaderName.Location = new System.Drawing.Point(59, 92);
            this.lblReaderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(82, 15);
            this.lblReaderName.TabIndex = 13;
            this.lblReaderName.Text = "读者姓名：";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnDate.Location = new System.Drawing.Point(59, 308);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(82, 15);
            this.lblReturnDate.TabIndex = 12;
            this.lblReturnDate.Text = "应还日期：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBookName.Location = new System.Drawing.Point(59, 146);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(82, 15);
            this.lblBookName.TabIndex = 16;
            this.lblBookName.Text = "图书名称：";
            // 
            // txtRenewDate
            // 
            this.txtRenewDate.Location = new System.Drawing.Point(152, 356);
            this.txtRenewDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRenewDate.Name = "txtRenewDate";
            this.txtRenewDate.ReadOnly = true;
            this.txtRenewDate.Size = new System.Drawing.Size(284, 25);
            this.txtRenewDate.TabIndex = 14;
            // 
            // lblBorrow
            // 
            this.lblBorrow.AutoSize = true;
            this.lblBorrow.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBorrow.Location = new System.Drawing.Point(59, 254);
            this.lblBorrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(82, 15);
            this.lblBorrow.TabIndex = 18;
            this.lblBorrow.Text = "借阅日期：";
            // 
            // lblReaderID
            // 
            this.lblReaderID.AutoSize = true;
            this.lblReaderID.BackColor = System.Drawing.Color.Transparent;
            this.lblReaderID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReaderID.Location = new System.Drawing.Point(59, 39);
            this.lblReaderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReaderID.Name = "lblReaderID";
            this.lblReaderID.Size = new System.Drawing.Size(82, 15);
            this.lblReaderID.TabIndex = 10;
            this.lblReaderID.Text = "读者卡号：";
            // 
            // lblRenew
            // 
            this.lblRenew.AutoSize = true;
            this.lblRenew.BackColor = System.Drawing.Color.Transparent;
            this.lblRenew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRenew.Location = new System.Drawing.Point(59, 361);
            this.lblRenew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRenew.Name = "lblRenew";
            this.lblRenew.Size = new System.Drawing.Size(82, 15);
            this.lblRenew.TabIndex = 20;
            this.lblRenew.Text = "续借日期：";
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
            // FrmRenew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 610);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(611, 610);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(611, 610);
            this.Name = "FrmRenew";
            this.Padding = new System.Windows.Forms.Padding(27, 75, 27, 25);
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmRenew_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.TextBox txtBorrowDate;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtRenewDate;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Label lblReaderID;
        private System.Windows.Forms.Label lblRenew;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}