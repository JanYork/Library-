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
    public partial class FrmBookputaway : MetroForm
    {
        public FrmBookputaway()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//CalmnessColor2.ssk";
        }
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;

        #region 窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBookputaway_Load(object sender, EventArgs e)
        {
            BindBook();
        }
        #endregion

        #region 数据绑定
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void BindBook()
        {
            //查询图书信息语句
            string sql = @"select top 30 BookID,BookName,Author,Press,Words,BookType,ClassName,Price,State,Time 
                        from Books,Book,BookType,BookClass,BookState 
                        where Books.ID = Book.ID and Book.BookTypeID = BookType.BookTypeID 
                        and Book.ClassID = BookClass.ClassID and BookState.StateID = Books.StateID
                        order by Book.Time desc;";

            try
            {
                //填充数据
                this.adapter = new SqlDataAdapter(sql, DBHelper.Connection);

                //将数据填充到数据集中的 BookInfo 表中
                this.adapter.Fill(this.ds, "BookInfo");
                DataView dv = new DataView(ds.Tables["BookInfo"]);
                dv.Sort = "Time desc";

                //绑定数据源
                this.dgvBookInfo.DataSource = dv;

            }
            catch (Exception ex)
            {
                MessageBox.Show("错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        #region 返回关闭窗口
        /// <summary>
        /// 返回关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
