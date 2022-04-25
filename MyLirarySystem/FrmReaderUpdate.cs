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
    /// 修改读者信息窗口
    /// </summary>
    public partial class FrmReaderUpdate : MetroForm
    {
        public FrmReaderUpdate()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        //读者密码
        private string pwd = string.Empty;

        //从读者管理信息窗口获取读者卡号
        public string readerID = string.Empty;

        #region 检查数据输入的有效性
        /// <summary>
        /// 非空验证
        /// </summary>
        public bool CheckInput()
        {
            string message = string.Empty;

            bool valid = false;

            if (this.txtOldPwd.Text.Trim().Equals(string.Empty))
            {
                message = "请输入密码！";
                this.txtOldPwd.Focus();
            }
            else if (this.txtNewPwd.Text.Trim().Equals(string.Empty))
            {
                message = "请输入密码！";
                this.txtNewPwd.Focus();
            }
            else if (this.txtReaderName.Text.Trim().Equals(string.Empty))
            {
                message = "请输入读者姓名！";
                this.txtReaderName.Focus();
            }
            else if (this.txtPhone.Text.Trim().Equals(string.Empty) || Convert.ToInt32(this.txtPhone.Text.Length) < 5)
            {
                message = "请输入有效联系方式！";
                this.txtPhone.Clear();
                this.txtPhone.Focus();
            }
            else if (this.txtAddress.Text.Trim().Equals(string.Empty))
            {
                message = "请输入地址！";
                this.txtAddress.Focus();
            }
            else if (this.txtIDCard.Text.Trim().Equals(string.Empty) || this.txtIDCard.Text.Trim().Length < 18)
            {
                message = "请输入有效身份证！";
                this.txtIDCard.Clear();
                this.txtIDCard.Focus();
            }
            else
            {
                return true;
            }

            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return valid;
        }
        #endregion

        #region 根据读者登录卡号插叙读者信息
        /// <summary>
        /// 根据读者登录卡号插叙读者信息
        /// </summary>
        public void ReaderInfo()
        { 
            //查询语句
            StringBuilder sb = new StringBuilder();

            //判断是否为读者登录
            if(StaticStore.loginType == false)
            {
                sb.AppendFormat(@"select ReaderName,Pwd,Phone,Address,IDCard from Reader where ReaderID = '{0}'"
                            ,Convert.ToString(StaticStore.readerID));
            }

            //管理员登录
            if(StaticStore.loginType == true)
            {
                sb.Length = 0;
                sb.AppendFormat(@"select ReaderName,Pwd,Phone,Address,IDCard from Reader where ReaderID = '{0}'"
                            , Convert.ToString(this.readerID));
            }

            //执行查询
            SqlDataReader reader = DBHelper.ExecuteReader(sb.ToString());

            if (reader != null)
            {
                //读取数据
                if (reader.Read())
                {
                    //跟文本款赋值
                    this.txtReaderID.Text = StaticStore.readerID.ToString();
                    //管理员登录
                    if (StaticStore.loginType == true)
                    {
                        this.txtReaderID.Text = this.readerID;
                    }
                    this.txtReaderName.Text = reader[0].ToString();
                    this.pwd = reader[1].ToString();
                    this.txtPhone.Text = reader[2].ToString();
                    this.txtAddress.Text = reader[3].ToString();
                    this.txtIDCard.Text = reader[4].ToString();
                }
            }
            reader.Close();
        }
        #endregion

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReaderUpdate_Load(object sender, EventArgs e)
        {
            //读者登录，信息显示
            this.ReaderInfo();
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

        #region 修改操作
        /// <summary>
        /// 修改操作
        /// </summary>
        /// <returns></returns>
        public bool UpdateReaderInfo()
        { 
            //默认修改失败
            bool valid = false;

            //修改语句
            string sql = string.Format(@"update Reader set ReaderName = '{0}',Pwd = '{1}',Phone = '{2}',Address = '{3}',IDCard = '{4}'
                         where ReaderID = {5}",this.txtReaderName.Text.Trim().ToString(),
                         this.txtNewPwd.Text.Trim().ToString(),this.txtPhone.Text.Trim().ToString(),
                         this.txtAddress.Text.Trim().ToString(),this.txtIDCard.Text.Trim().ToString(),
                         this.txtReaderID.Text.Trim().ToString());

            //执行修改
            int iRet = DBHelper.ExecuteNonQuery(sql);

            if(iRet == 1)
            {
                valid = true;

                StaticStore.loginName = this.txtReaderName.Text.Trim().ToString();
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //检查用户的合法输入性
            if (CheckInput())
            {
                //判断密码
                if (this.pwd.ToLower().Equals(this.txtOldPwd.Text.Trim().ToLower()))
                {
                    string message = "修改失败！";
                    if(this.UpdateReaderInfo())
                    {
                        message = "修改成功！";
                        this.txtOldPwd.Clear();
                        this.txtNewPwd.Clear();
                        this.txtOldPwd.Focus();
                    }
                    MessageBox.Show(message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("登录密码与原密码不一致！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        #endregion
    }
}
