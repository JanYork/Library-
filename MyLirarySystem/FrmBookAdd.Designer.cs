namespace MyLirarySystem
{
    partial class FrmBookAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookAdd));
            this.plBookInfo = new System.Windows.Forms.Panel();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboBookClass = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbNoBorrow = new System.Windows.Forms.PictureBox();
            this.pbBorrow = new System.Windows.Forms.PictureBox();
            this.cboBookType = new System.Windows.Forms.ComboBox();
            this.rbNoBorrow = new System.Windows.Forms.RadioButton();
            this.rbBorrow = new System.Windows.Forms.RadioButton();
            this.lblBookClass = new System.Windows.Forms.Label();
            this.lblBookType = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.plBookBase = new System.Windows.Forms.Panel();
            this.plBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrow)).BeginInit();
            this.plBookBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBookInfo
            // 
            this.plBookInfo.BackColor = System.Drawing.Color.Transparent;
            this.plBookInfo.Controls.Add(this.nudPrice);
            this.plBookInfo.Controls.Add(this.lblPrice);
            this.plBookInfo.Controls.Add(this.cboBookClass);
            this.plBookInfo.Controls.Add(this.panel1);
            this.plBookInfo.Controls.Add(this.lblBookType);
            this.plBookInfo.Location = new System.Drawing.Point(23, 265);
            this.plBookInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plBookInfo.Name = "plBookInfo";
            this.plBookInfo.Size = new System.Drawing.Size(549, 240);
            this.plBookInfo.TabIndex = 0;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(206, 10);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(187, 25);
            this.nudPrice.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(111, 13);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 18);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "价格：";
            // 
            // cboBookClass
            // 
            this.cboBookClass.BackColor = System.Drawing.Color.White;
            this.cboBookClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookClass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBookClass.FormattingEnabled = true;
            this.cboBookClass.Location = new System.Drawing.Point(206, 52);
            this.cboBookClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBookClass.Name = "cboBookClass";
            this.cboBookClass.Size = new System.Drawing.Size(185, 23);
            this.cboBookClass.TabIndex = 8;
            this.cboBookClass.SelectedIndexChanged += new System.EventHandler(this.cboBookClass_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pbNoBorrow);
            this.panel1.Controls.Add(this.pbBorrow);
            this.panel1.Controls.Add(this.cboBookType);
            this.panel1.Controls.Add(this.rbNoBorrow);
            this.panel1.Controls.Add(this.rbBorrow);
            this.panel1.Controls.Add(this.lblBookClass);
            this.panel1.Location = new System.Drawing.Point(59, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 129);
            this.panel1.TabIndex = 7;
            // 
            // pbNoBorrow
            // 
            this.pbNoBorrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbNoBorrow.BackgroundImage")));
            this.pbNoBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbNoBorrow.Location = new System.Drawing.Point(211, 39);
            this.pbNoBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbNoBorrow.Name = "pbNoBorrow";
            this.pbNoBorrow.Size = new System.Drawing.Size(79, 60);
            this.pbNoBorrow.TabIndex = 3;
            this.pbNoBorrow.TabStop = false;
            this.pbNoBorrow.Click += new System.EventHandler(this.pbNoBorrow_Click);
            // 
            // pbBorrow
            // 
            this.pbBorrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBorrow.BackgroundImage")));
            this.pbBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbBorrow.Location = new System.Drawing.Point(35, 39);
            this.pbBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBorrow.Name = "pbBorrow";
            this.pbBorrow.Size = new System.Drawing.Size(79, 60);
            this.pbBorrow.TabIndex = 2;
            this.pbBorrow.TabStop = false;
            this.pbBorrow.Click += new System.EventHandler(this.pbBorrow_Click);
            // 
            // cboBookType
            // 
            this.cboBookType.BackColor = System.Drawing.Color.White;
            this.cboBookType.DropDownHeight = 140;
            this.cboBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBookType.FormattingEnabled = true;
            this.cboBookType.IntegralHeight = false;
            this.cboBookType.Location = new System.Drawing.Point(149, 6);
            this.cboBookType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBookType.Name = "cboBookType";
            this.cboBookType.Size = new System.Drawing.Size(185, 23);
            this.cboBookType.TabIndex = 9;
            // 
            // rbNoBorrow
            // 
            this.rbNoBorrow.AutoSize = true;
            this.rbNoBorrow.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoBorrow.ForeColor = System.Drawing.Color.Black;
            this.rbNoBorrow.Location = new System.Drawing.Point(299, 60);
            this.rbNoBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNoBorrow.Name = "rbNoBorrow";
            this.rbNoBorrow.Size = new System.Drawing.Size(79, 19);
            this.rbNoBorrow.TabIndex = 1;
            this.rbNoBorrow.Text = "不可借";
            this.rbNoBorrow.UseVisualStyleBackColor = true;
            // 
            // rbBorrow
            // 
            this.rbBorrow.AutoSize = true;
            this.rbBorrow.Checked = true;
            this.rbBorrow.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBorrow.ForeColor = System.Drawing.Color.Black;
            this.rbBorrow.Location = new System.Drawing.Point(120, 60);
            this.rbBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBorrow.Name = "rbBorrow";
            this.rbBorrow.Size = new System.Drawing.Size(62, 19);
            this.rbBorrow.TabIndex = 0;
            this.rbBorrow.TabStop = true;
            this.rbBorrow.Text = "可借";
            this.rbBorrow.UseVisualStyleBackColor = true;
            // 
            // lblBookClass
            // 
            this.lblBookClass.AutoSize = true;
            this.lblBookClass.BackColor = System.Drawing.Color.Transparent;
            this.lblBookClass.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBookClass.Location = new System.Drawing.Point(8, 10);
            this.lblBookClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookClass.Name = "lblBookClass";
            this.lblBookClass.Size = new System.Drawing.Size(119, 15);
            this.lblBookClass.TabIndex = 3;
            this.lblBookClass.Text = "图书基本类别：";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.BackColor = System.Drawing.Color.Transparent;
            this.lblBookType.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBookType.Location = new System.Drawing.Point(67, 56);
            this.lblBookType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(119, 15);
            this.lblBookType.TabIndex = 5;
            this.lblBookType.Text = "图书具体类别：";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(348, 544);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "添  加";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(470, 544);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.Transparent;
            this.lblBookID.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBookID.Location = new System.Drawing.Point(79, 22);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(98, 18);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "图书编号：";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.BackColor = System.Drawing.Color.Transparent;
            this.lblPress.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPress.Location = new System.Drawing.Point(79, 148);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(98, 18);
            this.lblPress.TabIndex = 3;
            this.lblPress.Text = "图书版社：";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.BackColor = System.Drawing.Color.Transparent;
            this.lblWords.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWords.Location = new System.Drawing.Point(79, 192);
            this.lblWords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(98, 18);
            this.lblWords.TabIndex = 4;
            this.lblWords.Text = "图书字数：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBookName.Location = new System.Drawing.Point(79, 63);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(98, 18);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "图书名称：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAuthor.Location = new System.Drawing.Point(79, 104);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(98, 18);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "图书作者：";
            // 
            // txtBookID
            // 
            this.txtBookID.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtBookID.Location = new System.Drawing.Point(204, 19);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(243, 25);
            this.txtBookID.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(204, 101);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(243, 25);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(204, 145);
            this.txtPress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(243, 25);
            this.txtPress.TabIndex = 7;
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(204, 189);
            this.txtWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(243, 25);
            this.txtWords.TabIndex = 8;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(204, 60);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(243, 25);
            this.txtBookName.TabIndex = 10;
            // 
            // plBookBase
            // 
            this.plBookBase.BackColor = System.Drawing.Color.Transparent;
            this.plBookBase.Controls.Add(this.txtBookName);
            this.plBookBase.Controls.Add(this.txtWords);
            this.plBookBase.Controls.Add(this.txtPress);
            this.plBookBase.Controls.Add(this.txtAuthor);
            this.plBookBase.Controls.Add(this.txtBookID);
            this.plBookBase.Controls.Add(this.lblAuthor);
            this.plBookBase.Controls.Add(this.lblBookName);
            this.plBookBase.Controls.Add(this.lblWords);
            this.plBookBase.Controls.Add(this.lblPress);
            this.plBookBase.Controls.Add(this.lblBookID);
            this.plBookBase.Location = new System.Drawing.Point(21, 38);
            this.plBookBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plBookBase.Name = "plBookBase";
            this.plBookBase.Size = new System.Drawing.Size(551, 221);
            this.plBookBase.TabIndex = 0;
            // 
            // FrmBookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 609);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.plBookInfo);
            this.Controls.Add(this.plBookBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(609, 609);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(609, 609);
            this.Name = "FrmBookAdd";
            this.Padding = new System.Windows.Forms.Padding(27, 75, 27, 25);
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmBookAdd_Load);
            this.plBookInfo.ResumeLayout(false);
            this.plBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrow)).EndInit();
            this.plBookBase.ResumeLayout(false);
            this.plBookBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBookInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBookClass;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboBookType;
        private System.Windows.Forms.ComboBox cboBookClass;
        private System.Windows.Forms.RadioButton rbNoBorrow;
        private System.Windows.Forms.RadioButton rbBorrow;
        private System.Windows.Forms.PictureBox pbNoBorrow;
        private System.Windows.Forms.PictureBox pbBorrow;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblPrice;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Panel plBookBase;
    }
}