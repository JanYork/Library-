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
    public partial class FrmRecommend : MetroForm
    {
        public FrmRecommend()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ////this.skinEngine1.SkinFile = Application.StartupPath + "//CalmnessColor2.ssk";
        }

        /// <summary>
        /// 图书推荐窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRecommend_Load(object sender, EventArgs e)
        {
            ShowRecommend();
        }

        /// <summary>
        /// 推荐显示图书
        /// </summary>
        public void ShowRecommend()
        {
            //sql语句
            string sql = string.Format(@"select Book.BookName,Book.Author,Book.Press,BookType.BookType from Book
                         inner join BookClass on BookClass.ClassID = Book.ClassID
                         inner join BookType on Book.BookTypeID = BookType.BookTypeID
                         inner join Books on Book.ID = Books.ID
                         where BookID
                         in (select top 5 BookID from Borrow group by BookID order by count(BookID) desc)");

            try
            {
                DBHelper.ConnectionOpen();
                //发送SQL命令 object类型
                SqlCommand comm = new SqlCommand(sql, DBHelper.Connection);
                SqlDataReader dr = comm.ExecuteReader();
                if (this.lvCha.Items.Count > 0)
                {
                    this.lvCha.Items.Clear();
                }
                while (dr.Read())
                {

                    ListViewItem li = new ListViewItem();
                    li.Text = dr[0].ToString();
                    li.SubItems.Add(dr[1].ToString());
                    li.SubItems.Add(dr[2].ToString());
                    li.SubItems.Add(dr[3].ToString());


                    this.lvCha.Items.Add(li);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.ConnectionClose();
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
