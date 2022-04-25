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
    /// 文献窗体
    /// </summary>
    public partial class FrmPhiloloy : MetroForm
    {
        public FrmPhiloloy()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//CalmnessColor2.ssk";
        }

        //创建数据集
        DataSet ds = new DataSet();
        //适配器
        SqlDataAdapter adapter;
        //动态数据视图
        DataView dv;

        #region 绑定数据
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void BindBook()
        {
            //查询图书信息语句
            string sql = string.Format(@"select BookID,BookName,Author,Press,Words,BookType,ClassName,Price,State 
                        from Books,Book,BookType,BookClass,BookState 
                        where Books.ID = Book.ID and Book.BookTypeID = BookType.BookTypeID 
                        and Book.ClassID = BookClass.ClassID and BookState.StateID = Books.StateID 
                        and BookState.StateID = {0};",Convert.ToInt32(BookState.不可借));

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
        private void FrmPhiloloy_Load(object sender, EventArgs e)
        {
            //绑定图书数据
            this.BindBook();
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
                MessageBox.Show("未找到相关书籍！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
