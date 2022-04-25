namespace MyLirarySystem
{
    partial class FrmBorrowRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorrowRecord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAll = new System.Windows.Forms.ToolStripButton();
            this.tsbRenew = new System.Windows.Forms.ToolStripButton();
            this.tsbGiveBack = new System.Windows.Forms.ToolStripButton();
            this.tsbBackMain = new System.Windows.Forms.ToolStripButton();
            this.lblReaderID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.ReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiveBackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsBorrow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRenew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLookAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.ttSearch = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.cmsBorrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.lblReaderID);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtReaderID);
            this.panel1.Location = new System.Drawing.Point(13, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 95);
            this.panel1.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAll,
            this.tsbRenew,
            this.tsbGiveBack,
            this.tsbBackMain});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1056, 46);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAll
            // 
            this.tsbAll.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbAll.Image")));
            this.tsbAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAll.Name = "tsbAll";
            this.tsbAll.Size = new System.Drawing.Size(47, 43);
            this.tsbAll.Text = "查看";
            this.tsbAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAll.ToolTipText = "查看";
            this.tsbAll.Click += new System.EventHandler(this.tsbAll_Click);
            // 
            // tsbRenew
            // 
            this.tsbRenew.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbRenew.Image = ((System.Drawing.Image)(resources.GetObject("tsbRenew.Image")));
            this.tsbRenew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenew.Name = "tsbRenew";
            this.tsbRenew.Size = new System.Drawing.Size(47, 43);
            this.tsbRenew.Text = "续借";
            this.tsbRenew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRenew.Click += new System.EventHandler(this.tsbRenew_Click);
            // 
            // tsbGiveBack
            // 
            this.tsbGiveBack.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGiveBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbGiveBack.Image")));
            this.tsbGiveBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGiveBack.Name = "tsbGiveBack";
            this.tsbGiveBack.Size = new System.Drawing.Size(47, 43);
            this.tsbGiveBack.Text = "还书";
            this.tsbGiveBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGiveBack.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsbBackMain
            // 
            this.tsbBackMain.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBackMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbBackMain.Image")));
            this.tsbBackMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackMain.Name = "tsbBackMain";
            this.tsbBackMain.Size = new System.Drawing.Size(47, 43);
            this.tsbBackMain.Text = "返回";
            this.tsbBackMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBackMain.Click += new System.EventHandler(this.tsbBackMain_Click);
            // 
            // lblReaderID
            // 
            this.lblReaderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReaderID.AutoSize = true;
            this.lblReaderID.Location = new System.Drawing.Point(7, 64);
            this.lblReaderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReaderID.Name = "lblReaderID";
            this.lblReaderID.Size = new System.Drawing.Size(112, 15);
            this.lblReaderID.TabIndex = 1;
            this.lblReaderID.Text = "输入读者卡号：";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(417, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查  询";
            this.ttSearch.SetToolTip(this.btnSearch, "支持模糊查询。");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtReaderID
            // 
            this.txtReaderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReaderID.Location = new System.Drawing.Point(128, 59);
            this.txtReaderID.Margin = new System.Windows.Forms.Padding(4);
            this.txtReaderID.Name = "txtReaderID";
            this.txtReaderID.Size = new System.Drawing.Size(280, 25);
            this.txtReaderID.TabIndex = 2;
            this.txtReaderID.Click += new System.EventHandler(this.txtReaderID_Click);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            this.dgvBorrow.AllowUserToResizeRows = false;
            this.dgvBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReaderID,
            this.ReaderName,
            this.BookName,
            this.BookID,
            this.BorrowDate,
            this.GiveBackDate,
            this.ReturnDate});
            this.dgvBorrow.ContextMenuStrip = this.cmsBorrow;
            this.dgvBorrow.Location = new System.Drawing.Point(13, 142);
            this.dgvBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowHeadersVisible = false;
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.RowTemplate.Height = 23;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(1056, 309);
            this.dgvBorrow.TabIndex = 9;
            // 
            // ReaderID
            // 
            this.ReaderID.DataPropertyName = "ReaderID";
            this.ReaderID.HeaderText = "读者卡号";
            this.ReaderID.MinimumWidth = 6;
            this.ReaderID.Name = "ReaderID";
            // 
            // ReaderName
            // 
            this.ReaderName.DataPropertyName = "ReaderName";
            this.ReaderName.HeaderText = "姓名";
            this.ReaderName.MinimumWidth = 6;
            this.ReaderName.Name = "ReaderName";
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "图书名称";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "图书编号";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            // 
            // BorrowDate
            // 
            this.BorrowDate.DataPropertyName = "BorrowDate";
            this.BorrowDate.HeaderText = "借阅日期";
            this.BorrowDate.MinimumWidth = 6;
            this.BorrowDate.Name = "BorrowDate";
            // 
            // GiveBackDate
            // 
            this.GiveBackDate.DataPropertyName = "GiveBackDate";
            this.GiveBackDate.HeaderText = "归还日期";
            this.GiveBackDate.MinimumWidth = 6;
            this.GiveBackDate.Name = "GiveBackDate";
            this.GiveBackDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "应还日期";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            // 
            // cmsBorrow
            // 
            this.cmsBorrow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBorrow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRenew,
            this.tsmiReturn,
            this.tsmiLookAll,
            this.tsmiGoBack});
            this.cmsBorrow.Name = "cmsBorrow";
            this.cmsBorrow.Size = new System.Drawing.Size(143, 108);
            // 
            // tsmiRenew
            // 
            this.tsmiRenew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRenew.Image")));
            this.tsmiRenew.Name = "tsmiRenew";
            this.tsmiRenew.Size = new System.Drawing.Size(142, 26);
            this.tsmiRenew.Text = "续借";
            this.tsmiRenew.Click += new System.EventHandler(this.tsbRenew_Click);
            // 
            // tsmiReturn
            // 
            this.tsmiReturn.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReturn.Image")));
            this.tsmiReturn.Name = "tsmiReturn";
            this.tsmiReturn.Size = new System.Drawing.Size(142, 26);
            this.tsmiReturn.Text = "还书";
            this.tsmiReturn.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsmiLookAll
            // 
            this.tsmiLookAll.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLookAll.Image")));
            this.tsmiLookAll.Name = "tsmiLookAll";
            this.tsmiLookAll.Size = new System.Drawing.Size(142, 26);
            this.tsmiLookAll.Text = "查看全部";
            this.tsmiLookAll.Click += new System.EventHandler(this.tsbAll_Click);
            // 
            // tsmiGoBack
            // 
            this.tsmiGoBack.Image = ((System.Drawing.Image)(resources.GetObject("tsmiGoBack.Image")));
            this.tsmiGoBack.Name = "tsmiGoBack";
            this.tsmiGoBack.Size = new System.Drawing.Size(142, 26);
            this.tsmiGoBack.Text = "返回";
            this.tsmiGoBack.Click += new System.EventHandler(this.tsbBackMain_Click);
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
            // FrmBorrowRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 495);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBorrowRecord";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBorrowRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.cmsBorrow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBackMain;
        private System.Windows.Forms.ToolStripButton tsbRenew;
        private System.Windows.Forms.ToolStripButton tsbGiveBack;
        private System.Windows.Forms.Label lblReaderID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.ToolStripButton tsbAll;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiveBackDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.ContextMenuStrip cmsBorrow;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenew;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturn;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolTip ttSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiLookAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoBack;
    }
}