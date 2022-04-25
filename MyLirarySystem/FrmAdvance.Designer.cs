namespace MyLirarySystem
{
    partial class FrmAdvance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdvance));
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblReaderID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblydrq = new System.Windows.Forms.Label();
            this.txtydrq = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.btnYJ = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBookID
            // 
            this.txtBookID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBookID.Location = new System.Drawing.Point(157, 209);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(284, 25);
            this.txtBookID.TabIndex = 17;
            // 
            // txtReaderID
            // 
            this.txtReaderID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReaderID.Location = new System.Drawing.Point(157, 21);
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
            this.lblPwd.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPwd.Location = new System.Drawing.Point(33, 209);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(98, 18);
            this.lblPwd.TabIndex = 11;
            this.lblPwd.Text = "图书编号：";
            // 
            // lblReaderName
            // 
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.BackColor = System.Drawing.Color.Transparent;
            this.lblReaderName.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReaderName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReaderName.Location = new System.Drawing.Point(36, 84);
            this.lblReaderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(98, 18);
            this.lblReaderName.TabIndex = 13;
            this.lblReaderName.Text = "读者姓名：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBookName.Location = new System.Drawing.Point(35, 146);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(98, 18);
            this.lblBookName.TabIndex = 16;
            this.lblBookName.Text = "图书名称：";
            // 
            // lblReaderID
            // 
            this.lblReaderID.AutoSize = true;
            this.lblReaderID.BackColor = System.Drawing.Color.Transparent;
            this.lblReaderID.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReaderID.ForeColor = System.Drawing.Color.Black;
            this.lblReaderID.Location = new System.Drawing.Point(36, 21);
            this.lblReaderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReaderID.Name = "lblReaderID";
            this.lblReaderID.Size = new System.Drawing.Size(98, 18);
            this.lblReaderID.TabIndex = 10;
            this.lblReaderID.Text = "读者卡号：";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblydrq);
            this.panel2.Controls.Add(this.txtydrq);
            this.panel2.Controls.Add(this.txtBookID);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.txtReaderID);
            this.panel2.Controls.Add(this.lblPwd);
            this.panel2.Controls.Add(this.txtReaderName);
            this.panel2.Controls.Add(this.lblReaderName);
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Controls.Add(this.lblReaderID);
            this.panel2.Location = new System.Drawing.Point(68, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 310);
            this.panel2.TabIndex = 19;
            // 
            // lblydrq
            // 
            this.lblydrq.AutoSize = true;
            this.lblydrq.BackColor = System.Drawing.Color.Transparent;
            this.lblydrq.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblydrq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblydrq.Location = new System.Drawing.Point(36, 271);
            this.lblydrq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblydrq.Name = "lblydrq";
            this.lblydrq.Size = new System.Drawing.Size(98, 18);
            this.lblydrq.TabIndex = 24;
            this.lblydrq.Text = "预定日期：";
            // 
            // txtydrq
            // 
            this.txtydrq.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtydrq.Location = new System.Drawing.Point(157, 271);
            this.txtydrq.Margin = new System.Windows.Forms.Padding(4);
            this.txtydrq.Name = "txtydrq";
            this.txtydrq.ReadOnly = true;
            this.txtydrq.Size = new System.Drawing.Size(284, 25);
            this.txtydrq.TabIndex = 23;
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBookName.Location = new System.Drawing.Point(157, 146);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(284, 25);
            this.txtBookName.TabIndex = 22;
            // 
            // txtReaderName
            // 
            this.txtReaderName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReaderName.Location = new System.Drawing.Point(157, 84);
            this.txtReaderName.Margin = new System.Windows.Forms.Padding(4);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.ReadOnly = true;
            this.txtReaderName.Size = new System.Drawing.Size(284, 25);
            this.txtReaderName.TabIndex = 21;
            // 
            // btnYJ
            // 
            this.btnYJ.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYJ.Location = new System.Drawing.Point(172, 414);
            this.btnYJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYJ.Name = "btnYJ";
            this.btnYJ.Size = new System.Drawing.Size(105, 32);
            this.btnYJ.TabIndex = 21;
            this.btnYJ.Text = "预  借";
            this.btnYJ.UseVisualStyleBackColor = true;
            this.btnYJ.Click += new System.EventHandler(this.btnyj_Click);
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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(324, 414);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 32);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 495);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYJ);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(581, 495);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(581, 495);
            this.Name = "FrmAdvance";
            this.ShowInTaskbar = false;
            this.Text = "预借";
            this.Load += new System.EventHandler(this.FrmAdvance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblReaderID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Button btnYJ;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label lblydrq;
        private System.Windows.Forms.TextBox txtydrq;
        private System.Windows.Forms.Button btnCancel;
    }
}