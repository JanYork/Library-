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
    /// 读者主页面
    /// </summary>
    public partial class FrmReaderMain : MetroForm
    {
        public FrmReaderMain()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        //创建数据集
        DataSet ds = new DataSet();
        //适配器
        SqlDataAdapter adapter;
        //创建动态视图
        DataView dv;

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件,绑定数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReaderMain_Load(object sender, EventArgs e)
        {
            //绑定comboBox数据
            this.BindComboBox();

            //绑定DataGridView控件数据
            this.BindBookInfo();
        }
        #endregion

        #region 绑定comboBox数据
        /// <summary>
        /// 绑定comboBox数据
        /// </summary>
        public void BindComboBox()
        {
            //查询基本类
            string bClass = @"select * from [dbo].[BookClass];";

            //查询具体类
            string type = @"select [BookTypeID],[BookType] from [dbo].[BookType]";

            try
            {
                //绑定cboBookClass 具体类控件

                //运行SQL语句
                this.adapter = new SqlDataAdapter(bClass, DBHelper.Connection);
                //将数据填充到数据集ds的BookClass 表中
                this.adapter.Fill(this.ds, "BookClass");

                //向数据集中的BookClass临时数据表中 添加第一行数据“全部”
                DataRow row = this.ds.Tables["BookClass"].NewRow();
                //行编号与内容赋值
                row["ClassID"] = "-1";
                row["ClassName"] = "全部";
                //向BookClass 表中的插入行到下标0
                this.ds.Tables["BookClass"].Rows.InsertAt(row, 0);

                //绑定数据源
                this.cboBookClass.DataSource = this.ds.Tables["BookClass"];
                //设置实际值字段和显示文本字段
                this.cboBookClass.DisplayMember = "ClassName";
                this.cboBookClass.ValueMember = "ClassID";

                //绑定数据图书具体类

                //运行SQL语句
                this.adapter = new SqlDataAdapter(type, DBHelper.Connection);
                //向数据集 BookType表中填充数据
                this.adapter.Fill(this.ds, "BookType");
                //向数据集中的BookType临时数据表中 添加第一行数据“全部”
                DataRow row2 = this.ds.Tables["BookType"].NewRow();
                //行编号与内容赋值
                row2["BookTypeID"] = "-1";
                row2["BookType"] = "全部";

                //向BookType 表中的插入一行到下标0
                this.ds.Tables["BookType"].Rows.InsertAt(row2, 0);

                //绑定数据源
                this.cboBookType.DataSource = this.ds.Tables["BookType"];

                //设置实际值字段和显示文本字段
                this.cboBookType.DisplayMember = "BookType";
                this.cboBookType.ValueMember = "BookTypeID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        #region 图书数据绑定
        /// <summary>
        /// 图书数据绑定
        /// </summary>
        public void BindBookInfo()
        {
            //查询图书信息语句
            string sql = @"select Books.BookID,BookName,BookType,ClassName,Author,Press,State 
                        from Books,BookState,Book
                        inner join BookType on Book.BookTypeID = BookType.BookTypeID
                        inner join BookClass on Book.ClassID = BookClass.ClassID
                        where BookState.StateID = Books.StateID and Book.ID = Books.ID";
            try
            {
                //在adapter中运行SQL语句
                this.adapter = new SqlDataAdapter(sql, DBHelper.Connection);

                //将数据填充到数据集中的 BookInfo 表中
                this.adapter.Fill(this.ds, "BookInfo");

                //绑定数据源
                this.dgvBooksInfo.DataSource = this.ds.Tables["BookInfo"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        #region 搜索操作
        /// <summary>
        /// 根据comboBox、和输入框进行搜索
        /// </summary>
        public void SearchBook()
        {
            //获取基本类
            string baseClass = this.cboBookClass.Text.ToString();
            //判断是否搜索全部
            if (Convert.ToInt32(this.cboBookClass.SelectedValue) == -1)
            {
                baseClass = string.Empty;
            }

            //获取具体类
            string type = this.cboBookType.Text.ToString();
            //判断是否搜索全部
            if (Convert.ToInt32(this.cboBookType.SelectedValue) == -1)
            {
                type = string.Empty;
            }

            //获取文本框的内容
            string search = this.txtBookInfo.Text.Trim().ToString();

            //筛选条件
            string rowFilter = string.Format(@"ClassName like '%{0}%' and BookType like '%{1}%'
                             and BookName like '%{2}%'", baseClass, type, search);

            //设置筛选条件
            this.dv.RowFilter = rowFilter;
            //绑定数据源
            this.dgvBooksInfo.DataSource = dv;
        }
        #endregion

        #region 搜索
        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //条件筛选图书
            this.SearchBook();

            //判断是否为空
            if (this.dgvBooksInfo.RowCount <= 0)
            {
                //清空搜索框，获取焦点
                this.txtBookInfo.Clear();
                this.txtBookInfo.Focus();
                MessageBox.Show("未查询到有关书籍记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        #endregion

        #region 具体类数据绑定
        /// <summary>
        /// 根据选择基本类，绑定具体类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BindBookType()
        {
            //查询具体类
            string type = string.Empty;
            //当基本类选择全部时，具体类也显示全部
            if (!this.cboBookClass.Text.Equals("全部"))
            {
                //根据基本类插叙具体类
                type = string.Format(@"select [BookTypeID],[BookType] 
                        from [dbo].[BookType] where ClassID = {0}"
                        , Convert.ToInt32(this.cboBookClass.SelectedIndex));
            }
            else
            {
                //根据基本类插叙具体类
                type = "select [BookTypeID],[BookType] from [dbo].[BookType]";
            }

            //判断数据集中的 BookType表是否为空
            if (this.ds.Tables["BookType"] != null)
            {
                this.ds.Tables["BookType"].Clear();
            }

            try
            {
                //向数据适配器，填充数据
                this.adapter = new SqlDataAdapter(type, DBHelper.Connection);
                //将数据填充到数据集ds的BookType 表中
                this.adapter.Fill(this.ds, "BookType");

                //向数据集中的BookType表 添加第一行数据“全部”
                DataRow row = this.ds.Tables["BookType"].NewRow();
                row["BookTypeID"] = "-1";
                row["BookType"] = "全部";
                //向BookType 表中插入第一行
                this.ds.Tables["BookType"].Rows.InsertAt(row, 0);

                //绑定数据
                this.cboBookType.DataSource = this.ds.Tables["BookType"];
                //设置实际值和显示文本
                this.cboBookType.DisplayMember = "BookType";
                this.cboBookType.ValueMember = "BookTypeID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            //设置筛选条件
            dv.RowFilter = rowFilter.ToString();

            //绑定数据源
            this.dgvBooksInfo.DataSource = this.dv;
        }
        #endregion

        #region 通过选择不同的节点，在组合框显示相应的文本
        /// <summary>
        /// 通过选择不同的节点，在组合框显示相应的文本
        /// </summary>
        public void ShowByNodes()
        {
            //组合框的显示行的索引
            int bookClass = 0;
            int bookType = 0;

            //判断树形深度
            if (this.tvLibrary.SelectedNode.Level == 1)
            {
                bookClass = Convert.ToInt32(this.tvLibrary.SelectedNode.Tag);
            }
            else if (this.tvLibrary.SelectedNode.Level == 2)
            {
                bookClass = Convert.ToInt32(this.tvLibrary.SelectedNode.Parent.Tag);
                bookType = Convert.ToInt32(this.tvLibrary.SelectedNode.Tag);
            }

            //显示在组合框
            this.cboBookClass.SelectedIndex = bookClass;
            this.cboBookType.SelectedIndex = bookType;
        }
        #endregion

        #region 通过节点筛选图书
        /// <summary>
        /// 根据不同的节点筛选图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvLibrary_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //清空搜索框文本，获取焦点
            this.txtBookInfo.Clear();
            this.txtBookInfo.Focus();

            //通过选择不同的节点，在组合框显示相应的文本
            this.ShowByNodes();

            //根据不同的节点筛选图书
            this.Filter();

            //判断是否为空
            if (this.dgvBooksInfo.RowCount <= 0)
            {
                MessageBox.Show("馆内尚未查询到有关书籍记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        #endregion

        #region 根据基本类的选择，变换具体类
        /// <summary>
        /// 根据基本类的选择，变换具体类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBookClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //表BookType是否为空
            if (this.ds.Tables["BookType"] != null)
            {
                this.ds.Tables["BookType"].Clear();
            }
            //绑定Combo框
            this.BindBookType();
            //显示第一项
            this.cboBookType.SelectedIndex = 0;
        }
        #endregion

        #region 关键字进行查找，清除文本框的文本
        /// <summary>
        /// 关键字进行查找，清除文本框的文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBookInfo_Click(object sender, EventArgs e)
        {
            this.txtBookInfo.Clear();
        }
        #endregion

        #region 借阅信息
        /// <summary>
        /// 借阅信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrowInfo_Click(object sender, EventArgs e)
        {
            //显示借阅信息窗体
            FrmBorrowRecord frmBorrowRecord = new FrmBorrowRecord();
            frmBorrowRecord.ShowDialog();

            //刷新
            if (this.ds.Tables["BookInfo"] != null)
            {
                this.ds.Tables["BookInfo"].Clear();
            }
            this.BindBookInfo();
        }
        #endregion

        #region 退出
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 修改信息
        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbUpdateInfo_Click(object sender, EventArgs e)
        {
            FrmReaderUpdate frmReaderUppdate = new FrmReaderUpdate();
            frmReaderUppdate.ShowDialog();
        }
        #endregion

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

        #region 借书
        /// <summary>
        /// 借书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrow_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (this.dgvBooksInfo.RowCount <= 0)
            {
                MessageBox.Show("请选择相关书籍进行操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //判断是否为可借的书
            if (this.dgvBooksInfo.SelectedCells[6].Value.ToString().Equals(BookState.可借.ToString()))
            {
                FrmBorrowBooks frmBorrowBooks = new FrmBorrowBooks();
                //向frmBorrowBooks 传递 bookID 和 bookName
                frmBorrowBooks.bookID = this.dgvBooksInfo.SelectedCells[0].Value.ToString();
                frmBorrowBooks.bookName = this.dgvBooksInfo.SelectedCells[1].Value.ToString();
                frmBorrowBooks.ShowDialog();

                //刷新
                if (this.ds.Tables["BookInfo"] != null)
                {
                    this.ds.Tables["BookInfo"].Clear();
                }
                this.BindBookInfo();
            }
            else
            {
                MessageBox.Show("您选的这本书不可借！","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        #region 预定
        /// <summary>
        /// 预定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (this.dgvBooksInfo.RowCount <= 0)
            {
                MessageBox.Show("请选择相关书籍进行操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.dgvBooksInfo.SelectedCells[6].Value.ToString().Equals(BookState.可预订.ToString()))
            {
                FrmAdvance frmAdvance = new FrmAdvance();
                //向 frmAdvance 传递 bookID 和 bookName
                frmAdvance.bookID = this.dgvBooksInfo.SelectedCells[0].Value.ToString();
                frmAdvance.bookName = this.dgvBooksInfo.SelectedCells[1].Value.ToString();
                frmAdvance.ShowDialog();

                //刷新数据
                if (this.ds.Tables["BookInfo"] != null)
                {
                    this.ds.Tables["BookInfo"].Clear();
                }
                this.BindBookInfo();
            }
            else
            {
                MessageBox.Show("该图书无法预定！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
