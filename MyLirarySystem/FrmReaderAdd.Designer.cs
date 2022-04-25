namespace MyLirarySystem
{
    partial class FrmReaderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReaderAdd));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.plBookInfo = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.plBookBase = new System.Windows.Forms.Panel();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblReaderID = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.plBookInfo.SuspendLayout();
            this.plBookBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImage.BackgroundImage")));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(28, 23);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(552, 69);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(480, 564);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(371, 564);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "添  加";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // plBookInfo
            // 
            this.plBookInfo.Controls.Add(this.txtPhone);
            this.plBookInfo.Controls.Add(this.txtAddress);
            this.plBookInfo.Controls.Add(this.txtIDCard);
            this.plBookInfo.Controls.Add(this.lblAddress);
            this.plBookInfo.Controls.Add(this.lblIDCard);
            this.plBookInfo.Controls.Add(this.lblPhone);
            this.plBookInfo.Location = new System.Drawing.Point(28, 352);
            this.plBookInfo.Margin = new System.Windows.Forms.Padding(4);
            this.plBookInfo.Name = "plBookInfo";
            this.plBookInfo.Size = new System.Drawing.Size(551, 205);
            this.plBookInfo.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.Location = new System.Drawing.Point(191, 152);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(243, 30);
            this.txtPhone.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(191, 88);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(243, 30);
            this.txtAddress.TabIndex = 11;
            // 
            // txtIDCard
            // 
            this.txtIDCard.BackColor = System.Drawing.Color.White;
            this.txtIDCard.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIDCard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIDCard.Location = new System.Drawing.Point(191, 24);
            this.txtIDCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCard.MaxLength = 18;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(243, 30);
            this.txtIDCard.TabIndex = 7;
            this.txtIDCard.Click += new System.EventHandler(this.txtIDCard_Click);
            this.txtIDCard.TextChanged += new System.EventHandler(this.txtIDCard_TextChanged);
            this.txtIDCard.Leave += new System.EventHandler(this.txtIDCard_Leave);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddress.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress.Location = new System.Drawing.Point(96, 93);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 15);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "住  址：";
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.BackColor = System.Drawing.Color.Transparent;
            this.lblIDCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIDCard.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIDCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIDCard.Location = new System.Drawing.Point(96, 29);
            this.lblIDCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(82, 15);
            this.lblIDCard.TabIndex = 3;
            this.lblIDCard.Text = "身份证号：";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhone.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhone.Location = new System.Drawing.Point(96, 157);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(82, 15);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "联系电话：";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewPwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewPwd.Location = new System.Drawing.Point(99, 182);
            this.lblNewPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(82, 15);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "确认密码：";
            // 
            // plBookBase
            // 
            this.plBookBase.Controls.Add(this.txtNewPwd);
            this.plBookBase.Controls.Add(this.txtReaderName);
            this.plBookBase.Controls.Add(this.txtPwd);
            this.plBookBase.Controls.Add(this.txtReaderID);
            this.plBookBase.Controls.Add(this.lblPwd);
            this.plBookBase.Controls.Add(this.lblNewPwd);
            this.plBookBase.Controls.Add(this.lblBookName);
            this.plBookBase.Controls.Add(this.lblReaderID);
            this.plBookBase.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plBookBase.Location = new System.Drawing.Point(28, 100);
            this.plBookBase.Margin = new System.Windows.Forms.Padding(4);
            this.plBookBase.Name = "plBookBase";
            this.plBookBase.Size = new System.Drawing.Size(551, 221);
            this.plBookBase.TabIndex = 5;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.BackColor = System.Drawing.Color.White;
            this.txtNewPwd.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPwd.Location = new System.Drawing.Point(191, 178);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(243, 30);
            this.txtNewPwd.TabIndex = 12;
            // 
            // txtReaderName
            // 
            this.txtReaderName.BackColor = System.Drawing.Color.White;
            this.txtReaderName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReaderName.Location = new System.Drawing.Point(191, 70);
            this.txtReaderName.Margin = new System.Windows.Forms.Padding(4);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(243, 30);
            this.txtReaderName.TabIndex = 10;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(191, 124);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(243, 30);
            this.txtPwd.TabIndex = 6;
            // 
            // txtReaderID
            // 
            this.txtReaderID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReaderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReaderID.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReaderID.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtReaderID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtReaderID.Location = new System.Drawing.Point(191, 16);
            this.txtReaderID.Margin = new System.Windows.Forms.Padding(4);
            this.txtReaderID.Name = "txtReaderID";
            this.txtReaderID.ReadOnly = true;
            this.txtReaderID.Size = new System.Drawing.Size(243, 30);
            this.txtReaderID.TabIndex = 5;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPwd.Location = new System.Drawing.Point(99, 129);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(82, 15);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "登录密码：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBookName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBookName.Location = new System.Drawing.Point(99, 75);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(82, 15);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "读者姓名：";
            // 
            // lblReaderID
            // 
            this.lblReaderID.AutoSize = true;
            this.lblReaderID.BackColor = System.Drawing.Color.Transparent;
            this.lblReaderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReaderID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReaderID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReaderID.Location = new System.Drawing.Point(99, 21);
            this.lblReaderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReaderID.Name = "lblReaderID";
            this.lblReaderID.Size = new System.Drawing.Size(82, 15);
            this.lblReaderID.TabIndex = 0;
            this.lblReaderID.Text = "读者卡号：";
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
            // FrmReaderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 609);
            this.ControlBox = false;
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.plBookInfo);
            this.Controls.Add(this.plBookBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(609, 609);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(609, 609);
            this.Name = "FrmReaderAdd";
            this.Padding = new System.Windows.Forms.Padding(27, 75, 27, 25);
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmReaderAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.plBookInfo.ResumeLayout(false);
            this.plBookInfo.PerformLayout();
            this.plBookBase.ResumeLayout(false);
            this.plBookBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel plBookInfo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Panel plBookBase;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.Label lblReaderID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNewPwd;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}