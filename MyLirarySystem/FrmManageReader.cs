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
    /// 读者信息管理窗体
    /// </summary>
    public partial class FrmManageReader : MetroForm
    {
        public FrmManageReader()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        //创建数据集和适配器
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;

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

        #region 读者信息数据绑定
        /// <summary>
        /// DataGridView 读者数据绑定
        /// </summary>
        public void BindReaderInfo()
        { 
            //查询语句 select 字段 from 表名
            string sql = @"select ReaderID,ReaderName,IDCard,BorrowBook,ReturnBook,Phone,Address from Reader";

            //临时仓库
            ds = new DataSet();

            //向数据适配器，填充数据
            this.adapter = new SqlDataAdapter(sql,DBHelper.Connection);

            //将数据填充到数据集 表Reader中
            this.adapter.Fill(ds,"Reader");

            //绑定数据源
            this.dgvShow.DataSource = ds.Tables["Reader"];
        }
        #endregion

        #region 窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManageReader_Load(object sender, EventArgs e)
        {
            //绑定读者信息
            this.BindReaderInfo();
        }
        #endregion

        #region 根据关键字搜索读者信息
        /// <summary>
        /// 根据关键字搜索读者信息
        /// </summary>
        public void SearchReaderInfo()
        {
            //清除数据集表中原有数据
            if (this.ds.Tables["Reader"] != null)
            {
                this.ds.Tables["Reader"].Clear();
            }

            //筛选语句，根据关键字搜索读者信息
            string sql = string.Format(@"select ReaderID,ReaderName,IDCard,BorrowBook,ReturnBook,Phone,Address from Reader 
                                where ReaderID like '%{0}%' or ReaderName like '%{0}%' or IDCard like '%{0}%' 
                                or Address like '%{0}%' or Phone like '%{0}%'",this.txtSearch.Text.ToString());
        
            //向数据适配器，填充数据
            this.adapter = new SqlDataAdapter(sql,DBHelper.Connection);

            //填充
            this.adapter.Fill(this.ds,"Reader");

            //再次绑定数据源
            this.dgvShow.DataSource = this.ds.Tables["Reader"];
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
            this.SearchReaderInfo();

            //判断是否为空
            if (this.dgvShow.RowCount <= 0)
            {
                //清空搜索框，获取焦点
                this.txtSearch.Clear();
                this.txtSearch.Focus();
                MessageBox.Show("未查询到相关读者信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 查看全部
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAll_Click(object sender, EventArgs e)
        {
            //清除数据集表中原有数据
            if (this.ds.Tables["Reader"] != null)
            {
                this.ds.Tables["Reader"].Clear();
            }

            //重新绑定数据源
            this.BindReaderInfo();

            //清除搜索框，获取焦点
            this.txtSearch.Clear();
            this.txtSearch.Focus();
        }
        #endregion

        #region 读者借阅信息
        /// <summary>
        /// 读者借阅信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrowByReader_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (this.dgvShow.RowCount <= 0)
            {
                MessageBox.Show("请选择相关操作读者！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //显示借阅记录查询窗口
            FrmBorrowRecord frmBorrowRecord = new FrmBorrowRecord();

            //传递被选中的读者卡号
            frmBorrowRecord.readerId = this.dgvShow.SelectedCells[0].Value.ToString();

            //模式显示窗体
            frmBorrowRecord.ShowDialog();

            //清除数据集表中原有数据
            if (this.ds.Tables["Reader"] != null)
            {
                this.ds.Tables["Reader"].Clear();
            }

            //重新绑定数据源
            this.BindReaderInfo();

            //清除搜索框，获取焦点
            this.txtSearch.Clear();
            this.txtSearch.Focus();
        }
        #endregion

        #region 读者逾期信息
        /// <summary>
        /// 读者逾期信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbOverdue_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (this.dgvShow.RowCount <= 0)
            {
                MessageBox.Show("请选择相关操作读者！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //显示逾期记录查询窗口
            FrmOverdue frmOverdue = new FrmOverdue();

            //传递被选中的读者卡号
            frmOverdue.readerId = this.dgvShow.SelectedCells[0].Value.ToString();

            //模式显示窗体
            frmOverdue.ShowDialog();
        }
        #endregion

        #region 添加读者
        /// <summary>
        /// 添加读者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAddReader_Click(object sender, EventArgs e)
        {
            FrmReaderAdd frmReaderAdd = new FrmReaderAdd();
            frmReaderAdd.ShowDialog();

            //清空数据
            if(this.ds.Tables["Reader"] != null)
            {
                this.ds.Tables["Reader"].Clear();
            }

            //重新绑定数据
            this.BindReaderInfo();
        }
        #endregion

        #region 通过读者卡号查询是否在使用中
        /// <summary>
        /// 通过读者卡号查询是否在使用中
        /// </summary>
        /// <returns></returns>
        public bool IsUsingByReaderID()
        {
            //仍在使用,不能删除
            bool valid = false;

            //查询读者借阅信息
            string sql = string.Format(@"select count(*) from Borrow where ReaderID = {0}", Convert.ToInt32(this.dgvShow.SelectedCells[0].Value));

            //执行
            if(Convert.ToInt32(DBHelper.ExecuteScalar(sql)) == 0)
            {
                //不再使用,可以删除
                valid = true;
            }

            return valid;
        }
        #endregion

        #region 删除操作
        /// <summary>
        /// 删除操作
        /// </summary>
        /// <returns></returns>
        public bool DeleteReader()
        {
            bool valid = false;

            //删除操作
            string sql = string.Format(@"delete from Borrow where ReaderID = {0} and GiveBackDate is not null;
                                delete from Reader where ReaderID = {0};", Convert.ToInt32(this.dgvShow.SelectedCells[0].Value));

            //判断读者是否可以删除
            if (this.IsUsingByReaderID())
            {
                //执行
                if (DBHelper.ExecuteNonQuery(sql) == 1)
                {
                    valid = true;
                }
            }
            else
            {
                MessageBox.Show("该读者账号还在使用中！","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

            return valid;
        }
        #endregion

        #region 删除读者
        /// <summary>
        /// 删除读者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDetele_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (this.dgvShow.RowCount <= 0)
            {
                MessageBox.Show("请选择相关操作读者！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //给出用户提示
            if(DialogResult.OK == MessageBox.Show("您确定要删除该读者吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
            {
                //判断是否删除成功
                if (this.DeleteReader())
                {
                    MessageBox.Show("删除成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }

            //更新数据
            if(this.ds.Tables["Reader"] != null)
            {
                this.ds.Tables["Reader"].Clear();
            }
            this.BindReaderInfo();
        }
        #endregion

        #region 读者信息修改
        /// <summary>
        /// 读者信息修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (this.dgvShow.RowCount <= 0)
            {
                MessageBox.Show("请选择相关操作读者！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FrmReaderUpdate frmReaderUpdate = new FrmReaderUpdate();
            //向frmReaderUpdate 传递 ReaderID
            frmReaderUpdate.readerID = this.dgvShow.SelectedCells[0].Value.ToString();
            frmReaderUpdate.ShowDialog();
        }
        #endregion
    }
}