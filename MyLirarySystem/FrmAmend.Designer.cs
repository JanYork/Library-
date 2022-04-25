namespace MyLirarySystem
{
    partial class FrmAmend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAmend));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtXingPwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblPwd1 = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnRutern = new System.Windows.Forms.Button();
            this.btnAmend = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtXingPwd);
            this.panel2.Controls.Add(this.txtPwd);
            this.panel2.Controls.Add(this.txtAccount);
            this.panel2.Controls.Add(this.lblPwd1);
            this.panel2.Controls.Add(this.lblPwd);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Location = new System.Drawing.Point(31, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 231);
            this.panel2.TabIndex = 8;
            // 
            // txtXingPwd
            // 
            this.txtXingPwd.Location = new System.Drawing.Point(151, 160);
            this.txtXingPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXingPwd.Name = "txtXingPwd";
            this.txtXingPwd.PasswordChar = '*';
            this.txtXingPwd.Size = new System.Drawing.Size(248, 25);
            this.txtXingPwd.TabIndex = 12;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(151, 99);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(248, 25);
            this.txtPwd.TabIndex = 11;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(151, 38);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(248, 25);
            this.txtAccount.TabIndex = 10;
            // 
            // lblPwd1
            // 
            this.lblPwd1.AutoSize = true;
            this.lblPwd1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd1.Location = new System.Drawing.Point(65, 163);
            this.lblPwd1.Name = "lblPwd1";
            this.lblPwd1.Size = new System.Drawing.Size(80, 18);
            this.lblPwd1.TabIndex = 9;
            this.lblPwd1.Text = "新密码：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(74, 102);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(71, 18);
            this.lblPwd.TabIndex = 8;
            this.lblPwd.Text = "密 码：";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccount.Location = new System.Drawing.Point(74, 41);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(71, 18);
            this.lblAccount.TabIndex = 7;
            this.lblAccount.Text = "账 户：";
            // 
            // btnRutern
            // 
            this.btnRutern.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutern.Location = new System.Drawing.Point(365, 344);
            this.btnRutern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRutern.Name = "btnRutern";
            this.btnRutern.Size = new System.Drawing.Size(105, 34);
            this.btnRutern.TabIndex = 10;
            this.btnRutern.Text = "返 回";
            this.btnRutern.UseVisualStyleBackColor = true;
            this.btnRutern.Click += new System.EventHandler(this.btoRutern_Click);
            // 
            // btnAmend
            // 
            this.btnAmend.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmend.Location = new System.Drawing.Point(233, 344);
            this.btnAmend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAmend.Name = "btnAmend";
            this.btnAmend.Size = new System.Drawing.Size(105, 34);
            this.btnAmend.TabIndex = 9;
            this.btnAmend.Text = "修 改";
            this.btnAmend.UseVisualStyleBackColor = true;
            this.btnAmend.Click += new System.EventHandler(this.btoAmend_Click);
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
            // FrmAmend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(527, 435);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRutern);
            this.Controls.Add(this.btnAmend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 435);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 435);
            this.Name = "FrmAmend";
            this.Padding = new System.Windows.Forms.Padding(27, 75, 27, 25);
            this.ShowInTaskbar = false;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmAmend_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtXingPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblPwd1;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnRutern;
        private System.Windows.Forms.Button btnAmend;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}