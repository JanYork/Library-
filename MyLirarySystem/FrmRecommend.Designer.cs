namespace MyLirarySystem
{
    partial class FrmRecommend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecommend));
            this.lvCha = new System.Windows.Forms.ListView();
            this.chBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYes = new System.Windows.Forms.Button();
            this.lblbook = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCha
            // 
            this.lvCha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBookName,
            this.chAuthor,
            this.chPress,
            this.chBookType});
            this.lvCha.Font = new System.Drawing.Font("ZCOOL KuaiLe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCha.FullRowSelect = true;
            this.lvCha.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCha.HideSelection = false;
            this.lvCha.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lvCha.Location = new System.Drawing.Point(5, 104);
            this.lvCha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvCha.MultiSelect = false;
            this.lvCha.Name = "lvCha";
            this.lvCha.Scrollable = false;
            this.lvCha.Size = new System.Drawing.Size(843, 163);
            this.lvCha.TabIndex = 8;
            this.lvCha.UseCompatibleStateImageBehavior = false;
            this.lvCha.View = System.Windows.Forms.View.Details;
            // 
            // chBookName
            // 
            this.chBookName.Text = "书本名称";
            this.chBookName.Width = 160;
            // 
            // chAuthor
            // 
            this.chAuthor.Text = "作者";
            this.chAuthor.Width = 145;
            // 
            // chPress
            // 
            this.chPress.Text = "出版社";
            this.chPress.Width = 163;
            // 
            // chBookType
            // 
            this.chBookType.Text = "小类别";
            this.chBookType.Width = 144;
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(735, 284);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(101, 30);
            this.btnYes.TabIndex = 10;
            this.btnYes.Text = "确 定";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblbook
            // 
            this.lblbook.AutoSize = true;
            this.lblbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbook.Font = new System.Drawing.Font("ZCOOL KuaiLe", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbook.Location = new System.Drawing.Point(301, 28);
            this.lblbook.Name = "lblbook";
            this.lblbook.Size = new System.Drawing.Size(278, 43);
            this.lblbook.TabIndex = 9;
            this.lblbook.Text = "图书推荐前五本";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 90);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            // FrmRecommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 323);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvCha);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblbook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(859, 323);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(859, 323);
            this.Name = "FrmRecommend";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmRecommend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader chBookName;
        private System.Windows.Forms.ColumnHeader chAuthor;
        private System.Windows.Forms.ColumnHeader chPress;
        private System.Windows.Forms.ColumnHeader chBookType;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblbook;
        private System.Windows.Forms.ListView lvCha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}