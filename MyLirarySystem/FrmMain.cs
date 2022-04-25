using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace MyLirarySystem
{
    /// <summary>
    /// MyLibray首页
    /// </summary>
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //定义提示信息
        public const string HINT = "提示";
        public const string CONTENT = "您尚未有此权限";

        #region 退出按钮
        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExit_Click(object sender, EventArgs e)
        {
            //退出
            Application.Exit();
        }
        #endregion 

        #region 隐藏按钮
        /// <summary>
        /// 隐藏按钮
        /// </summary>
        public void Hidden()
        {
            //判断登录类型是否为管理员
            if (StaticStore.loginType && StaticStore.IsLogin)
            {
                //显示管理员添加和修改
                this.tsbAdd.Visible = true;
                this.tsbUpdate.Visible = true;
            }

            //判断用户是否登录，登录类型是否为读者
            if (StaticStore.IsLogin == false || StaticStore.loginType == false)
            {
                //隐藏管理员添加和修改
                this.tsbAdd.Visible = false;
                this.tsbUpdate.Visible = false;
            }
        }
        #endregion

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件,隐藏控件plShortKey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //窗体加载，弹出窗口提示用户登录
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            //显示登录用户名
            this.lblUser.Text = StaticStore.loginName;


            //显示控件plShortKey
            this.plShortKey.Visible = true;

            //显示图书总计
            this.BookSUM();

            //读者共计
            this.ReaderSUM();

            //逾期共计
            this.OverdueSUM();

            //管理员的特殊按钮隐藏
            this.Hidden();
        }
        #endregion

        #region 快捷视图按钮,显示plShortKey
        /// <summary>
        /// 显示控件plShortKey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiShortView_Click(object sender, EventArgs e)
        {
            //显示控件plShortKey
            this.plShortKey.Visible = true;

        }
        #endregion

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.lblUser.Text = StaticStore.loginName;
            //隐藏
            this.Hidden();
        }
        #endregion

        #region 图书总计
        /// <summary>
        /// 图书总计
        /// </summary>
        public void BookSUM()
        {
            //sql语句
            //查询图书总数
            string sqlSum = @"select count(*) from books";
            //查询图书总类型
            string sqlType = @"select count(*) from book";

            //执行
            int sum = Convert.ToInt32(DBHelper.ExecuteScalar(sqlSum));
            int type = Convert.ToInt32(DBHelper.ExecuteScalar(sqlType));

            //判断是否查询异常
            if (sum != -1 && type != -1)
            {
                //显示图书总计
                this.lblBookSum.Text = string.Format("共{0}册{1}种", sum.ToString(), type.ToString());
            }
        }
        #endregion

        #region 读者共计
        /// <summary>
        /// 读者共计
        /// </summary>
        public void ReaderSUM()
        {
            //查询读者数量
            string sql = @"select count(*) from reader";

            //执行
            int iRet = Convert.ToInt32(DBHelper.ExecuteScalar(sql));

            if (iRet != -1)
            {
                this.lblReaderSum.Text = iRet.ToString() + "人";
            }
        }
        #endregion

        #region 逾期共计
        /// <summary>
        /// 逾期共计
        /// </summary>
        public void OverdueSUM()
        {
            //SQL语句查询逾期图书数
            string sql = @"select count(*) from borrow where DateDiff(day,ReturnDate,GETDATE()) > 0 and GiveBackDate is null;";
            //sql查询逾期人数
            string sql2 = @"select count(*) from Reader where ReaderID in
                        (select ReaderID from Borrow where DateDiff(day,ReturnDate,GETDATE()) > 0 and GiveBackDate is null group by ReaderID);;";

            //执行
            int books = Convert.ToInt32(DBHelper.ExecuteScalar(sql));//逾期图书数
            int readers = Convert.ToInt32(DBHelper.ExecuteScalar(sql2));//逾期人数

            //判断是否查询异常
            if (books != -1 && readers != -1)
            {
                this.lblOverdueSum.Text = books.ToString() + "册" + readers.ToString() + "人";
            }
        }
        #endregion

        #region 查看图书
        /// <summary>
        /// 查看图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiBook_Click(object sender, EventArgs e)
        {
            //显示FrmBooksInfo
            FrmBooksInfo frmBooksInfo = new FrmBooksInfo();

            frmBooksInfo.ShowDialog();

            //显示登录用户名
            this.lblUser.Text = StaticStore.loginName;
        }
        #endregion

        #region 显示主面板spMain
        /// <summary>
        /// 隐藏ShortView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiShortViewHide_Click(object sender, EventArgs e)
        {
            this.scMain.Visible = true;
        }
        #endregion

        #region 重新登录
        /// <summary>
        /// 重新登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (StaticStore.IsLogin)
            {
                //退出当前登录
                StaticStore.IsLogin = false;

                //更改显示当前登录用户
                StaticStore.loginName = "尚未登录";
                this.lblUser.Text = StaticStore.loginName;

                MessageBox.Show("已退出登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //隐藏
                this.Hidden();
            }
            //进行登录操作,此时如果未进行登录操作，同时也进行登录操作
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            //重新显示登录用户
            this.lblUser.Text = StaticStore.loginName;

            //隐藏
            this.Hidden();
        }
        #endregion

        #region 图书信息管理
        /// <summary>
        /// 图书信息管理，为管理员权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBookInfo_Click(object sender, EventArgs e)
        {
            //图书信息管理操作
            this.BookInfoManage();
            //更新主页
            this.BookSUM();

        }
        #endregion

        #region 图书信息管理操作
        /// <summary>
        /// 根据登录类型，执行图书信息管理操作
        /// </summary>
        private void BookInfoManage()
        {
            //实例化登录窗体对象
            FrmLogin frmLogin = new FrmLogin();

            //是否登录账号
            if (StaticStore.IsLogin)
            {
                //判断登录类型,是否为管理员登录
                if (StaticStore.loginType)
                {
                    //显示图书信息管理窗口
                    FrmBookInfoManager frmBookInfoManager = new FrmBookInfoManager();
                    frmBookInfoManager.ShowDialog();
                }
                else
                {
                    MessageBox.Show(CONTENT, HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("您尚未进行登录，请登录！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //进行登录操作

                frmLogin.ShowDialog();

                //显示登录用户
                this.lblUser.Text = StaticStore.loginName;
            }
        }
        #endregion

        #region 读者信息管理
        /// <summary>
        /// 读者信息管理操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsReader_Click(object sender, EventArgs e)
        {
            //实例化登录窗体对象
            FrmLogin frmLogin = new FrmLogin();

            //是否登录账号
            if (StaticStore.IsLogin)
            {
                //判断登录类型,是否为管理员登录
                if (StaticStore.loginType)
                {
                    //显示读者信息管理窗口
                    FrmManageReader frmManagerReader = new FrmManageReader();
                    frmManagerReader.ShowDialog();
                }

                //读者身份登录
                if (StaticStore.loginType == false)
                {
                    FrmReaderMain frmReaderMain = new FrmReaderMain();
                    frmReaderMain.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("您尚未进行登录，请登录！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //进行登录操作

                frmLogin.ShowDialog();

                //显示登录用户
                this.lblUser.Text = StaticStore.loginName;
            }

            //更新主页
            this.ReaderSUM();
        }
        #endregion

        #region 逾期记录查询
        /// <summary>
        /// 逾期记录查询操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsOverdue_Click(object sender, EventArgs e)
        {
            //实例化登录窗体对象
            FrmLogin frmLogin = new FrmLogin();

            //是否登录账号
            if (StaticStore.IsLogin)
            {
                //判断登录类型,是否为管理员登录
                if (StaticStore.loginType)
                {
                    //显示逾期记录查询窗口
                    FrmOverdue frmOverdue = new FrmOverdue();
                    frmOverdue.ShowDialog();
                }
                else
                {
                    MessageBox.Show(CONTENT, HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("您尚未进行登录，请登录！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //进行登录操作

                frmLogin.ShowDialog();

                //显示登录用户
                this.lblUser.Text = StaticStore.loginName;
            }

            //更新主页
            this.OverdueSUM();
        }
        #endregion

        #region 借书还书续借
        /// <summary>
        /// 借书还书续借
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBorrow_Click(object sender, EventArgs e)
        {
            //实例化登录窗体对象
            FrmLogin frmLogin = new FrmLogin();

            //是否登录账号
            if (StaticStore.IsLogin)
            {
                //读者身份登录
                if (StaticStore.loginType == false)
                {
                    FrmBorrowAndReturn frmBorrowAndReturn = new FrmBorrowAndReturn();
                    frmBorrowAndReturn.ShowDialog();
                }
                else
                {
                    MessageBox.Show("您尚未以读者身份登录，请登录！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    frmLogin.ShowDialog();

                    //显示登录用户
                    this.lblUser.Text = StaticStore.loginName;

                    //隐藏按钮
                    this.Hidden();
                }
            }
            else
            {
                MessageBox.Show("您尚未进行登录，请登录！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //进行登录操作

                frmLogin.ShowDialog();

                //显示登录用户
                this.lblUser.Text = StaticStore.loginName;
            }

            //更新主页
            this.OverdueSUM();
        }
        #endregion

        #region 借阅记录查询
        /// <summary>
        /// 借阅记录查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBorrowRecord_Click(object sender, EventArgs e)
        {
            //实例化登录窗体对象
            FrmLogin frmLogin = new FrmLogin();

            //是否登录账号
            if (StaticStore.IsLogin)
            {
                //判断登录类型,是否为管理员登录
                if (StaticStore.loginType)
                {
                    //显示管理员借阅记录查询窗口
                    FrmBorrowRecord frmBorrowRecord = new FrmBorrowRecord();
                    frmBorrowRecord.ShowDialog();
                }
                else//读者登录
                {
                    //显示读者借阅记录查询窗口
                    //FrmReaderMain frmreaderMain = new FrmReaderMain();
                    //this.ShowInTaskbar = false;
                    //frmreaderMain.ShowDialog();
                    FrmBorrowRecord frmBorrowRecord = new FrmBorrowRecord();
                    frmBorrowRecord.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("您尚未进行登录，请登录！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //进行登录操作

                frmLogin.ShowDialog();

                //显示登录用户
                this.lblUser.Text = StaticStore.loginName;
            }

            //更新主页
            this.OverdueSUM();
        }
        #endregion

        #region 借阅记录统计
        /// <summary>
        /// 显示借阅记录统计窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsStatistics_Click(object sender, EventArgs e)
        {
            //是否登录账号
            if (StaticStore.IsLogin)
            {
                //判断登录类型,是否为管理员登录
                if (StaticStore.loginType)
                {
                    //显示借阅记录统计窗口
                    FrmBorrowStatistics frmBorrowStatistics = new FrmBorrowStatistics();
                    frmBorrowStatistics.ShowDialog();
                }
                else//读者登录
                {
                    MessageBox.Show("您尚未有此权限！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("您尚未进行登录，请登录！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
        }
        #endregion

        #region 快速注册
        /// <summary>
        /// 快速注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRegister_Click(object sender, EventArgs e)
        {
            FrmReaderAdd frmReaderAdd = new FrmReaderAdd();
            frmReaderAdd.ShowDialog();
        }
        #endregion

        #region 借阅规章制度
        /// <summary>
        /// 借阅规章制度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsRule_Click(object sender, EventArgs e)
        {
            FrmManage manage = new FrmManage();
            manage.ShowDialog();
        }
        #endregion

        #region 关于我们
        /// <summary>
        /// 关于我们
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FrmAboutUs about = new FrmAboutUs();
            about.ShowDialog();
        }
        #endregion

        #region 图书统计表
        /// <summary>
        /// 图书统计表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBookClass_Click(object sender, EventArgs e)
        {
            //是否登录账号
            if (StaticStore.IsLogin)
            {
                //判断登录类型,是否为管理员登录
                if (StaticStore.loginType)
                {
                    //显示管理员图书统计表窗口
                    FrmChart chart = new FrmChart();
                    chart.ShowDialog();
                }
                else//读者登录
                {
                    MessageBox.Show("您尚未有此权限！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("您尚未进行登录，请登录！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        #region 文献
        /// <summary>
        /// 文献
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPhiloloy_Click(object sender, EventArgs e)
        {
            FrmPhiloloy philoloy = new FrmPhiloloy();
            philoloy.ShowDialog();
        }
        #endregion

        #region 推荐
        /// <summary>
        /// 推荐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRecommend_Click(object sender, EventArgs e)
        {
            FrmRecommend recommend = new FrmRecommend();
            recommend.ShowDialog();
        }
        #endregion

        #region 排行榜
        /// <summary>
        /// 排行榜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPush_Click(object sender, EventArgs e)
        {
            //排行榜窗口
            FrmRanking ranking = new FrmRanking();
            ranking.ShowDialog();
        }
        #endregion

        #region 管理员修改信息
        /// <summary>
        /// 管理员修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            FrmAmend Amend = new FrmAmend();
            Amend.Show();
        }
        #endregion

        #region 添加管理员
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FrmAddition Addition = new FrmAddition();
            Addition.Show();
        }
        #endregion

        #region 新书上架
        private void tsbNewBook_Click(object sender, EventArgs e)
        {
            FrmBookputaway bookputaway = new FrmBookputaway();
            bookputaway.ShowDialog();
        }
        #endregion
    }
}