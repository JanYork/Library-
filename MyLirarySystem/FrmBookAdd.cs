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
    /// 图书添加类
    /// </summary>
    public partial class FrmBookAdd : MetroForm
    {
        public FrmBookAdd()
        {
            InitializeComponent();           
        }

        //创建数据集和数据适配器
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;

        #region 绑定comboBox数据
        /// <summary>
        /// 绑定comboBox数据
        /// </summary>
        public void BindComboBox()
        {
            //查询基本类
            string bClass = @"select * from [dbo].[BookClass];";

          
            try
            {
                //绑定cboBookClass 具体类控件
                //填充数据
                this.adapter = new SqlDataAdapter(bClass, DBHelper.Connection);
                //将数据填充到数据集ds的BookClass 表中
                this.adapter.Fill(this.ds, "BookClass");

                //向数据集中的BookClass表 添加第一行数据“请选择”
                DataRow row = this.ds.Tables["BookClass"].NewRow();
                row["ClassID"] = "-1";
                row["ClassName"] = "请选择";
                this.ds.Tables["BookClass"].Rows.InsertAt(row, 0);

                //绑定数据
                this.cboBookClass.DataSource = this.ds.Tables["BookClass"];
                //设置实际值和显示文本
                this.cboBookClass.DisplayMember = "ClassName";
                this.cboBookClass.ValueMember = "ClassID";
            }
            catch (Exception ex)
            {           
                MessageBox.Show("错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (!this.cboBookClass.Text.Equals("请选择"))
            {
                //SQL语句
                type = string.Format(@"select [BookTypeID],[BookType] 
                        from [dbo].[BookType] where ClassID = {0}"
                        , Convert.ToInt32(this.cboBookClass.SelectedIndex));
            }
            else
            {
                type = "select [BookTypeID],[BookType] from [dbo].[BookType]";
            }
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

                //向数据集中的BookType表 添加第一行数据“请选择”
                DataRow row = this.ds.Tables["BookType"].NewRow();
                row["BookTypeID"] = "-1";
                row["BookType"] = "请选择";
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

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBookAdd_Load(object sender, EventArgs e)
        {
            this.BindComboBox();
        }
        #endregion

        #region 根据基本类，显示具体类
        /// <summary>
        /// 根据基本类，显示具体类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBookClass_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        #region 检查数据输入的有效性
        /// <summary>
        /// 非空验证
        /// </summary>
        public bool CheckInput()
        {
            string message = string.Empty;
            bool valid = false;
            if(this.txtBookName.Text.Trim().Equals(string.Empty))
            {             
                message = "请输入图书名称！";
                this.txtBookName.Focus();
            }
            else if(this.txtAuthor.Text.Trim().Equals(string.Empty))
            {
                message = "请输入作者姓名！";
                this.txtAuthor.Focus();
            }
            else if (this.txtPress.Text.Trim().Equals(string.Empty))
            {
                message = "请输入出版社！";
                this.txtPress.Focus();
            }
            else if (this.txtWords.Text.Trim().Equals(string.Empty) || Convert.ToInt32(this.txtWords.Text.Trim()) < 0)
            {
                message = "请输入有效字数！";
                this.txtWords.Clear();
                this.txtWords.Focus();
            }
            else if (this.cboBookClass.Text.Equals("请选择") || this.cboBookType.Text.Equals("请选择"))
            {
                message = "请选择图书类型！";
            }
            else if(this.nudPrice.Value == 0)
            {
                message = "请设置图书价格！";
            }
            else
            {
                return true;
            }
            MessageBox.Show(message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return valid;
        }
        #endregion

        #region 添加操作
        /// <summary>
        /// 添加操作
        /// </summary>
        /// <returns></returns>
        public bool AddBook()
        {
            bool valid = false;

            //获取图书状态
            int stateID = 0;
            //判断选中的单选按钮
            if (this.rbBorrow.Checked)
            {
                stateID = Convert.ToInt32(BookState.可借);
            }
            else if (this.rbNoBorrow.Checked)
            {
                stateID = Convert.ToInt32(BookState.不可借);
            }

            //插入图书语句,查询插入的自增列的值 ID
            StringBuilder sb = new StringBuilder();
            //编写SQL语句，进行添加操作
            sb.Append(string.Format(@"insert into Book(BookName,Press,Author,Words,Time,Price,ClassID,BookTypeID)
                        values ('{0}','{1}','{2}','{3}',GETDATE(),'{4}',{5},{6});
                        select @@IDENTITY;",this.txtBookName.Text.Trim().ToString(),
                        this.txtPress.Text.Trim().ToString(),this.txtAuthor.Text.Trim().ToString(),
                        Convert.ToInt32(this.txtWords.Text.Trim()),Convert.ToSingle(this.nudPrice.Value),
                        Convert.ToInt32(this.cboBookClass.SelectedValue),Convert.ToInt32(this.cboBookType.SelectedValue)));

            //执行,查询ID
            int ID = Convert.ToInt32(DBHelper.ExecuteScalar(sb.ToString()));

            if (ID > 0)
            {
                sb.Length = 0;

                //编写SQL语句，添加图书
                sb.Append(string.Format("insert into Books(ID,StateID) values({0},{1});select @@identity;", ID, stateID));

                //执行，查询图书编号
                int bookID = Convert.ToInt32(DBHelper.ExecuteScalar(sb.ToString()));

                //插入成功
                if(bookID > 0)
                {
                    //赋值给图书编号文本框
                    this.txtBookID.Text = bookID.ToString();
                    valid = true;
                }
            }

            return valid;
        }
        #endregion

        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //检查输入框输入的合法性
            if(this.CheckInput())
            {
                if (this.AddBook())
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //复原
                    this.txtBookName.Clear();
                    this.txtBookName.Focus();
                    this.txtAuthor.Clear();
                    this.txtPress.Clear();
                    this.txtWords.Clear();
                    this.nudPrice.Value = 0;
                    this.cboBookClass.SelectedIndex = 0;
                    this.cboBookType.SelectedIndex = 0;
                    this.rbBorrow.Checked = true;
                }
                else
                {
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        #region 选中可借
        /// <summary>
        /// 选中可借
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbBorrow_Click(object sender, EventArgs e)
        {
            this.rbBorrow.Checked = true;
        }
        #endregion

        #region 选中不可借
        /// <summary>
        /// 选中不可借
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbNoBorrow_Click(object sender, EventArgs e)
        {
            this.rbNoBorrow.Checked = true;
        }
        #endregion

        
    }
}
