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
    /// 图书报价窗体
    /// </summary>
    public partial class FrmOffer : MetroForm
    {
        public FrmOffer()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }
        /// <summary>
        /// 图书报价加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOffer_Load(object sender, EventArgs e)
        {
            this.txtBookID.Text = bookId.ToString();
            ShowOffer();
        }

        public int bookId = 0;//图书编号

        /// <summary>
        /// 查询书本信息
        /// </summary>
        public void ShowOffer()
        {
            //编写SQL语句
            string sql = string.Format(@"select BookID,BookName,Author,Press,BookType,Price 
                        from Books,Book,BookType where Books.ID = Book.ID 
                        and Book.BookTypeID = BookType.BookTypeID 
                        and Books.BookID={0} ", bookId);
            //执行SQL语句
            SqlDataReader reader = DBHelper.ExecuteReader(sql);
            if (reader.Read())
            {
                this.txtBookName.Text = reader["BookName"].ToString();
                this.txtAuthor.Text = reader["Author"].ToString();
                this.txtPress.Text = reader["Press"].ToString();
                this.txtBookType.Text = reader["BookType"].ToString();
                this.txtPrice.Text = reader["Price"].ToString();

            }
            //关闭读取
            reader.Close();
        }

        /// <summary>
        /// 确定按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
