using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;

namespace MyLirarySystem
{
    /// <summary>
    /// 借阅记录查询
    /// </summary>
    public partial class FrmBorrowRecord : MetroForm
    {
        public FrmBorrowRecord()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        //创建数据集、适配器
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;

        //从读者管理窗口接收读者卡号，查询读者借阅信息
        public string readerId = string.Empty;

        #region 管理员查询读者借阅记录数据绑定
        /// <summary>
        /// 借阅记录数据绑定
        /// </summary>
        public void BindBorrowInfo()
        {
            //查询所有借阅记录
            string sql = @"select Borrow.ReaderID,Reader.ReaderName,Book.BookName,Books.BookID,BorrowDate,GiveBackDate,ReturnDate 
                        from Borrow,Reader,Book,Books
                        where Borrow.BookID = Books.BookID 
                        and Borrow.ReaderID = Reader.ReaderID 
                        and Book.ID = Books.ID";

            //判断读者卡号是否为空
            if (!this.readerId.Equals(string.Empty))
            {
                this.txtReaderID.Text = readerId.ToString();

                sql = sql + string.Format(" and Borrow.ReaderID = '{0}'", readerId.ToString());
            }

            //填充数据
            this.adapter = new SqlDataAdapter(sql, DBHelper.Connection);

            //将数据填充到数据集 表 Borrow中
            this.adapter.Fill(this.ds, "Borrow");

            //绑定数据源
            this.dgvBorrow.DataSource = this.ds.Tables["Borrow"];
        }
        #endregion

        #region 读者身份,查看读者借阅记录
        /// <summary>
        /// 读者身份,查看读者借阅记录
        /// </summary>
        public void BindLoginByReader()
        {
            //按读者卡号查询借阅记录
            string sql = string.Format(@"select Borrow.ReaderID,Reader.ReaderName,Book.BookName,Books.BookID,BorrowDate,GiveBackDate,ReturnDate  
                        from Borrow,Reader,Book,Books
                        where Borrow.BookID = Books.BookID 
                        and Borrow.ReaderID = Reader.ReaderID 
                        and Book.ID = Books.ID and Borrow.ReaderID = '{0}';",StaticStore.readerID);

            adapter = new SqlDataAdapter(sql,DBHelper.Connection);
            adapter.Fill(ds,"BorrowByReader");

            //绑定数据
            this.dgvBorrow.DataSource = this.ds.Tables["BorrowByReader"];
        }
        #endregion

        #region 窗口加载事件
        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBorrowRecord_Load(object sender, EventArgs e)
        {
            //判断登录类型
            if (StaticStore.loginType)
            {
                //管理员
                //绑定数据源，显示所有借阅记录
                this.BindBorrowInfo();
            }
            else
            { 
                //隐藏按钮
                this.lblReaderID.Visible = false;
                this.txtReaderID.Visible = false;
                this.btnSearch.Visible = false;
                this.tsbAll.Visible = false;
                this.tsmiLookAll.Visible = false;

                //读者借阅信息数据绑定
                this.BindLoginByReader();
            }
        }
        #endregion

        #region 查询操作
        /// <summary>
        /// 根据读者卡号，执行查询操作
        /// </summary>
        public void SearchBorrowInfo()
        {
            //按读者卡号查询借阅记录
            string sql = string.Format(@"select Borrow.ReaderID,Reader.ReaderName,Book.BookName,Books.BookID,BorrowDate,GiveBackDate,ReturnDate 
                        from Borrow,Reader,Book,Books
                        where Borrow.BookID = Books.BookID 
                        and Borrow.ReaderID = Reader.ReaderID 
                        and Book.ID = Books.ID and Borrow.ReaderID like '%{0}%'
                        order by ReturnDate", this.txtReaderID.Text.Trim());

            //判断数据表中是否有数据
            if (this.ds.Tables["Borrow"] != null)
            {
                this.ds.Tables["Borrow"].Clear();
            }

            //填充数据
            this.adapter = new SqlDataAdapter(sql, DBHelper.Connection);

            //填充到 数据表中
            this.adapter.Fill(this.ds, "Borrow");

            //绑定数据源
            this.dgvBorrow.DataSource = this.ds.Tables["Borrow"];
        }
        #endregion

        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //按读者卡号查询
            this.SearchBorrowInfo();

            //判断是否为空
            if (this.dgvBorrow.RowCount <= 0)
            {
                this.txtReaderID.Clear();
                this.txtReaderID.Focus();
                MessageBox.Show("未查询到相关读者借阅记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 查看全部
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAll_Click(object sender, EventArgs e)
        {
            //清空搜索框的内容，并且将接收的读者卡号设置为空
            this.txtReaderID.Clear();
            this.readerId = string.Empty;

            //判断数据表中是否有数据
            if (this.ds.Tables["Borrow"] != null)
            {
                this.ds.Tables["Borrow"].Clear();
            }

            //重新绑定数据源
            this.BindBorrowInfo();

            //清空查询文本框
            this.txtReaderID.Clear();
            this.Focus();
        }
        #endregion

        #region 返回
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBackMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 点击查询文本框，清空文本框内容
        /// <summary>
        /// 点击查询文本框，清空文本框内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtReaderID_Click(object sender, EventArgs e)
        {
            this.txtReaderID.Clear();
        }
        #endregion

        #region 续借
        /// <summary>
        /// 续借
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRenew_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (this.dgvBorrow.RowCount <= 0)
            {
                MessageBox.Show("请选择相关读者进行操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //显示续借窗口
            FrmRenew frmRenew = new FrmRenew();
            //传递续借图书编号
            frmRenew.bookID = this.dgvBorrow.SelectedCells[3].Value.ToString();

            //获取图书编号
            string bookID = this.dgvBorrow.SelectedCells[3].Value.ToString();
            string readerID = this.dgvBorrow.SelectedCells[0].Value.ToString();

            //通过判断归还日期是否为空，判断是否可借
            if(this.dgvBorrow.SelectedCells[5].Value.ToString().Equals(string.Empty))
            {
                frmRenew.ShowDialog();
            }
            else
            {
                 MessageBox.Show("书本已归还，不可续借！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            

            //根据登录类型，更新数据
            if (StaticStore.loginType == true)
            {
                //管理员
                if (this.ds.Tables["Borrow"] != null)
                {
                    this.ds.Tables["Borrow"].Clear();
                }
                this.BindBorrowInfo();
            }
            
            if(StaticStore.loginType == false){
                //读者
                if (this.ds.Tables["BorrowByReader"] != null)
                {
                    this.ds.Tables["BorrowByReader"].Clear();
                }
                //读者借阅信息数据绑定
                this.BindLoginByReader();
            }

            ////判断是否符合续借条件
            //string sql = string.Format(@"select count(*) from borrow where bookID = {0} and readerID = {1} and giveBackDate is null"
                        //,Convert.ToInt32(bookID), Convert.ToString(readerID));
            //if (Convert.ToInt32(DBHelper.ExecuteScalar(sql)) == 1)
            //{
            //    frmRenew.ShowDialog();

            //    //根据登录类型，更新数据
            //    if (StaticStore.loginType)
            //    {
            //        //数据更新
            //        if (this.ds.Tables["Borrow"] != null)
            //        {
            //            this.ds.Tables["Borrow"].Clear();
            //        }
            //        this.BindBorrowInfo();
            //    }
            //    else
            //    {
            //        if (this.ds.Tables["BorrowByReader"] != null)
            //        {
            //            this.ds.Tables["BorrowByReader"].Clear();
            //        }
            //        //读者借阅信息数据绑定
            //        this.BindLoginByReader();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("书本已归还，不可续借！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
        }
        #endregion

        #region 还书操作
        /// <summary>
        /// 还书操作
        /// </summary>
        /// <returns></returns>
        public bool BorrowBook()
        {
            //默认还书失败
            bool valid = false;

            //获取图书编号
            string bookID = this.dgvBorrow.SelectedCells[3].Value.ToString();
            string readerID = this.dgvBorrow.SelectedCells[0].Value.ToString();

            //更新语句
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update Borrow set GiveBackDate = GETDATE() where BookID = {0} and readerID = '{1}' and GiveBackDate IS NULL",
                 Convert.ToInt32(bookID), Convert.ToString(readerID));

            //执行
            int iRet = DBHelper.ExecuteNonQuery(sb.ToString());
            if (iRet == 1)
            {
                //更新图书的状态
                sb.Length = 0;
                //更新图书状态
                sb.AppendFormat(@"update Books set StateID = '{0}' where BookID = '{1}'", Convert.ToInt32(BookState.可借), Convert.ToInt32(bookID));

                //执行判断是否成功更新
                if(DBHelper.ExecuteNonQuery(sb.ToString()) == 1)
                {
                    sb.Length = 0;
                    sb.AppendFormat(@"update Reader set BorrowBook = BorrowBook + 1,ReturnBook = ReturnBook -1 where ReaderID = '{0}';", Convert.ToString(readerID));
                    if (DBHelper.ExecuteNonQuery(sb.ToString()) == 1)
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }
        #endregion

        #region 还书
        /// <summary>
        /// 还书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (this.dgvBorrow.RowCount <= 0)
            {
                MessageBox.Show("未选择相关读者进行操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string message = string.Empty;//提示信息

                //给出用户提示
                if(DialogResult.OK == MessageBox.Show("您确定要还书吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
                {
                    //判断是否还书成功
                    if (this.BorrowBook())
                    {
                        message = "还书成功！";
                    }
                    else
                    {
                        message = "还书失败！";
                    }

                    //根据登录类型，更新数据
                    if (StaticStore.loginType == true)
                    {
                        //管理员
                        if (this.ds.Tables["Borrow"] != null)
                        {
                            this.ds.Tables["Borrow"].Clear();
                        }
                        this.BindBorrowInfo();
                    }

                    if (StaticStore.loginType == false)
                    {
                        //读者
                        if (this.ds.Tables["BorrowByReader"] != null)
                        {
                            this.ds.Tables["BorrowByReader"].Clear();
                        }
                        //读者借阅信息数据绑定
                        this.BindLoginByReader();
                    }
                    MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
        }
        #endregion
    }
}
