namespace MyLirarySystem
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文献PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新书上架NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书信息管理BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书统计表TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者信息管理IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅规章制度LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书还书续借GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅记录查询JToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排行榜PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅记录统计TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.逾期记录查询OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRegister = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbRecommend = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.plShortKey = new System.Windows.Forms.Panel();
            this.gbBorrow = new System.Windows.Forms.GroupBox();
            this.tsBorrowManager = new System.Windows.Forms.ToolStrip();
            this.tsBorrow = new System.Windows.Forms.ToolStripButton();
            this.tsBorrowRecord = new System.Windows.Forms.ToolStripButton();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.tsSelectMananger = new System.Windows.Forms.ToolStrip();
            this.tsbPush = new System.Windows.Forms.ToolStripButton();
            this.tsStatistics = new System.Windows.Forms.ToolStripButton();
            this.tsOverdue = new System.Windows.Forms.ToolStripButton();
            this.gbReader = new System.Windows.Forms.GroupBox();
            this.tsReaderManager = new System.Windows.Forms.ToolStrip();
            this.tsReader = new System.Windows.Forms.ToolStripButton();
            this.tsRule = new System.Windows.Forms.ToolStripButton();
            this.gbBooks = new System.Windows.Forms.GroupBox();
            this.tsBookManager = new System.Windows.Forms.ToolStrip();
            this.tsbPhiloloy = new System.Windows.Forms.ToolStripButton();
            this.tsbNewBook = new System.Windows.Forms.ToolStripButton();
            this.tsBookinfo = new System.Windows.Forms.ToolStripButton();
            this.tsBookClass = new System.Windows.Forms.ToolStripButton();
            this.plMain = new System.Windows.Forms.Panel();
            this.plHint = new System.Windows.Forms.Panel();
            this.lblOverdueSum = new System.Windows.Forms.Label();
            this.lblReaderSum = new System.Windows.Forms.Label();
            this.lblBookSum = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHide4 = new System.Windows.Forms.Label();
            this.lblHide3 = new System.Windows.Forms.Label();
            this.lblHide2 = new System.Windows.Forms.Label();
            this.lblHide1 = new System.Windows.Forms.Label();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.msMenu.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.plShortKey.SuspendLayout();
            this.gbBorrow.SuspendLayout();
            this.tsBorrowManager.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.tsSelectMananger.SuspendLayout();
            this.gbReader.SuspendLayout();
            this.tsReaderManager.SuspendLayout();
            this.gbBooks.SuspendLayout();
            this.tsBookManager.SuspendLayout();
            this.plMain.SuspendLayout();
            this.plHint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.Silver;
            this.msMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiHelp});
            this.msMenu.Location = new System.Drawing.Point(13, 60);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(8, 1, 0, 1);
            this.msMenu.Size = new System.Drawing.Size(1211, 30);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "首页菜单栏";
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBook,
            this.tsmiLogin,
            this.图书管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.借阅管理ToolStripMenuItem,
            this.查询统计ToolStripMenuItem,
            this.tsmiExit});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(92, 28);
            this.tsmiSystem.Tag = "";
            this.tsmiSystem.Text = "系统（&S）";
            // 
            // tsmiBook
            // 
            this.tsmiBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBook.Image")));
            this.tsmiBook.Name = "tsmiBook";
            this.tsmiBook.Size = new System.Drawing.Size(192, 26);
            this.tsmiBook.Text = "查看图书（&R）";
            this.tsmiBook.Click += new System.EventHandler(this.tsmiBook_Click);
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLogin.Image")));
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(192, 26);
            this.tsmiLogin.Text = "登录（&L）";
            this.tsmiLogin.Click += new System.EventHandler(this.tsmiLogin_Click);
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文献PToolStripMenuItem,
            this.新书上架NToolStripMenuItem,
            this.图书信息管理BToolStripMenuItem,
            this.图书统计表TToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("图书管理ToolStripMenuItem.Image")));
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.图书管理ToolStripMenuItem.Text = "图书管理(&M)";
            // 
            // 文献PToolStripMenuItem
            // 
            this.文献PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("文献PToolStripMenuItem.Image")));
            this.文献PToolStripMenuItem.Name = "文献PToolStripMenuItem";
            this.文献PToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.文献PToolStripMenuItem.Text = "文献（&P)";
            this.文献PToolStripMenuItem.Click += new System.EventHandler(this.tsbPhiloloy_Click);
            // 
            // 新书上架NToolStripMenuItem
            // 
            this.新书上架NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新书上架NToolStripMenuItem.Image")));
            this.新书上架NToolStripMenuItem.Name = "新书上架NToolStripMenuItem";
            this.新书上架NToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.新书上架NToolStripMenuItem.Text = "新书上架（&N）";
            this.新书上架NToolStripMenuItem.Click += new System.EventHandler(this.tsbNewBook_Click);
            // 
            // 图书信息管理BToolStripMenuItem
            // 
            this.图书信息管理BToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("图书信息管理BToolStripMenuItem.Image")));
            this.图书信息管理BToolStripMenuItem.Name = "图书信息管理BToolStripMenuItem";
            this.图书信息管理BToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.图书信息管理BToolStripMenuItem.Text = "图书信息管理（&B）";
            this.图书信息管理BToolStripMenuItem.Click += new System.EventHandler(this.tsBookInfo_Click);
            // 
            // 图书统计表TToolStripMenuItem
            // 
            this.图书统计表TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("图书统计表TToolStripMenuItem.Image")));
            this.图书统计表TToolStripMenuItem.Name = "图书统计表TToolStripMenuItem";
            this.图书统计表TToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.图书统计表TToolStripMenuItem.Text = "图书统计表（&T)";
            this.图书统计表TToolStripMenuItem.Click += new System.EventHandler(this.tsBookClass_Click);
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者信息管理IToolStripMenuItem,
            this.借阅规章制度LToolStripMenuItem});
            this.读者管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("读者管理ToolStripMenuItem.Image")));
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.读者管理ToolStripMenuItem.Text = "读者管理(&R)";
            // 
            // 读者信息管理IToolStripMenuItem
            // 
            this.读者信息管理IToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("读者信息管理IToolStripMenuItem.Image")));
            this.读者信息管理IToolStripMenuItem.Name = "读者信息管理IToolStripMenuItem";
            this.读者信息管理IToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.读者信息管理IToolStripMenuItem.Text = "读者信息管理（&I）";
            this.读者信息管理IToolStripMenuItem.Click += new System.EventHandler(this.tsReader_Click);
            // 
            // 借阅规章制度LToolStripMenuItem
            // 
            this.借阅规章制度LToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("借阅规章制度LToolStripMenuItem.Image")));
            this.借阅规章制度LToolStripMenuItem.Name = "借阅规章制度LToolStripMenuItem";
            this.借阅规章制度LToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.借阅规章制度LToolStripMenuItem.Text = "借阅规章制度（&L）";
            this.借阅规章制度LToolStripMenuItem.Click += new System.EventHandler(this.tsRule_Click);
            // 
            // 借阅管理ToolStripMenuItem
            // 
            this.借阅管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书还书续借GToolStripMenuItem,
            this.借阅记录查询JToolStripMenuItem});
            this.借阅管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("借阅管理ToolStripMenuItem.Image")));
            this.借阅管理ToolStripMenuItem.Name = "借阅管理ToolStripMenuItem";
            this.借阅管理ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.借阅管理ToolStripMenuItem.Text = "借阅管理(&B)";
            // 
            // 借书还书续借GToolStripMenuItem
            // 
            this.借书还书续借GToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("借书还书续借GToolStripMenuItem.Image")));
            this.借书还书续借GToolStripMenuItem.Name = "借书还书续借GToolStripMenuItem";
            this.借书还书续借GToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.借书还书续借GToolStripMenuItem.Text = "借书还书续借（&G）";
            this.借书还书续借GToolStripMenuItem.Click += new System.EventHandler(this.tsBorrow_Click);
            // 
            // 借阅记录查询JToolStripMenuItem
            // 
            this.借阅记录查询JToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("借阅记录查询JToolStripMenuItem.Image")));
            this.借阅记录查询JToolStripMenuItem.Name = "借阅记录查询JToolStripMenuItem";
            this.借阅记录查询JToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.借阅记录查询JToolStripMenuItem.Text = "借阅记录查询（&J）";
            this.借阅记录查询JToolStripMenuItem.Click += new System.EventHandler(this.tsBorrowRecord_Click);
            // 
            // 查询统计ToolStripMenuItem
            // 
            this.查询统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.排行榜PToolStripMenuItem,
            this.借阅记录统计TToolStripMenuItem,
            this.逾期记录查询OToolStripMenuItem});
            this.查询统计ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查询统计ToolStripMenuItem.Image")));
            this.查询统计ToolStripMenuItem.Name = "查询统计ToolStripMenuItem";
            this.查询统计ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.查询统计ToolStripMenuItem.Text = "查询统计(&S)";
            // 
            // 排行榜PToolStripMenuItem
            // 
            this.排行榜PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("排行榜PToolStripMenuItem.Image")));
            this.排行榜PToolStripMenuItem.Name = "排行榜PToolStripMenuItem";
            this.排行榜PToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.排行榜PToolStripMenuItem.Text = "排行榜（&P）";
            this.排行榜PToolStripMenuItem.Click += new System.EventHandler(this.tsbPush_Click);
            // 
            // 借阅记录统计TToolStripMenuItem
            // 
            this.借阅记录统计TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("借阅记录统计TToolStripMenuItem.Image")));
            this.借阅记录统计TToolStripMenuItem.Name = "借阅记录统计TToolStripMenuItem";
            this.借阅记录统计TToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.借阅记录统计TToolStripMenuItem.Text = "借阅记录统计（&T）";
            this.借阅记录统计TToolStripMenuItem.Click += new System.EventHandler(this.tsStatistics_Click);
            // 
            // 逾期记录查询OToolStripMenuItem
            // 
            this.逾期记录查询OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("逾期记录查询OToolStripMenuItem.Image")));
            this.逾期记录查询OToolStripMenuItem.Name = "逾期记录查询OToolStripMenuItem";
            this.逾期记录查询OToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.逾期记录查询OToolStripMenuItem.Text = "逾期记录查询（&O）";
            this.逾期记录查询OToolStripMenuItem.Click += new System.EventHandler(this.tsOverdue_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(192, 26);
            this.tsmiExit.Text = "退出(&E)";
            this.tsmiExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(95, 28);
            this.tsmiHelp.Tag = "";
            this.tsmiHelp.Text = "帮助（&H）";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAbout.Image")));
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(193, 26);
            this.tsmiAbout.Text = "关于我们（&A）";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogin,
            this.toolStripButton1,
            this.tsbAdd,
            this.tsbRegister,
            this.tsbUpdate,
            this.tsbRecommend,
            this.toolStripButton2,
            this.tsbExit});
            this.tsMenu.Location = new System.Drawing.Point(13, 90);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMenu.Size = new System.Drawing.Size(1211, 59);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "tsMenu";
            // 
            // tsbLogin
            // 
            this.tsbLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogin.Image")));
            this.tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogin.Name = "tsbLogin";
            this.tsbLogin.Size = new System.Drawing.Size(43, 56);
            this.tsbLogin.Tag = "";
            this.tsbLogin.Text = "登录";
            this.tsbLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogin.Click += new System.EventHandler(this.tsmiLogin_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 56);
            this.toolStripButton1.Tag = "";
            this.toolStripButton1.Text = "    图书   ";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.tsmiBook_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(43, 56);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAdd.Visible = false;
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbRegister
            // 
            this.tsbRegister.Image = ((System.Drawing.Image)(resources.GetObject("tsbRegister.Image")));
            this.tsbRegister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegister.Name = "tsbRegister";
            this.tsbRegister.Size = new System.Drawing.Size(73, 56);
            this.tsbRegister.Tag = "";
            this.tsbRegister.Text = "快速注册";
            this.tsbRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRegister.Click += new System.EventHandler(this.tsbRegister_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(43, 56);
            this.tsbUpdate.Text = "修改";
            this.tsbUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdate.Visible = false;
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbRecommend
            // 
            this.tsbRecommend.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecommend.Image")));
            this.tsbRecommend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecommend.Name = "tsbRecommend";
            this.tsbRecommend.Size = new System.Drawing.Size(59, 56);
            this.tsbRecommend.Text = "  推荐  ";
            this.tsbRecommend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRecommend.Click += new System.EventHandler(this.tsbRecommend_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(89, 56);
            this.toolStripButton2.Tag = "";
            this.toolStripButton2.Text = "  重新登录  ";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(43, 56);
            this.tsbExit.Tag = "";
            this.tsbExit.Text = "退出";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // plShortKey
            // 
            this.plShortKey.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plShortKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plShortKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plShortKey.Controls.Add(this.gbBorrow);
            this.plShortKey.Controls.Add(this.gbSelect);
            this.plShortKey.Controls.Add(this.gbReader);
            this.plShortKey.Controls.Add(this.gbBooks);
            this.plShortKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plShortKey.Location = new System.Drawing.Point(0, 0);
            this.plShortKey.Margin = new System.Windows.Forms.Padding(4);
            this.plShortKey.Name = "plShortKey";
            this.plShortKey.Size = new System.Drawing.Size(247, 550);
            this.plShortKey.TabIndex = 3;
            // 
            // gbBorrow
            // 
            this.gbBorrow.Controls.Add(this.tsBorrowManager);
            this.gbBorrow.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbBorrow.Location = new System.Drawing.Point(27, 585);
            this.gbBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.gbBorrow.Name = "gbBorrow";
            this.gbBorrow.Padding = new System.Windows.Forms.Padding(4);
            this.gbBorrow.Size = new System.Drawing.Size(241, 128);
            this.gbBorrow.TabIndex = 3;
            this.gbBorrow.TabStop = false;
            this.gbBorrow.Text = "借阅管理";
            // 
            // tsBorrowManager
            // 
            this.tsBorrowManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsBorrowManager.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsBorrowManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBorrow,
            this.tsBorrowRecord});
            this.tsBorrowManager.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.tsBorrowManager.Location = new System.Drawing.Point(4, 22);
            this.tsBorrowManager.Name = "tsBorrowManager";
            this.tsBorrowManager.Padding = new System.Windows.Forms.Padding(40, 0, 1, 0);
            this.tsBorrowManager.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsBorrowManager.ShowItemToolTips = false;
            this.tsBorrowManager.Size = new System.Drawing.Size(233, 102);
            this.tsBorrowManager.TabIndex = 0;
            this.tsBorrowManager.Text = "toolStrip3";
            // 
            // tsBorrow
            // 
            this.tsBorrow.Image = ((System.Drawing.Image)(resources.GetObject("tsBorrow.Image")));
            this.tsBorrow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBorrow.Name = "tsBorrow";
            this.tsBorrow.Size = new System.Drawing.Size(135, 36);
            this.tsBorrow.Tag = "";
            this.tsBorrow.Text = "借书还书续借";
            this.tsBorrow.Click += new System.EventHandler(this.tsBorrow_Click);
            // 
            // tsBorrowRecord
            // 
            this.tsBorrowRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsBorrowRecord.Image")));
            this.tsBorrowRecord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBorrowRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBorrowRecord.Name = "tsBorrowRecord";
            this.tsBorrowRecord.Size = new System.Drawing.Size(135, 36);
            this.tsBorrowRecord.Tag = "";
            this.tsBorrowRecord.Text = "借阅记录查询";
            this.tsBorrowRecord.Click += new System.EventHandler(this.tsBorrowRecord_Click);
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.tsSelectMananger);
            this.gbSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbSelect.Location = new System.Drawing.Point(27, 405);
            this.gbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Padding = new System.Windows.Forms.Padding(4);
            this.gbSelect.Size = new System.Drawing.Size(241, 171);
            this.gbSelect.TabIndex = 2;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "查询统计";
            // 
            // tsSelectMananger
            // 
            this.tsSelectMananger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsSelectMananger.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsSelectMananger.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPush,
            this.tsStatistics,
            this.tsOverdue});
            this.tsSelectMananger.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.tsSelectMananger.Location = new System.Drawing.Point(4, 22);
            this.tsSelectMananger.Name = "tsSelectMananger";
            this.tsSelectMananger.Padding = new System.Windows.Forms.Padding(40, 0, 1, 0);
            this.tsSelectMananger.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsSelectMananger.ShowItemToolTips = false;
            this.tsSelectMananger.Size = new System.Drawing.Size(233, 145);
            this.tsSelectMananger.TabIndex = 0;
            this.tsSelectMananger.Text = "toolStrip2";
            // 
            // tsbPush
            // 
            this.tsbPush.Image = ((System.Drawing.Image)(resources.GetObject("tsbPush.Image")));
            this.tsbPush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPush.Name = "tsbPush";
            this.tsbPush.Size = new System.Drawing.Size(90, 36);
            this.tsbPush.Text = "排行榜";
            this.tsbPush.Click += new System.EventHandler(this.tsbPush_Click);
            // 
            // tsStatistics
            // 
            this.tsStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tsStatistics.Image")));
            this.tsStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStatistics.Name = "tsStatistics";
            this.tsStatistics.Size = new System.Drawing.Size(135, 36);
            this.tsStatistics.Tag = "";
            this.tsStatistics.Text = "借阅记录统计";
            this.tsStatistics.Click += new System.EventHandler(this.tsStatistics_Click);
            // 
            // tsOverdue
            // 
            this.tsOverdue.Image = ((System.Drawing.Image)(resources.GetObject("tsOverdue.Image")));
            this.tsOverdue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOverdue.Name = "tsOverdue";
            this.tsOverdue.Size = new System.Drawing.Size(135, 36);
            this.tsOverdue.Tag = "";
            this.tsOverdue.Text = "逾期记录查询";
            this.tsOverdue.Click += new System.EventHandler(this.tsOverdue_Click);
            // 
            // gbReader
            // 
            this.gbReader.Controls.Add(this.tsReaderManager);
            this.gbReader.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbReader.Location = new System.Drawing.Point(25, 271);
            this.gbReader.Margin = new System.Windows.Forms.Padding(4);
            this.gbReader.Name = "gbReader";
            this.gbReader.Padding = new System.Windows.Forms.Padding(4);
            this.gbReader.Size = new System.Drawing.Size(241, 125);
            this.gbReader.TabIndex = 1;
            this.gbReader.TabStop = false;
            this.gbReader.Text = "读者管理";
            // 
            // tsReaderManager
            // 
            this.tsReaderManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsReaderManager.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsReaderManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReader,
            this.tsRule});
            this.tsReaderManager.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.tsReaderManager.Location = new System.Drawing.Point(4, 22);
            this.tsReaderManager.Name = "tsReaderManager";
            this.tsReaderManager.Padding = new System.Windows.Forms.Padding(40, 0, 1, 0);
            this.tsReaderManager.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsReaderManager.ShowItemToolTips = false;
            this.tsReaderManager.Size = new System.Drawing.Size(233, 99);
            this.tsReaderManager.TabIndex = 0;
            this.tsReaderManager.Text = "toolStrip1";
            // 
            // tsReader
            // 
            this.tsReader.Image = ((System.Drawing.Image)(resources.GetObject("tsReader.Image")));
            this.tsReader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReader.Name = "tsReader";
            this.tsReader.Size = new System.Drawing.Size(135, 36);
            this.tsReader.Tag = "";
            this.tsReader.Text = "读者信息管理";
            this.tsReader.Click += new System.EventHandler(this.tsReader_Click);
            // 
            // tsRule
            // 
            this.tsRule.Image = ((System.Drawing.Image)(resources.GetObject("tsRule.Image")));
            this.tsRule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRule.Name = "tsRule";
            this.tsRule.Size = new System.Drawing.Size(135, 36);
            this.tsRule.Tag = "";
            this.tsRule.Text = "借阅规章制度";
            this.tsRule.Click += new System.EventHandler(this.tsRule_Click);
            // 
            // gbBooks
            // 
            this.gbBooks.Controls.Add(this.tsBookManager);
            this.gbBooks.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbBooks.Location = new System.Drawing.Point(27, 42);
            this.gbBooks.Margin = new System.Windows.Forms.Padding(4);
            this.gbBooks.Name = "gbBooks";
            this.gbBooks.Padding = new System.Windows.Forms.Padding(4);
            this.gbBooks.Size = new System.Drawing.Size(241, 221);
            this.gbBooks.TabIndex = 0;
            this.gbBooks.TabStop = false;
            this.gbBooks.Text = "图书管理";
            // 
            // tsBookManager
            // 
            this.tsBookManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsBookManager.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsBookManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPhiloloy,
            this.tsbNewBook,
            this.tsBookinfo,
            this.tsBookClass});
            this.tsBookManager.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.tsBookManager.Location = new System.Drawing.Point(4, 22);
            this.tsBookManager.Name = "tsBookManager";
            this.tsBookManager.Padding = new System.Windows.Forms.Padding(40, 0, 1, 0);
            this.tsBookManager.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsBookManager.ShowItemToolTips = false;
            this.tsBookManager.Size = new System.Drawing.Size(233, 195);
            this.tsBookManager.TabIndex = 0;
            this.tsBookManager.Text = "tsMenu2";
            // 
            // tsbPhiloloy
            // 
            this.tsbPhiloloy.Image = ((System.Drawing.Image)(resources.GetObject("tsbPhiloloy.Image")));
            this.tsbPhiloloy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPhiloloy.Name = "tsbPhiloloy";
            this.tsbPhiloloy.Size = new System.Drawing.Size(75, 36);
            this.tsbPhiloloy.Text = "文献";
            this.tsbPhiloloy.Click += new System.EventHandler(this.tsbPhiloloy_Click);
            // 
            // tsbNewBook
            // 
            this.tsbNewBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbNewBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewBook.Image")));
            this.tsbNewBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewBook.Name = "tsbNewBook";
            this.tsbNewBook.Size = new System.Drawing.Size(105, 36);
            this.tsbNewBook.Text = "新书上架";
            this.tsbNewBook.Click += new System.EventHandler(this.tsbNewBook_Click);
            // 
            // tsBookinfo
            // 
            this.tsBookinfo.Image = ((System.Drawing.Image)(resources.GetObject("tsBookinfo.Image")));
            this.tsBookinfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBookinfo.Name = "tsBookinfo";
            this.tsBookinfo.Size = new System.Drawing.Size(135, 36);
            this.tsBookinfo.Tag = "";
            this.tsBookinfo.Text = "图书信息管理";
            this.tsBookinfo.Click += new System.EventHandler(this.tsBookInfo_Click);
            // 
            // tsBookClass
            // 
            this.tsBookClass.Image = ((System.Drawing.Image)(resources.GetObject("tsBookClass.Image")));
            this.tsBookClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBookClass.Name = "tsBookClass";
            this.tsBookClass.Size = new System.Drawing.Size(120, 36);
            this.tsBookClass.Tag = "";
            this.tsBookClass.Text = "图书统计表";
            this.tsBookClass.Click += new System.EventHandler(this.tsBookClass_Click);
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.Transparent;
            this.plMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plMain.BackgroundImage")));
            this.plMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plMain.Controls.Add(this.plHint);
            this.plMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 0);
            this.plMain.Margin = new System.Windows.Forms.Padding(4);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(963, 550);
            this.plMain.TabIndex = 5;
            // 
            // plHint
            // 
            this.plHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plHint.BackColor = System.Drawing.Color.Transparent;
            this.plHint.Controls.Add(this.lblOverdueSum);
            this.plHint.Controls.Add(this.lblReaderSum);
            this.plHint.Controls.Add(this.lblBookSum);
            this.plHint.Controls.Add(this.lblUser);
            this.plHint.Controls.Add(this.lblHide4);
            this.plHint.Controls.Add(this.lblHide3);
            this.plHint.Controls.Add(this.lblHide2);
            this.plHint.Controls.Add(this.lblHide1);
            this.plHint.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plHint.Location = new System.Drawing.Point(63, 363);
            this.plHint.Margin = new System.Windows.Forms.Padding(4);
            this.plHint.Name = "plHint";
            this.plHint.Size = new System.Drawing.Size(267, 151);
            this.plHint.TabIndex = 2;
            // 
            // lblOverdueSum
            // 
            this.lblOverdueSum.AutoSize = true;
            this.lblOverdueSum.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdueSum.Location = new System.Drawing.Point(121, 119);
            this.lblOverdueSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverdueSum.Name = "lblOverdueSum";
            this.lblOverdueSum.Size = new System.Drawing.Size(0, 19);
            this.lblOverdueSum.TabIndex = 7;
            // 
            // lblReaderSum
            // 
            this.lblReaderSum.AutoSize = true;
            this.lblReaderSum.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaderSum.Location = new System.Drawing.Point(121, 86);
            this.lblReaderSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReaderSum.Name = "lblReaderSum";
            this.lblReaderSum.Size = new System.Drawing.Size(0, 19);
            this.lblReaderSum.TabIndex = 6;
            // 
            // lblBookSum
            // 
            this.lblBookSum.AutoSize = true;
            this.lblBookSum.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookSum.Location = new System.Drawing.Point(121, 54);
            this.lblBookSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookSum.Name = "lblBookSum";
            this.lblBookSum.Size = new System.Drawing.Size(0, 19);
            this.lblBookSum.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Crimson;
            this.lblUser.Location = new System.Drawing.Point(121, 21);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 19);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "尚未登录";
            // 
            // lblHide4
            // 
            this.lblHide4.AutoSize = true;
            this.lblHide4.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHide4.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblHide4.Location = new System.Drawing.Point(27, 119);
            this.lblHide4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHide4.Name = "lblHide4";
            this.lblHide4.Size = new System.Drawing.Size(94, 19);
            this.lblHide4.TabIndex = 3;
            this.lblHide4.Text = "逾期总计：";
            // 
            // lblHide3
            // 
            this.lblHide3.AutoSize = true;
            this.lblHide3.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHide3.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblHide3.Location = new System.Drawing.Point(27, 86);
            this.lblHide3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHide3.Name = "lblHide3";
            this.lblHide3.Size = new System.Drawing.Size(94, 19);
            this.lblHide3.TabIndex = 2;
            this.lblHide3.Text = "读者总计：";
            // 
            // lblHide2
            // 
            this.lblHide2.AutoSize = true;
            this.lblHide2.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHide2.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblHide2.Location = new System.Drawing.Point(27, 54);
            this.lblHide2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHide2.Name = "lblHide2";
            this.lblHide2.Size = new System.Drawing.Size(94, 19);
            this.lblHide2.TabIndex = 1;
            this.lblHide2.Text = "图书总计：";
            // 
            // lblHide1
            // 
            this.lblHide1.AutoSize = true;
            this.lblHide1.BackColor = System.Drawing.Color.Transparent;
            this.lblHide1.Font = new System.Drawing.Font("ZCOOL KuaiLe", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHide1.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblHide1.Location = new System.Drawing.Point(27, 21);
            this.lblHide1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHide1.Name = "lblHide1";
            this.lblHide1.Size = new System.Drawing.Size(94, 19);
            this.lblHide1.TabIndex = 0;
            this.lblHide1.Text = "当前用户：";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(13, 149);
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.plShortKey);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.plMain);
            this.scMain.Size = new System.Drawing.Size(1211, 550);
            this.scMain.SplitterDistance = 247;
            this.scMain.SplitterWidth = 1;
            this.scMain.TabIndex = 6;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 711);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 12);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.plShortKey.ResumeLayout(false);
            this.gbBorrow.ResumeLayout(false);
            this.gbBorrow.PerformLayout();
            this.tsBorrowManager.ResumeLayout(false);
            this.tsBorrowManager.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.tsSelectMananger.ResumeLayout(false);
            this.tsSelectMananger.PerformLayout();
            this.gbReader.ResumeLayout(false);
            this.gbReader.PerformLayout();
            this.tsReaderManager.ResumeLayout(false);
            this.tsReaderManager.PerformLayout();
            this.gbBooks.ResumeLayout(false);
            this.gbBooks.PerformLayout();
            this.tsBookManager.ResumeLayout(false);
            this.tsBookManager.PerformLayout();
            this.plMain.ResumeLayout(false);
            this.plHint.ResumeLayout(false);
            this.plHint.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbLogin;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.GroupBox gbBooks;
        private System.Windows.Forms.ToolStrip tsBookManager;
        private System.Windows.Forms.ToolStripButton tsBookinfo;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.ToolStrip tsSelectMananger;
        private System.Windows.Forms.ToolStripButton tsStatistics;
        private System.Windows.Forms.ToolStripButton tsOverdue;
        private System.Windows.Forms.GroupBox gbReader;
        private System.Windows.Forms.ToolStrip tsReaderManager;
        private System.Windows.Forms.ToolStripButton tsReader;
        private System.Windows.Forms.ToolStripButton tsRule;
        private System.Windows.Forms.GroupBox gbBorrow;
        private System.Windows.Forms.ToolStrip tsBorrowManager;
        private System.Windows.Forms.ToolStripButton tsBorrow;
        private System.Windows.Forms.ToolStripButton tsBorrowRecord;
        private System.Windows.Forms.ToolStripMenuItem tsmiBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel plHint;
        private System.Windows.Forms.Label lblHide4;
        private System.Windows.Forms.Label lblHide3;
        private System.Windows.Forms.Label lblHide2;
        private System.Windows.Forms.Label lblHide1;
        private System.Windows.Forms.Label lblOverdueSum;
        private System.Windows.Forms.Label lblReaderSum;
        private System.Windows.Forms.Label lblBookSum;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbRegister;
        public System.Windows.Forms.Panel plShortKey;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.SplitContainer scMain;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripButton tsBookClass;
        private System.Windows.Forms.ToolStripButton tsbRecommend;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbPush;
        private System.Windows.Forms.ToolStripButton tsbPhiloloy;
        private System.Windows.Forms.ToolStripButton tsbNewBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文献PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新书上架NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书信息管理BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书统计表TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者信息管理IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅规章制度LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书还书续借GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅记录查询JToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排行榜PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅记录统计TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 逾期记录查询OToolStripMenuItem;
    }
}