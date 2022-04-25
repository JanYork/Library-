namespace MyLirarySystem
{
    partial class FrmOverdue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOverdue));
            this.cmsOverdue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsbBackMain = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.clmReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiveBackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.cmsOverdue.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsOverdue
            // 
            this.cmsOverdue.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsOverdue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看全部ToolStripMenuItem,
            this.tsmiRenew,
            this.tsmiReturnBook,
            this.tsmiReturn});
            this.cmsOverdue.Name = "cmsOverdue";
            this.cmsOverdue.Size = new System.Drawing.Size(155, 156);
            // 
            // 查看全部ToolStripMenuItem
            // 
            this.查看全部ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查看全部ToolStripMenuItem.Image")));
            this.查看全部ToolStripMenuItem.Name = "查看全部ToolStripMenuItem";
            this.查看全部ToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.查看全部ToolStripMenuItem.Text = "查看全部";
            this.查看全部ToolStripMenuItem.Click += new System.EventHandler(this.tsbAll_Click);
            // 
            // tsmiRenew
            // 
            this.tsmiRenew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRenew.Image")));
            this.tsmiRenew.Name = "tsmiRenew";
            this.tsmiRenew.Size = new System.Drawing.Size(154, 38);
            this.tsmiRenew.Text = "续借";
            this.tsmiRenew.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsmiReturnBook
            // 
            this.tsmiReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReturnBook.Image")));
            this.tsmiReturnBook.Name = "tsmiReturnBook";
            this.tsmiReturnBook.Size = new System.Drawing.Size(154, 38);
            this.tsmiReturnBook.Text = "还书";
            this.tsmiReturnBook.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsmiReturn
            // 
            this.tsmiReturn.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReturn.Image")));
            this.tsmiReturn.Name = "tsmiReturn";
            this.tsmiReturn.Size = new System.Drawing.Size(154, 38);
            this.tsmiReturn.Text = "返回";
            this.tsmiReturn.Click += new System.EventHandler(this.tsbBackMain_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入读者卡号：";
            // 
            // txtReaderID
            // 
            this.txtReaderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReaderID.Location = new System.Drawing.Point(131, 70);
            this.txtReaderID.Margin = new System.Windows.Forms.Padding(4);
            this.txtReaderID.Name = "txtReaderID";
            this.txtReaderID.Size = new System.Drawing.Size(280, 25);
            this.txtReaderID.TabIndex = 2;
            this.txtReaderID.Click += new System.EventHandler(this.txtReaderID_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(426, 68);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查  询";
            this.toolTip1.SetToolTip(this.btnSearch, "支持模糊查询。");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtReaderID);
            this.panel1.Location = new System.Drawing.Point(9, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 101);
            this.panel1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAll,
            this.toolStripButton1,
            this.toolStripButton4,
            this.tsbBackMain});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1044, 59);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(43, 56);
            this.toolStripButton1.Text = "续借";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(43, 56);
            this.toolStripButton4.Text = "还书";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsbBackMain
            // 
            this.tsbBackMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbBackMain.Image")));
            this.tsbBackMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackMain.Name = "tsbBackMain";
            this.tsbBackMain.Size = new System.Drawing.Size(43, 56);
            this.tsbBackMain.Text = "返回";
            this.tsbBackMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBackMain.Click += new System.EventHandler(this.tsbBackMain_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // dgvOverdue
            // 
            this.dgvOverdue.AllowUserToAddRows = false;
            this.dgvOverdue.AllowUserToDeleteRows = false;
            this.dgvOverdue.AllowUserToResizeRows = false;
            this.dgvOverdue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOverdue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverdue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmReaderID,
            this.ReaderName,
            this.BookName,
            this.BookID,
            this.BorrowDate,
            this.GiveBackDate,
            this.ReturnDate});
            this.dgvOverdue.Location = new System.Drawing.Point(9, 140);
            this.dgvOverdue.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.RowHeadersVisible = false;
            this.dgvOverdue.RowHeadersWidth = 82;
            this.dgvOverdue.RowTemplate.Height = 23;
            this.dgvOverdue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverdue.Size = new System.Drawing.Size(1047, 457);
            this.dgvOverdue.TabIndex = 10;
            // 
            // clmReaderID
            // 
            this.clmReaderID.DataPropertyName = "ReaderID";
            this.clmReaderID.HeaderText = "读者卡号";
            this.clmReaderID.MinimumWidth = 10;
            this.clmReaderID.Name = "clmReaderID";
            // 
            // ReaderName
            // 
            this.ReaderName.DataPropertyName = "ReaderName";
            this.ReaderName.HeaderText = "姓名";
            this.ReaderName.MinimumWidth = 10;
            this.ReaderName.Name = "ReaderName";
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "图书名称";
            this.BookName.MinimumWidth = 10;
            this.BookName.Name = "BookName";
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "图书编号";
            this.BookID.MinimumWidth = 10;
            this.BookID.Name = "BookID";
            // 
            // BorrowDate
            // 
            this.BorrowDate.DataPropertyName = "BorrowDate";
            this.BorrowDate.HeaderText = "借阅日期";
            this.BorrowDate.MinimumWidth = 10;
            this.BorrowDate.Name = "BorrowDate";
            // 
            // GiveBackDate
            // 
            this.GiveBackDate.DataPropertyName = "GiveBackDate";
            this.GiveBackDate.HeaderText = "归还日期";
            this.GiveBackDate.MinimumWidth = 10;
            this.GiveBackDate.Name = "GiveBackDate";
            this.GiveBackDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "应还日期";
            this.ReturnDate.MinimumWidth = 10;
            this.ReturnDate.Name = "ReturnDate";
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
            // FrmOverdue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 596);
            this.Controls.Add(this.dgvOverdue);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOverdue";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 12);
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOverdue_Load);
            this.cmsOverdue.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBackMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip cmsOverdue;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturnBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenew;
        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiveBackDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturn;
        private System.Windows.Forms.ToolStripMenuItem 查看全部ToolStripMenuItem;
    }
}