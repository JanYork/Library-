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
    /// 图书预定窗体
    /// </summary>
    public partial class FrmAdvance : MetroForm
    {
        public string bookID = string.Empty;
        public string bookName = string.Empty;      
        public FrmAdvance()
        {
           
            InitializeComponent();          
        }

        #region 查询图书信息，给到预定窗口
        /// <summary>
        /// 查询图书信息，给到预定窗口
        /// </summary>
        public void Showyj()
        {
            //编写SQL语句，进行查询操作
            string sql = string.Format(@"select ReaderName from Reader where ReaderID = {0}", StaticStore.readerID);           
            string readerName =  DBHelper.ExecuteScalar(sql).ToString();
            if (!readerName.Equals("-1"))
            {                  
                    this.txtReaderID.Text = StaticStore.readerID;
                    this.txtReaderName.Text = readerName;                   
                    this.txtBookName.Text = this.bookName;                    
                    this.txtBookID.Text = this.bookID;                  
                    this.txtydrq.Text = DateTime.Now.ToString();
            }
        }
        #endregion

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdvance_Load(object sender, EventArgs e)
        {
            Showyj();
        }
        #endregion

        #region 预借操作
        /// <summary>
        /// 预借操作
        /// </summary>
        /// <returns></returns>
        public bool BorrowBooks()
        {
            bool valid = false;

            StringBuilder sb = new StringBuilder();
            //编写SQL语句，进行添加操作
            sb.AppendFormat(@"insert into Reserve(BookID,ReaderID,RDate) values('{0}','{1}',GETDATE())",
                        Convert.ToInt32(this.bookID), Convert.ToInt32(StaticStore.readerID));
            //进行增删改查使用ExecuteNonQuery（）方法
            int i = DBHelper.ExecuteNonQuery(sb.ToString());
            //执行
                if (i == 1)
                {
                    sb.Length = 0;
                    sb.AppendFormat(@"update Books set StateID = {0} where BookID = {1}", Convert.ToInt32(BookState.已预订), Convert.ToInt32(this.bookID));
                    if (DBHelper.ExecuteNonQuery(sb.ToString()) == 1)
                    {
                        sb.Length = 0;
                        sb.AppendFormat(@"update Reader set BorrowBook = BorrowBook - 1,ReturnBook = ReturnBook + 1 where ReaderID = {0};", Convert.ToInt32(StaticStore.readerID));
                        if (DBHelper.ExecuteNonQuery(sb.ToString()) == 1)
                        {                       
                            valid = true;
                        }
                    }
                
            }
            return valid;
        }
        #endregion

        #region 预定
        /// <summary>
        /// 预定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnyj_Click(object sender, EventArgs e)
        {
            if (BorrowBooks())
            {
                MessageBox.Show("预定成功！");
            }
            else
            {
                MessageBox.Show("预定失败！");
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

        
    }
}
