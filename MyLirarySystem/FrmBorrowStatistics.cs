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
    /// 借阅记录统计窗体
    /// </summary>
    public partial class FrmBorrowStatistics : MetroForm
    {
        public FrmBorrowStatistics()
        {
            InitializeComponent();
            ////this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBorrowStatistics_Load(object sender, EventArgs e)
        {
            //借阅总人数
            this.ShowSum();

            //借阅图书总册
            this.BookSUM();

            //再借人数汇总
            this.ReaderSUM();

            //逾期人数
            this.OverdueSUM();
        }


        #region 借阅总人数
        /// <summary>
        /// 借阅总人数
        /// </summary>
        public void ShowSum()
        {
            //sql语句
            //借阅总人数
            string sqlSum = @"select COUNT(*) from Reader where ReaderID in (select ReaderID from Borrow)";


            //执行
            int sum = Convert.ToInt32(DBHelper.ExecuteScalar(sqlSum));


            if (sum != -1)
            {
                //显示图书总计
                this.lblCountSum.Text = string.Format("共{0}人", sum.ToString());
            }
        }
        #endregion

        #region 借阅图书总册
        /// <summary>
        /// 借阅图书总册
        /// </summary>
        public void BookSUM()
        {
            //sql语句
            //借阅图书总册
            string sqlSum = @"select COUNT(*) from Borrow";

            //执行
            int sum = Convert.ToInt32(DBHelper.ExecuteScalar(sqlSum));

            if (sum != -1)
            {
                //显示图书总计
                this.lblSumBooks.Text = string.Format("共{0}次", sum.ToString());
            }
        }
        #endregion

        #region 再借人数汇总
        /// <summary>
        /// 再借人数汇总
        /// </summary>
        public void ReaderSUM()
        {
            //再借人数汇总
            string sql = @"select count(*) from reader";

            //执行
            int iRet = Convert.ToInt32(DBHelper.ExecuteScalar(sql));

            if (iRet != -1)
            {
                this.lblSumShu.Text = iRet.ToString() + "人";
            }
        }
        #endregion

        #region 逾期人数
        /// <summary>
        /// 逾期人数
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

            if (books != -1 && readers != -1)
            {
                this.lblShu.Text = books.ToString() + "册" + readers.ToString() + "人";
            }
        }
        #endregion

        private void btnBorOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
