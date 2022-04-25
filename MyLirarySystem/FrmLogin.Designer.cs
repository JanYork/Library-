namespace MyLirarySystem
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.plLogin = new System.Windows.Forms.Panel();
            this.btnMailVeriCode = new System.Windows.Forms.Button();
            this.txtMailVeriCode = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblzhuce = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.plType = new System.Windows.Forms.Panel();
            this.rbReader = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.pbManager = new System.Windows.Forms.PictureBox();
            this.pbReader = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbPwd = new System.Windows.Forms.PictureBox();
            this.ttManager = new System.Windows.Forms.ToolTip(this.components);
            this.ttReader = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PicBoxForQQ = new System.Windows.Forms.PictureBox();
            this.plLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxForQQ)).BeginInit();
            this.SuspendLayout();
            // 
            // plLogin
            // 
            this.plLogin.BackColor = System.Drawing.Color.Transparent;
            this.plLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plLogin.BackgroundImage")));
            this.plLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plLogin.Controls.Add(this.PicBoxForQQ);
            this.plLogin.Controls.Add(this.btnMailVeriCode);
            this.plLogin.Controls.Add(this.txtMailVeriCode);
            this.plLogin.Controls.Add(this.pictureBox3);
            this.plLogin.Controls.Add(this.lblzhuce);
            this.plLogin.Controls.Add(this.pictureBox2);
            this.plLogin.Controls.Add(this.pictureBox1);
            this.plLogin.Controls.Add(this.txtPwd);
            this.plLogin.Controls.Add(this.btnCancel);
            this.plLogin.Controls.Add(this.btnLogin);
            this.plLogin.Controls.Add(this.txtLoginID);
            this.plLogin.Controls.Add(this.plType);
            this.plLogin.Controls.Add(this.pbUser);
            this.plLogin.Controls.Add(this.pbPwd);
            this.plLogin.Location = new System.Drawing.Point(-1, 0);
            this.plLogin.Margin = new System.Windows.Forms.Padding(4);
            this.plLogin.Name = "plLogin";
            this.plLogin.Size = new System.Drawing.Size(656, 426);
            this.plLogin.TabIndex = 1;
            this.plLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.plLogin_Paint);
            // 
            // btnMailVeriCode
            // 
            this.btnMailVeriCode.BackColor = System.Drawing.SystemColors.Window;
            this.btnMailVeriCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMailVeriCode.BackgroundImage")));
            this.btnMailVeriCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMailVeriCode.FlatAppearance.BorderSize = 0;
            this.btnMailVeriCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMailVeriCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMailVeriCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMailVeriCode.Location = new System.Drawing.Point(571, 161);
            this.btnMailVeriCode.Name = "btnMailVeriCode";
            this.btnMailVeriCode.Size = new System.Drawing.Size(39, 30);
            this.btnMailVeriCode.TabIndex = 17;
            this.btnMailVeriCode.UseVisualStyleBackColor = false;
            this.btnMailVeriCode.Click += new System.EventHandler(this.btnMailVeriCode_Click_1);
            // 
            // txtMailVeriCode
            // 
            this.txtMailVeriCode.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMailVeriCode.Location = new System.Drawing.Point(343, 161);
            this.txtMailVeriCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailVeriCode.Multiline = true;
            this.txtMailVeriCode.Name = "txtMailVeriCode";
            this.txtMailVeriCode.Size = new System.Drawing.Size(267, 30);
            this.txtMailVeriCode.TabIndex = 16;
            this.txtMailVeriCode.Click += new System.EventHandler(this.txtMailVeriCode_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(290, 157);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 39);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // lblzhuce
            // 
            this.lblzhuce.AutoSize = true;
            this.lblzhuce.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzhuce.ForeColor = System.Drawing.Color.Orange;
            this.lblzhuce.Location = new System.Drawing.Point(523, 301);
            this.lblzhuce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblzhuce.Name = "lblzhuce";
            this.lblzhuce.Size = new System.Drawing.Size(82, 21);
            this.lblzhuce.TabIndex = 14;
            this.lblzhuce.Text = "快速注册";
            this.lblzhuce.Click += new System.EventHandler(this.lblzhuce_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 306);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 116);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(493, 300);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPwd.Location = new System.Drawing.Point(343, 96);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(267, 30);
            this.txtPwd.TabIndex = 10;
            this.txtPwd.Click += new System.EventHandler(this.txtPwd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(509, 338);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(301, 338);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 29);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "登  录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginID
            // 
            this.txtLoginID.Font = new System.Drawing.Font("宋体", 12F);
            this.txtLoginID.Location = new System.Drawing.Point(343, 31);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginID.Multiline = true;
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(267, 30);
            this.txtLoginID.TabIndex = 6;
            this.txtLoginID.Click += new System.EventHandler(this.txtLoginID_Click);
            this.txtLoginID.TextChanged += new System.EventHandler(this.txtLoginID_TextChanged);
            // 
            // plType
            // 
            this.plType.Controls.Add(this.rbReader);
            this.plType.Controls.Add(this.rbManager);
            this.plType.Controls.Add(this.pbManager);
            this.plType.Controls.Add(this.pbReader);
            this.plType.Location = new System.Drawing.Point(343, 221);
            this.plType.Margin = new System.Windows.Forms.Padding(4);
            this.plType.Name = "plType";
            this.plType.Size = new System.Drawing.Size(267, 70);
            this.plType.TabIndex = 5;
            // 
            // rbReader
            // 
            this.rbReader.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbReader.Checked = true;
            this.rbReader.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.rbReader.FlatAppearance.BorderSize = 2;
            this.rbReader.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.rbReader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.rbReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.rbReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbReader.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbReader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rbReader.Location = new System.Drawing.Point(186, 29);
            this.rbReader.Margin = new System.Windows.Forms.Padding(4);
            this.rbReader.Name = "rbReader";
            this.rbReader.Size = new System.Drawing.Size(21, 21);
            this.rbReader.TabIndex = 11;
            this.rbReader.TabStop = true;
            this.rbReader.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            this.rbManager.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbManager.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.rbManager.FlatAppearance.BorderSize = 2;
            this.rbManager.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.rbManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.rbManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.rbManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbManager.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbManager.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rbManager.Location = new System.Drawing.Point(83, 29);
            this.rbManager.Margin = new System.Windows.Forms.Padding(4);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(21, 21);
            this.rbManager.TabIndex = 10;
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // pbManager
            // 
            this.pbManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbManager.BackgroundImage")));
            this.pbManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbManager.Location = new System.Drawing.Point(36, 18);
            this.pbManager.Margin = new System.Windows.Forms.Padding(4);
            this.pbManager.Name = "pbManager";
            this.pbManager.Size = new System.Drawing.Size(39, 42);
            this.pbManager.TabIndex = 4;
            this.pbManager.TabStop = false;
            this.ttManager.SetToolTip(this.pbManager, "管理员");
            this.pbManager.Click += new System.EventHandler(this.pbManager_Click);
            // 
            // pbReader
            // 
            this.pbReader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbReader.BackgroundImage")));
            this.pbReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbReader.Location = new System.Drawing.Point(139, 18);
            this.pbReader.Margin = new System.Windows.Forms.Padding(4);
            this.pbReader.Name = "pbReader";
            this.pbReader.Size = new System.Drawing.Size(39, 42);
            this.pbReader.TabIndex = 3;
            this.pbReader.TabStop = false;
            this.ttReader.SetToolTip(this.pbReader, "读者");
            this.pbReader.Click += new System.EventHandler(this.pbReader_Click);
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUser.BackgroundImage")));
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUser.Location = new System.Drawing.Point(290, 27);
            this.pbUser.Margin = new System.Windows.Forms.Padding(4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(39, 39);
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            // 
            // pbPwd
            // 
            this.pbPwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPwd.BackgroundImage")));
            this.pbPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPwd.Location = new System.Drawing.Point(291, 92);
            this.pbPwd.Margin = new System.Windows.Forms.Padding(4);
            this.pbPwd.Name = "pbPwd";
            this.pbPwd.Size = new System.Drawing.Size(39, 39);
            this.pbPwd.TabIndex = 1;
            this.pbPwd.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PicBoxForQQ
            // 
            this.PicBoxForQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxForQQ.Location = new System.Drawing.Point(104, 136);
            this.PicBoxForQQ.Margin = new System.Windows.Forms.Padding(4);
            this.PicBoxForQQ.Name = "PicBoxForQQ";
            this.PicBoxForQQ.Size = new System.Drawing.Size(128, 116);
            this.PicBoxForQQ.TabIndex = 18;
            this.PicBoxForQQ.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(655, 426);
            this.Controls.Add(this.plLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "MyLibrary-登录";
            this.plLogin.ResumeLayout(false);
            this.plLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxForQQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plLogin;
        private System.Windows.Forms.PictureBox pbManager;
        private System.Windows.Forms.PictureBox pbReader;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPwd;
        private System.Windows.Forms.Panel plType;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rbReader;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ttManager;
        private System.Windows.Forms.ToolTip ttReader;
        private System.Windows.Forms.Label lblzhuce;
        private System.Windows.Forms.TextBox txtMailVeriCode;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnMailVeriCode;
        private System.Windows.Forms.PictureBox PicBoxForQQ;
    }
}