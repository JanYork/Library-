namespace MyLirarySystem
{
    partial class FrmManageReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageReader));
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.ReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsShortMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAll = new System.Windows.Forms.ToolStripMenuItem();
            this.查看借阅信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackMain = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBorrowByReader = new System.Windows.Forms.ToolStripButton();
            this.tsbOverdue = new System.Windows.Forms.ToolStripButton();
            this.tsbAll = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDetele = new System.Windows.Forms.ToolStripButton();
            this.tsbAddReader = new System.Windows.Forms.ToolStripButton();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.ttSearch = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.cmsShortMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToResizeRows = false;
            this.dgvShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReaderID,
            this.ReaderName,
            this.IDCard,
            this.BorrowBook,
            this.ReturnBook,
            this.Phone,
            this.Address});
            this.dgvShow.ContextMenuStrip = this.cmsShortMenu;
            this.dgvShow.Location = new System.Drawing.Point(16, 135);
            this.dgvShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowHeadersWidth = 82;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1065, 456);
            this.dgvShow.TabIndex = 0;
            // 
            // ReaderID
            // 
            this.ReaderID.DataPropertyName = "ReaderID";
            this.ReaderID.HeaderText = "读者卡号";
            this.ReaderID.MinimumWidth = 10;
            this.ReaderID.Name = "ReaderID";
            this.ReaderID.ReadOnly = true;
            // 
            // ReaderName
            // 
            this.ReaderName.DataPropertyName = "ReaderName";
            this.ReaderName.HeaderText = "姓名";
            this.ReaderName.MinimumWidth = 10;
            this.ReaderName.Name = "ReaderName";
            this.ReaderName.ReadOnly = true;
            // 
            // IDCard
            // 
            this.IDCard.DataPropertyName = "IDCard";
            this.IDCard.HeaderText = "身份证号码";
            this.IDCard.MinimumWidth = 10;
            this.IDCard.Name = "IDCard";
            this.IDCard.ReadOnly = true;
            // 
            // BorrowBook
            // 
            this.BorrowBook.DataPropertyName = "BorrowBook";
            this.BorrowBook.HeaderText = "可借图书数量";
            this.BorrowBook.MinimumWidth = 10;
            this.BorrowBook.Name = "BorrowBook";
            this.BorrowBook.ReadOnly = true;
            // 
            // ReturnBook
            // 
            this.ReturnBook.DataPropertyName = "ReturnBook";
            this.ReturnBook.HeaderText = "需还图书数量";
            this.ReturnBook.MinimumWidth = 10;
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "联系方式";
            this.Phone.MinimumWidth = 10;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.MinimumWidth = 10;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // cmsShortMenu
            // 
            this.cmsShortMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsShortMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAll,
            this.查看借阅信息ToolStripMenuItem,
            this.tsmiUpdate,
            this.tsmiDelete,
            this.tsmiAdd,
            this.tsmiBackMain});
            this.cmsShortMenu.Name = "cmsShortMenu";
            this.cmsShortMenu.Size = new System.Drawing.Size(185, 232);
            // 
            // tsmiAll
            // 
            this.tsmiAll.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAll.Image")));
            this.tsmiAll.Name = "tsmiAll";
            this.tsmiAll.Size = new System.Drawing.Size(184, 38);
            this.tsmiAll.Text = "查看全部";
            this.tsmiAll.Click += new System.EventHandler(this.tsbAll_Click);
            // 
            // 查看借阅信息ToolStripMenuItem
            // 
            this.查看借阅信息ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查看借阅信息ToolStripMenuItem.Image")));
            this.查看借阅信息ToolStripMenuItem.Name = "查看借阅信息ToolStripMenuItem";
            this.查看借阅信息ToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.查看借阅信息ToolStripMenuItem.Text = "查看借阅信息";
            this.查看借阅信息ToolStripMenuItem.Click += new System.EventHandler(this.tsbBorrowByReader_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdate.Image")));
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(184, 38);
            this.tsmiUpdate.Text = "修改信息";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(184, 38);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsbDetele_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAdd.Image")));
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(184, 38);
            this.tsmiAdd.Text = "添加";
            this.tsmiAdd.Click += new System.EventHandler(this.tsbAddReader_Click);
            // 
            // tsmiBackMain
            // 
            this.tsmiBackMain.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBackMain.Image")));
            this.tsmiBackMain.Name = "tsmiBackMain";
            this.tsmiBackMain.Size = new System.Drawing.Size(184, 38);
            this.tsmiBackMain.Text = "返回";
            this.tsmiBackMain.Click += new System.EventHandler(this.tsbBackMain_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 112);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(369, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜  索";
            this.ttSearch.SetToolTip(this.btnSearch, "支持模糊查询。");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(127, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(233, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSearch.Location = new System.Drawing.Point(7, 81);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(119, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "请输入关键字：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBorrowByReader,
            this.tsbOverdue,
            this.tsbAll,
            this.tsbUpdate,
            this.tsbDetele,
            this.tsbAddReader,
            this.tsbBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1065, 59);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBorrowByReader
            // 
            this.tsbBorrowByReader.Image = ((System.Drawing.Image)(resources.GetObject("tsbBorrowByReader.Image")));
            this.tsbBorrowByReader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrowByReader.Name = "tsbBorrowByReader";
            this.tsbBorrowByReader.Size = new System.Drawing.Size(103, 56);
            this.tsbBorrowByReader.Text = "读者借阅信息";
            this.tsbBorrowByReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBorrowByReader.Click += new System.EventHandler(this.tsbBorrowByReader_Click);
            // 
            // tsbOverdue
            // 
            this.tsbOverdue.Image = ((System.Drawing.Image)(resources.GetObject("tsbOverdue.Image")));
            this.tsbOverdue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOverdue.Name = "tsbOverdue";
            this.tsbOverdue.Size = new System.Drawing.Size(103, 56);
            this.tsbOverdue.Text = "读者逾期信息";
            this.tsbOverdue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOverdue.Click += new System.EventHandler(this.tsbOverdue_Click);
            // 
            // tsbAll
            // 
            this.tsbAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbAll.Image")));
            this.tsbAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAll.Name = "tsbAll";
            this.tsbAll.Size = new System.Drawing.Size(73, 56);
            this.tsbAll.Text = "查看全部";
            this.tsbAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAll.Click += new System.EventHandler(this.tsbAll_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(73, 56);
            this.tsbUpdate.Text = "修改信息";
            this.tsbUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbDetele
            // 
            this.tsbDetele.Image = ((System.Drawing.Image)(resources.GetObject("tsbDetele.Image")));
            this.tsbDetele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDetele.Name = "tsbDetele";
            this.tsbDetele.Size = new System.Drawing.Size(73, 56);
            this.tsbDetele.Text = "删除读者";
            this.tsbDetele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDetele.Click += new System.EventHandler(this.tsbDetele_Click);
            // 
            // tsbAddReader
            // 
            this.tsbAddReader.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddReader.Image")));
            this.tsbAddReader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddReader.Name = "tsbAddReader";
            this.tsbAddReader.Size = new System.Drawing.Size(73, 56);
            this.tsbAddReader.Text = "添加读者";
            this.tsbAddReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddReader.Click += new System.EventHandler(this.tsbAddReader_Click);
            // 
            // tsbBack
            // 
            this.tsbBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbBack.Image")));
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(43, 56);
            this.tsbBack.Text = "返回";
            this.tsbBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBack.Click += new System.EventHandler(this.tsbBackMain_Click);
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
            // FrmManageReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 590);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageReader";
            this.Padding = new System.Windows.Forms.Padding(13, 38, 13, 12);
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmManageReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.cmsShortMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDetele;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbAddReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ContextMenuStrip cmsShortMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackMain;
        private System.Windows.Forms.ToolStripButton tsbAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiAll;
        private System.Windows.Forms.ToolStripMenuItem 查看借阅信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbBorrowByReader;
        private System.Windows.Forms.ToolStripButton tsbOverdue;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolTip ttSearch;
    }
}