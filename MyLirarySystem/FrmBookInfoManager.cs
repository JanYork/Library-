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
    /// 图书信息管理窗体
    /// </summary>
    public partial class FrmBookInfoManager : MetroForm
    {
        public FrmBookInfoManager()
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

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件,绑定数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBookInfoManager_Load(object sender, EventArgs e)
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
                //填充数据
                this.adapter = new SqlDataAdapter(bClass,DBHelper.Connection);
                //将数据填充到数据集ds的BookClass 表中
                this.adapter.Fill(this.ds, "BookClass");

                //向数据集中的BookClass表 添加第一行数据“全部”
                DataRow row = this.ds.Tables["BookClass"].NewRow();
                row["ClassID"] = "-1";
                row["ClassName"] = "全部";

                //向数据集中的BookClass表 插入到第一行
                this.ds.Tables["BookClass"].Rows.InsertAt(row, 0);

                //绑定数据
                this.cboBookClass.DataSource = this.ds.Tables["BookClass"];
                //设置实际值和显示文本
                this.cboBookClass.DisplayMember = "ClassName";
                this.cboBookClass.ValueMember = "ClassID";

                //绑定数据图书具体类
                //填充数据
                this.adapter = new SqlDataAdapter(type, DBHelper.Connection);
                //向数据集 BookType表中填充数据
                this.adapter.Fill(this.ds, "BookType");
                //向数据集中的BookType表 添加第一行数据“全部”
                DataRow row2 = this.ds.Tables["BookType"].NewRow();
                row2["BookTypeID"] = "-1";
                row2["BookType"] = "全部";

                //向数据集中的BookType表 插入到第一行
                this.ds.Tables["BookType"].Rows.InsertAt(row2, 0);

                //绑定数据
                this.cboBookType.DataSource = this.ds.Tables["BookType"];
                //设置实际值和显示文本
                this.cboBookType.DisplayMember = "BookType";
                this.cboBookType.ValueMember = "BookTypeID";
            }
            catch(Exception ex)
            {
                MessageBox.Show("错误!","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        #region 图书数据绑定
        /// <summary>
        /// 图书数据绑定
        /// </summary>
        public void BindBookInfo()
        { 
            //查询图书信息语句，连接表 books bookState book
            string sql = @"select Books.BookID,BookName,BookType,ClassName,Author,Press,State 
                        from Books,BookState,Book
                        inner join BookType on Book.BookTypeID = BookType.BookTypeID
                        inner join BookClass on Book.ClassID = BookClass.ClassID
                        where BookState.StateID = Books.StateID and Book.ID = Books.ID";
            try
            { 
                //数据适配器，填充数据
                this.adapter = new SqlDataAdapter(sql,DBHelper.Connection);

                //将数据填充到数据集中的 BookInfo 表中
                this.adapter.Fill(this.ds, "BookInfo");

                //绑定数据源
                this.dgvBooksInfo.DataSource = this.ds.Tables["BookInfo"];

            }
            catch(Exception ex)
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
            //获取基本类的内容
            string baseClass = this.cboBookClass.Text.ToString();
            //判断是否基本类是否选择全部—1
            if (Convert.ToInt32(this.cboBookClass.SelectedValue) == -1)
            {
                baseClass = string.Empty;
            }

            //获取具体类的内容
            string type = this.cboBookType.Text.ToString();
            //判断是否具体类是否选择全部—1
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
                type = string.Format(@"select [BookTypeID],[BookType] 
                        from [dbo].[BookType] where ClassID = {0}"
                        , Convert.ToInt32(this.cboBookClass.SelectedIndex));
            }
            else
            { 
                type = "select [BookTypeID],[BookType] from [dbo].[BookType]";
            }

            //判断数据集中的 BookType表是否为空
            if (this.ds.Tables["BookType"] != null)
            {
                this.ds.Tables["BookType"].Clear();
            }

            try
            {
                //填充数据
                this.adapter = new SqlDataAdapter(type, DBHelper.Connection);
                //将数据填充到数据集ds的BookType 表中
                this.adapter.Fill(this.ds, "BookType");

                //向数据集中的BookType表 添加第一行数据“全部”
                DataRow row = this.ds.Tables["BookType"].NewRow();
                row["BookTypeID"] = "-1";
                row["BookType"] = "全部";
                //向数据集中的BookType表 插入第一行
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
                rowFilter =string.Format("ClassName = '{0}' ", this.tvLibrary.SelectedNode.Text.ToString());
            }
            else if(this.tvLibrary.SelectedNode.Level == 2)
            {
                rowFilter = string.Format("ClassName = '{0}' and BookType = '{1}'"
                    ,this.tvLibrary.SelectedNode.Parent.Text.ToString(), this.tvLibrary.SelectedNode.Text.ToString());
            }

            //创建动态视图
            this.dv = this.ds.Tables["BookInfo"].DefaultView;
            dv.RowFilter = rowFilter.ToString();

            //绑定数据
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

            //判断深度
            if(this.tvLibrary.SelectedNode.Level == 1)
            {
                bookClass = Convert.ToInt32(this.tvLibrary.SelectedNode.Tag);
            }
            else if(this.tvLibrary.SelectedNode.Level == 2)
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
            //清空搜索框文本
            this.txtBookInfo.Clear();
            this.txtBookInfo.Focus();

            //通过选择不同的节点，在组合框显示相应的文本
            this.ShowByNodes();

            //根据不同的节点筛选图书
            this.Filter();

            //判断是否为空
            if(this.dgvBooksInfo.RowCount <= 0)
            {
                MessageBox.Show("未查询到相关书籍！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(this.ds.Tables["BookType"] != null)
            {
                this.ds.Tables["BookType"].Clear();
            }
            //绑定Combo框
            this.BindBookType();
            //显示第一项
            this.cboBookType.SelectedIndex = 0;
        }
        #endregion

        #region 刷新
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAll_Click(object sender, EventArgs e)
        {
            //判断数据集表中是否存在数据
            if (this.ds.Tables["BookInfo"] != null)
            {
                this.ds.Tables["BookInfo"].Clear();
            }

            //重新数据绑定
            this.BindBookInfo();
            //清空搜索框
            this.txtBookInfo.Clear();
            this.txtBookInfo.Focus();
            //组合框显示“全部”
            this.cboBookClass.SelectedIndex = 0;
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

        #region 添加图书
        /// <summary>
        /// 添加图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAddBook_Click(object sender, EventArgs e)
        {
            //显示图书添加窗体
            FrmBookAdd frmBookAdd = new FrmBookAdd();
            frmBookAdd.ShowDialog();

            //刷新
            if (this.ds.Tables["BookInfo"] != null)
            {
                this.ds.Tables["BookInfo"].Clear();
            }
            //重新绑定数据
            this.BindBookInfo();
        }
        #endregion

        #region 修改图书
        /// <summary>
        /// 修改图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbUpdateBook_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (this.dgvBooksInfo.RowCount <= 0)
            {
                MessageBox.Show("未选择相关操作书籍！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //显示图书修改窗体
            FrmBookUpdate frmBookUpdate = new FrmBookUpdate();
            
            //判断图书是否已经借出
            if (this.dgvBooksInfo.SelectedCells[6].Value.ToString().Equals("已借"))
            {
                MessageBox.Show("该图书已出借，无法修改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //向修改图书窗体传值,获取需要修改的图书编号
                frmBookUpdate.bookID = this.dgvBooksInfo.SelectedCells[0].Value.ToString();

                frmBookUpdate.ShowDialog();

                //刷新
                if (this.ds.Tables["BookInfo"] != null)
                {
                    this.ds.Tables["BookInfo"].Clear();
                }
                //重新绑定数据
                this.BindBookInfo();
            }
        }
        #endregion

        #region 删除图书操作
        /// <summary>
        /// 删除图书操作
        /// </summary>
        /// <returns></returns>
        public bool DeleteBook()
        {
            //默认删除失败
            bool valid = false;

            StringBuilder sb = new StringBuilder();

            //查询相同的图书数量
            sb.AppendFormat(@"select Number from Book where ID  = Convert(int,(select ID from Books where BookID = '{0}'));", Convert.ToInt32(this.dgvBooksInfo.SelectedCells[0].Value));
            //执行
            int number = Convert.ToInt32(DBHelper.ExecuteScalar(sb.ToString()));

            //查询图书编号ID
            sb.Length = 0;
            sb.AppendFormat(@"select ID from Books where BookID = {0}", Convert.ToInt32(this.dgvBooksInfo.SelectedCells[0].Value));
            //执行
            int id = Convert.ToInt32(DBHelper.ExecuteScalar(sb.ToString()));
            //判断查询是否异常
            if(number == -1 || id == -1)
            {
                return valid;
            }

            //删除语句
            sb.Length = 0;
            sb.AppendFormat("delete from Books where BookID = '{0}';",Convert.ToInt32(this.dgvBooksInfo.SelectedCells[0].Value));

            //执行
            int iRet = DBHelper.ExecuteNonQuery(sb.ToString());
            //判断从表的图书是否删除
            if(iRet == 1)
            {
                //删除主表图书
                sb.Length = 0;
                //判断number 图书数量是否为
                if (number == 1)
                {
                    sb.AppendFormat(@"delete from Book where ID = {0}", id);
                    //执行
                    if (DBHelper.ExecuteNonQuery(sb.ToString()) == 1)
                    {
                        //删除成功
                        valid = true;
                    }
                }
                else
                {
                    //图书数量减一
                    sb.AppendFormat(@"update Book set Number = Number - 1 where ID = {0};", id);
                    //执行
                    if(DBHelper.ExecuteNonQuery(sb.ToString()) == 1)
                    {
                        //删除成功
                        valid = true;
                    }
                }
            }

            return valid;
        }
        #endregion

        #region 删除图书
        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDeleteBook_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if(this.dgvBooksInfo.RowCount <= 0)
            {
                   MessageBox.Show("未选择相关操作书籍！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   return;
            }

            //删除提示
            if(DialogResult.OK == MessageBox.Show("您确定要删除吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                //执行删除操作
                if (this.DeleteBook())
                {
                    MessageBox.Show("删除成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //刷新
            if (this.ds.Tables["BookInfo"] != null)
            {
                this.ds.Tables["BookInfo"].Clear();
            }
            //重新绑定数据
            this.BindBookInfo();
        }
        #endregion

        #region 搜索
        /// <summary>
        /// 搜索按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            //条件筛选图书
            this.SearchBook();

            //判断是否为空
            if (this.dgvBooksInfo.RowCount <= 0)
            {
                MessageBox.Show("未查询到相关书籍！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //清空搜索框，获取焦点
                this.txtBookInfo.Clear();
                this.txtBookInfo.Focus();
            }
        }
        #endregion
    }
}
