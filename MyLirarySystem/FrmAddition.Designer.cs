namespace MyLirarySystem
{
    partial class FrmAddition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddition));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPwd2 = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtYesPwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtManagerID);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.lblPwd2);
            this.panel3.Controls.Add(this.lblPwd);
            this.panel3.Controls.Add(this.txtYesPwd);
            this.panel3.Controls.Add(this.txtPwd);
            this.panel3.Location = new System.Drawing.Point(35, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 209);
            this.panel3.TabIndex = 5;
            // 
            // txtManagerID
            // 
            this.txtManagerID.ForeColor = System.Drawing.Color.Red;
            this.txtManagerID.Location = new System.Drawing.Point(137, 31);
            this.txtManagerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.ReadOnly = true;
            this.txtManagerID.Size = new System.Drawing.Size(271, 25);
            this.txtManagerID.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(9, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(111, 19);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "管理员账号：";
            // 
            // lblPwd2
            // 
            this.lblPwd2.AutoSize = true;
            this.lblPwd2.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd2.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd2.Location = new System.Drawing.Point(21, 161);
            this.lblPwd2.Name = "lblPwd2";
            this.lblPwd2.Size = new System.Drawing.Size(94, 19);
            this.lblPwd2.TabIndex = 3;
            this.lblPwd2.Text = "确认密码：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(41, 98);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(70, 19);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密  码：";
            // 
            // txtYesPwd
            // 
            this.txtYesPwd.Location = new System.Drawing.Point(137, 159);
            this.txtYesPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYesPwd.Name = "txtYesPwd";
            this.txtYesPwd.PasswordChar = '*';
            this.txtYesPwd.Size = new System.Drawing.Size(271, 25);
            this.txtYesPwd.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPwd.Location = new System.Drawing.Point(137, 95);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(271, 23);
            this.txtPwd.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(375, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.butCancel_Click_1);
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.Location = new System.Drawing.Point(225, 317);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(120, 36);
            this.btnAddition.TabIndex = 6;
            this.btnAddition.Text = "添  加";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.butAddition_Click);
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
            // FrmAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(529, 403);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddition);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(529, 403);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(529, 403);
            this.Name = "FrmAddition";
            this.ShowInTaskbar = false;
            this.Text = "添加管理员";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtYesPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.Label lblID;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}