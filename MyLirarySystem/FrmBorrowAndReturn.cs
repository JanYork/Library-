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
    /// 借书还书续借
    /// </summary>
    public partial class FrmBorrowAndReturn : MetroForm
    {
        public FrmBorrowAndReturn()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        //创建数据集
        DataSet ds = new DataSet();
        //适配器
        SqlDataAdapter adapter;
        //动态数据视图
        DataView dv;

        #region 返回首页
        /// <summary>
        /// 返回首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBackMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 绑定数据
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void BindBook()
        {
            //查询可借图书信息语句
            string sql = @"select BookID,BookName,Author,Press,Words,BookType,ClassName,Price,State 
                        from Books,Book,BookType,BookClass,BookState 
                        where Books.ID = Book.ID and Book.BookTypeID = BookType.BookTypeID 
                        and Book.ClassID = BookClass.ClassID and BookState.StateID = Books.StateID
                        and Books.StateID = " + Convert.ToInt32(BookState.可借);

            try
            {
                //填充数据
                this.adapter = new SqlDataAdapter(sql, DBHelper.Connection);

                //将数据填充到数据集中的 BookInfo 表中
                this.adapter.Fill(this.ds, "BookInfo");

                //绑定数据源
                this.dgvBookInfo.DataSource = this.ds.Tables["BookInfo"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBorrowAndReturn_Load(object sender, EventArgs e)
        {
            //绑定图书数据
            this.BindBook();
        }
        #endregion

        #region 查找图书
        /// <summary>
        /// 查找图书
        /// </summary>
        public void SearchBook()
        {
            //获取文本框的内容
            string search = this.txtSearch.Text.Trim().ToString();

            /*
             *支持模糊查询
             *图书基本类、图书具体类、图书名称、作者、出版社
             */
            string rowFilter = string.Format(@"ClassName like '%{0}%' or BookType like '%{0}%' or 
                             BookName like '%{0}%' or Author like '%{0}%' or Press like '%{0}%'"
                            , search);

            //添加动态视图
            this.dv = this.ds.Tables["BookInfo"].DefaultView;

            //条件筛选
            dv.RowFilter = rowFilter;

            //绑定数据源
            this.dgvBookInfo.DataSource = dv;
        }
        #endregion

        #region 查找
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //根据输入框输入的关键词搜索
            this.SearchBook();

            //判断是否为空
            if (this.dgvBookInfo.RowCount <= 0)
            {
                this.txtSearch.Clear();
                this.txtSearch.Focus();
                MessageBox.Show("未查询到相关书籍！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        #endregion

        #region 通过节点设置筛选条件
        /// <summary>
        /// 根据不同的节点筛选图书
        /// </summary>
        public void Filter()
        {
            //筛选条件
            string rowFilter = string.Empty;

            //判断节点选择的深度
            if (this.tvLibrary.SelectedNode.Level == 1)
            {
                rowFilter = string.Format("ClassName = '{0}' ", this.tvLibrary.SelectedNode.Text.ToString());
            }
            else if (this.tvLibrary.SelectedNode.Level == 2)
            {
                rowFilter = string.Format("ClassName = '{0}' and BookType = '{1}'"
                    , this.tvLibrary.SelectedNode.Parent.Text.ToString(), this.tvLibrary.SelectedNode.Text.ToString());
            }

            //创建动态视图
            this.dv = this.ds.Tables["BookInfo"].DefaultView;
            this.dv.RowFilter = rowFilter.ToString();

            //绑定数据
            this.dgvBookInfo.DataSource = this.dv;
        }
        #endregion

        #region 通过节点筛选
        /// <summary>
        /// 通过节点筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvLibrary_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //根据不同的节点筛选图书
            this.Filter();

            //判断是否为空
            if (this.dgvBookInfo.RowCount <= 0)
            {
                MessageBox.Show("未查询到相关书籍！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 借书
        /// <summary>
        /// 借书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrow_Click(object sender, EventArgs e)
        {
            //FrmReaderMain frmReaderMian = new FrmReaderMain();
            //this.Close();
            //this.ShowInTaskbar = false;
            //frmReaderMian.ShowDialog();
            FrmBorrowBooks frmBorrowBooks = new FrmBorrowBooks();
            //向窗体FrmBorrowBooks 传递bookID 和bookName
            frmBorrowBooks.bookID = this.dgvBookInfo.SelectedCells[0].Value.ToString();
            frmBorrowBooks.bookName = this.dgvBookInfo.SelectedCells[1].Value.ToString();
            frmBorrowBooks.ShowDialog();

            //刷新数据
            if (this.ds.Tables["BookInfo"] != null)
            {
                //清空数据集中表BookInfo中的数据
                this.ds.Tables["BookInfo"].Clear();
            }
            //从新绑定数据源
            this.BindBook();
        }
        #endregion
    }
}
