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
    public partial class FrmBookUpdate : MetroForm
    {
        public FrmBookUpdate()
        {
            InitializeComponent();
            ////this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        //接收所要修改的图书编号
        public string bookID = string.Empty;

        //获取修改图书所需的ID号
        private string id = string.Empty;

        //创建数据集和数据适配器
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;

        //图书基本编号
        private int bookClass;
        private int bookType;

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

        #region 检查数据输入的有效性
        /// <summary>
        /// 非空验证
        /// </summary>
        public bool CheckInput()
        {
            string message = string.Empty;

            bool valid = false;

            if (this.txtBookName.Text.Trim().Equals(string.Empty))
            {
                message = "请输入图书名称！";
                this.txtBookName.Focus();
            }
            else if (this.txtAuthor.Text.Trim().Equals(string.Empty))
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
                this.Focus();
            }
            else if (this.cboBookClass.Text.Equals("请选择") || this.cboBookType.Text.Equals("请选择"))
            {
                message = "请选择图书类型！";
            }
            else if (this.nudPrice.Value == 0)
            {
                message = "请设置图书价格！";
            }
            else
            {
                return true;
            }

            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return valid;
        }
        #endregion

        #region 根据图书编号修改图书信息
        /// <summary>
        /// 根据图书编号修改图书信息
        /// </summary>
        /// <returns></returns>
        public bool BookUpdate()
        {
            //默认修改失败
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

            StringBuilder sb = new StringBuilder();
            //修改图书状态
            sb.AppendFormat(@"update Books set StateID = {0} where BookID = {1}",stateID,Convert.ToInt32(this.bookID));
            //执行
            int iRet = DBHelper.ExecuteNonQuery(sb.ToString());
            if(iRet == 1)
            {
                sb.Length = 0;
                //修改图书信息
                sb.AppendFormat(@"update Book set BookName = '{0}',BookTypeID = {1},ClassID = {2},
                                        Press = '{3}',Author = '{4}',Words = '{5}',Time = GETDATE(),Price = {6}
                                        where ID = {7}", this.txtBookName.Text.Trim().ToString(), Convert.ToInt32(this.cboBookType.SelectedValue),
                                       Convert.ToInt32(this.cboBookClass.SelectedValue), this.txtPress.Text.Trim().ToString(),
                                       this.txtAuthor.Text.Trim().ToString(), Convert.ToInt32(this.txtWords.Text.Trim()),
                                       Convert.ToDecimal(this.nudPrice.Value), Convert.ToInt32(this.id));

                //执行更新
                iRet = DBHelper.ExecuteNonQuery(sb.ToString());

                if(iRet == 1)
                {
                    //成功更新
                    valid = true;
                }

            }
            return valid;
        }
        #endregion

        #region 修改
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //检查用户的合法输入性
            if(this.CheckInput())
            {
                //给出用户提示
                if (DialogResult.OK == MessageBox.Show("确定要修改吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    string message = string.Empty;
                    //执行修改操作
                    if(this.BookUpdate())
                       
                    {
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //关闭修改窗口
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //重置修改内容
                        this.BookInfoByBookID();
                        //图书基本类编号
                        this.cboBookClass.SelectedValue = this.bookClass;
                        //图书具体类编号
                        this.cboBookType.SelectedValue = this.bookType;
                    }
                }
                else
                {
                    //关闭修改窗口
                    this.Close();
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

        #region 根据图书编号查询图书信息
        /// <summary>
        /// 根据图书编号查询图书信息
        /// </summary>
        public void BookInfoByBookID()
        {
            StringBuilder sb = new StringBuilder();
            //查询语句
            sb.AppendFormat(@"select ID,StateID from Books where BookID = {0};",Convert.ToInt32(this.bookID));

            //执行
            SqlDataReader reader = DBHelper.ExecuteReader(sb.ToString());

            //读取数据
            if(reader.Read())
            {
                this.id = reader[0].ToString();
                
                //判断图书的状态
                if(Convert.ToInt32(reader[1]) == Convert.ToInt32(BookState.可借))
                {
                    this.rbBorrow.Checked = true;
                }
                else if(Convert.ToInt32(reader[1]) == Convert.ToInt32(BookState.不可借))
                {
                    this.rbNoBorrow.Checked = true;
                }
            }
            //关闭对象
            reader.Close();

            //再次查找图书具体信息
            if(!this.id.Equals(string.Empty))
            {
                sb.Length = 0;
                sb.AppendFormat(@"select BookName,Press,Author,Words,Price,ClassID,BookTypeID 
                                from Book where ID = {0};",Convert.ToInt32(this.id));

                //执行
                reader = DBHelper.ExecuteReader(sb.ToString());

                //读取数据
                if(reader.Read())
                {

                    //赋值显示在窗体
                    this.txtBookName.Text = reader[0].ToString();
                    this.txtPress.Text = reader[1].ToString();
                    this.txtAuthor.Text = reader[2].ToString();
                    this.txtWords.Text = reader[3].ToString();
                    this.nudPrice.Value = Convert.ToDecimal(reader[4]);
                    //获取图书类别
                    this.bookClass = Convert.ToInt32(reader[5]);
                    this.bookType = Convert.ToInt32(reader[6]);
                }
                //关闭对象
                reader.Close();
            }
        }
        #endregion

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBookUpdate_Load(object sender, EventArgs e)
        {
            if(!this.bookID.Equals(string.Empty))
            {
                this.txtBookID.Text = this.bookID.ToString();

                //ComboBox的数据绑定
                this.BindComboBox();

                //显示需修改的图书信息
                this.BookInfoByBookID();
            
                //图书基本类编号
                this.cboBookClass.SelectedValue = this.bookClass;
                //图书具体类编号
                this.cboBookType.SelectedValue = this.bookType;
            }
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
            //表BookType是否为空
            if (this.ds.Tables["BookType"] != null)
            {
                this.ds.Tables["BookType"].Clear();
            }
            //绑定Combo框
            this.BindBookType();

            this.cboBookType.SelectedIndex = 0;
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
