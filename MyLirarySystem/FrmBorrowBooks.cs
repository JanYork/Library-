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
    /// 借书
    /// </summary>
    public partial class FrmBorrowBooks : MetroForm
    {
        public FrmBorrowBooks()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        //获取图书编号和名称
        public string bookID = string.Empty;
        public string bookName = string.Empty;

        #region 读者身份登录，查询图书信息，给到借书窗口
        /// <summary>
        /// 查询图书信息，给到借书窗口
        /// </summary>
        public void BookInfo()
        {
            String sql = string.Format(@"select ReaderName from Reader where ReaderID = '{0}'", Convert.ToString(StaticStore.readerID));

            string readerName =  DBHelper.ExecuteScalar(sql).ToString();

            if (!readerName.Equals("-1"))
            {
                    this.txtReaderID.Text = StaticStore.readerID;
                    this.txtReaderName.Text = readerName;
                    this.txtBookName.Text = this.bookName;
                    this.txtBookID.Text = this.bookID;
                    this.txtBorrowDate.Text = DateTime.Now.ToString();
                    this.txtReturnDate.Text = DateTime.Now.AddDays(60).ToString();
            }
        }
        #endregion

        #region 判断读者ID是否为空
        /// <summary>
        /// 判断读者ID是否为空,该操作只有管理员登录时需要
        /// </summary>
        /// <returns></returns>
        public bool IsNull()
        { 
            if(this.txtReaderID.Text.Trim().ToString().Equals(string.Empty))
            {
                this.txtReaderID.Focus();
                MessageBox.Show("请输入读者卡号！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        #endregion

        #region 管理员借书
        /// <summary>
        /// 通过管理员借书
        /// </summary>
        public void BookInfoByManager()
        {
            //需要手动输入读者卡号
            this.txtReaderID.ReadOnly = false;
            
            //显示借阅信息
            this.txtBookName.Text = this.bookName;
            this.txtBookID.Text = this.bookID;
            this.txtBorrowDate.Text = DateTime.Now.ToString();
            this.txtReturnDate.Text = DateTime.Now.AddDays(60).ToString();
        }
        #endregion

        #region 窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BorrowBook_Load(object sender, EventArgs e)
        {
            //判断登录类型
            if (StaticStore.loginType)
            {
                //管理员
                this.BookInfoByManager();
            }
            else
            {
                //查询图书信息，给到续借窗口
                this.BookInfo();
            }
        }
        #endregion

        #region 取消
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 借书操作
        /// <summary>
        /// 借书操作
        /// </summary>
        /// <returns></returns>
        public bool BorrowBooks()
        {
            bool valid = false;

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(@"insert into Borrow(BookID,ReaderID,BorrowDate,ReturnDate) values({0},'{1}','{2}','{3}');",
                        Convert.ToInt32(this.bookID),this.txtReaderID.Text.ToString(),this.txtBorrowDate.Text.ToString(),
                        this.txtReturnDate.Text.ToString());
            //执行
            if(DBHelper.ExecuteNonQuery(sb.ToString()) == 1)
            {
                sb.Length = 0;
                //更新图书状态
                sb.AppendFormat(@"update Books set StateID = {0} where BookID = {1}",Convert.ToInt32(BookState.已借),Convert.ToInt32(this.bookID));
                //执行
                if(DBHelper.ExecuteNonQuery(sb.ToString()) == 1)
                {
                    sb.Length = 0;
                    sb.AppendFormat(@"update Reader set BorrowBook = BorrowBook - 1,ReturnBook = ReturnBook + 1 where ReaderID = '{0}';",this.txtReaderID.Text.ToString());
                    if(DBHelper.ExecuteNonQuery(sb.ToString()) == 1)
                    {
                        valid = true;
                    }
                }
            }

            return valid;
        }
        #endregion

        #region 借书
        /// <summary>
        /// 借书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            //判读读者卡号是否为空
            if(this.IsNull())
            {
                string message = "借书失败！";
                if (this.BorrowBooks())
                {
                    message = "借书成功！";
                    MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 查询数据库是否存在读者信息
        /// <summary>
        /// 查询数据库是否存在读者信息
        /// </summary>
        /// <returns></returns>
        public bool ReaderNameByReaderID()
        {
            bool valid = false;

            string sql = string.Format(@"select readerName from Reader where ReaderID = '{0}'",Convert.ToString(this.txtReaderID.Text));

            //执行
            SqlDataReader reader = DBHelper.ExecuteReader(sql);

            //判断是否存在数据
            if (reader != null)
            {
                //读取
                if (reader.Read())
                {
                    this.txtReaderName.Text = reader[0].ToString();
                    valid = true;
                }
            }

            //关闭对象
            reader.Close();
            return valid;
        }
        #endregion

        #region 通过读者卡号获取读者姓名
        /// <summary>
        /// 通过读者卡号获取读者姓名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtReaderID_Leave(object sender, EventArgs e)
        {
            //判断是否为管理员登录
            if(StaticStore.loginType)
            {
                //判断是否为空
                if(this.IsNull())
                {
                    //判断是否存在读者
                    if (!this.ReaderNameByReaderID())
                    {
                        MessageBox.Show("尚未查询到有关该读者信息记录！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.txtReaderID.Clear();
                        this.txtReaderID.Focus();
                    }
                }
            }
        }
        #endregion
    }
}
