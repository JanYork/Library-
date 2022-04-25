namespace MyLirarySystem
{
    partial class FrmOffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOffer));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBookType = new System.Windows.Forms.TextBox();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookType = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(172, 371);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(284, 25);
            this.txtPrice.TabIndex = 19;
            // 
            // txtBookType
            // 
            this.txtBookType.Location = new System.Drawing.Point(172, 305);
            this.txtBookType.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.ReadOnly = true;
            this.txtBookType.Size = new System.Drawing.Size(284, 25);
            this.txtBookType.TabIndex = 23;
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(172, 239);
            this.txtPress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPress.Name = "txtPress";
            this.txtPress.ReadOnly = true;
            this.txtPress.Size = new System.Drawing.Size(284, 25);
            this.txtPress.TabIndex = 17;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(172, 174);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(284, 25);
            this.txtAuthor.TabIndex = 22;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(172, 41);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(284, 25);
            this.txtBookID.TabIndex = 15;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPwd.Location = new System.Drawing.Point(44, 44);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(98, 18);
            this.lblPwd.TabIndex = 11;
            this.lblPwd.Text = "图书编号：";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(172, 108);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(284, 25);
            this.txtBookName.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtBookType);
            this.panel2.Controls.Add(this.txtPress);
            this.panel2.Controls.Add(this.txtAuthor);
            this.panel2.Controls.Add(this.txtBookID);
            this.panel2.Controls.Add(this.lblPwd);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.lblPress);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Controls.Add(this.lblBookType);
            this.panel2.Controls.Add(this.lblAuthor);
            this.panel2.Location = new System.Drawing.Point(24, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 418);
            this.panel2.TabIndex = 25;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.BackColor = System.Drawing.Color.Transparent;
            this.lblPress.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPress.Location = new System.Drawing.Point(44, 242);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(98, 18);
            this.lblPress.TabIndex = 13;
            this.lblPress.Text = "图书版社：";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrice.Location = new System.Drawing.Point(44, 374);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 18);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "图书价格：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBookName.Location = new System.Drawing.Point(44, 111);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(98, 18);
            this.lblBookName.TabIndex = 16;
            this.lblBookName.Text = "图书名称：";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.BackColor = System.Drawing.Color.Transparent;
            this.lblBookType.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBookType.Location = new System.Drawing.Point(44, 308);
            this.lblBookType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(98, 18);
            this.lblBookType.TabIndex = 18;
            this.lblBookType.Text = "图书类别：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAuthor.Location = new System.Drawing.Point(44, 177);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(98, 18);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "图书作者：";
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(439, 559);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(87, 29);
            this.btnYes.TabIndex = 27;
            this.btnYes.Text = "确 定";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(22, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 78);
            this.panel1.TabIndex = 26;
            // 
            // FrmOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 597);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(549, 597);
            this.Name = "FrmOffer";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmOffer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBookType;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Panel panel1;
    }
}