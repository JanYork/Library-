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
    /// 续借
    /// </summary>
    public partial class FrmRenew : MetroForm
    {
        public FrmRenew()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        //创建数据集，数据适配器
        DataSet ds = new DataSet();
        SqlDataAdapter dap = null;

        //图书编号
        public string bookID;

        #region 查询图书信息，给到续借窗口
        /// <summary>
        /// 查询图书信息，给到续借窗口
        /// </summary>
        public void BookInfo()
        {
            //查询续借书籍信息
            String sql = string.Format(@"select Reader.ReaderID,ReaderName,Books.BookID,Book.BookName,BorrowDate,ReturnDate,DATEADD(day,20,ReturnDate)
                                        from Reader,Books,Book,Borrow where Reader.ReaderID = Borrow.ReaderID 
                                        and Book.ID = Books.ID and Borrow.BookID = Books.BookID and Books.BookID = {0} and GiveBackDate is null", Convert.ToInt32(this.bookID));

            SqlDataReader reader = DBHelper.ExecuteReader(sql);

            if (reader != null)
            {
                if (reader.Read())
                {
                    this.txtReaderID.Text = reader["ReaderID"].ToString();
                    this.txtReaderName.Text = reader["ReaderName"].ToString();
                    this.txtBookName.Text = reader["BookName"].ToString();
                    this.txtBookID.Text = reader["BookID"].ToString();
                    this.txtBorrowDate.Text = reader["BorrowDate"].ToString();
                    this.txtReturnDate.Text = reader["ReturnDate"].ToString();
                    this.txtRenewDate.Text = reader[6].ToString();
                }
                else
                {
                    MessageBox.Show("书籍不可续借！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

            reader.Close();
        }
        #endregion

        #region 续借
        /// <summary>
        /// 续借
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool RenewBook()
        {
            bool valid = false;

            //更新续借日期，并且根据归还日期为空，图书卡号，读者ID号 ，
            string sql = string.Format(@"update Borrow set ReturnDate = '{0}' where BookID = {1} and ReaderID = {2} and GiveBackDate is null;"
                ,this.txtRenewDate.Text.ToString(),this.bookID,Convert.ToInt32(this.txtReaderID.Text));

            int iRet = DBHelper.ExecuteNonQuery(sql);

            if(iRet == 1)
            {
                valid = true;
            }
            return valid;
        }
        #endregion

        #region 窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRenew_Load_1(object sender, EventArgs e)
        {
            //查询图书信息，给到续借窗口
            this.BookInfo();
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
            this.bookID = string.Empty;
        }
        #endregion

        #region 判断是否符合续借条件
        /// <summary>
        /// 判断是否符合续借条件
        /// </summary>
        /// <returns></returns>
        public bool IsRenew()
        {
            //默认不可续借
            bool valid = false;

            //查询归还日期为空，并且根据图书卡号，读者ID号 ，应还和借阅日期之差小于 80 天可续借，
            string sql = string.Format(@"select count(*) from Borrow where DATEDIFF(day,BorrowDate,ReturnDate) < 80 and BookID = {0} and ReaderID = {1} and GiveBackDate is null;",
                this.bookID, Convert.ToString(this.txtReaderID.Text.ToString()));

            //执行
            if(Convert.ToInt32(DBHelper.ExecuteScalar(sql)) == 1)
            {
                //可续借
                valid = true;
            }

            return valid;
        }
        #endregion

        #region 续借按钮
        /// <summary>
        /// 续借按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRenew_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            //判断是否符合续借条件
            if (this.IsRenew())
            {
                message = "续借失败！";
                if (this.RenewBook())
                {
                    message = "续借成功！";
                }
            }
            else
            {
                message = "续借次数已用尽！";
            }
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion
    }
}
