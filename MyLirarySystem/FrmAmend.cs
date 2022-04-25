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
    /// 管理员修改信息
    /// </summary>
    public partial class FrmAmend : MetroForm
    {
        string STR = @"Data Source=.;Initial Catalog=MyLibrary;Integrated Security=True";
        public FrmAmend()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//CalmnessColor2.ssk";
        }

        private string oPwd = string.Empty;

        #region 返回
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btoRutern_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 修改
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btoAmend_Click(object sender, EventArgs e)
        {
            string ID = this.txtAccount.Text.Trim();
            string mima = this.txtXingPwd.Text.Trim();           
            //修改之前要判断是否为空
            if(this.InputCheck())
            {             
                SqlConnection conn = new SqlConnection(STR);
                //编写SQL语句，进行修改
                string sql = string.Format(@"update Admin set pwd = '{0}' where ManagerID = {1}", ID, mima);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int jg = cmd.ExecuteNonQuery();
                    if (jg > 0)
                    {
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtPwd.Clear();
                        this.txtXingPwd.Clear();
                        this.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion

        #region 获取登录密码
        /// <summary>
        /// 获取登录密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginPwd()
        {
            //先查出密码，在获取登录的密码
            string sql = @"select Pwd from Admin where ManagerID=" + StaticStore.managerID;

            if (!DBHelper.ExecuteScalar(sql).ToString().Equals("-1"))
            {
                this.oPwd = DBHelper.ExecuteScalar(sql).ToString();
            }
        }
        #endregion

        #region  检查输入的有效性
        /// <summary>
        /// 检查输入的有效性，非空验证
        /// </summary>
        /// <returns></returns>
        public bool InputCheck()
        {
            bool valid = false;
            if(this.txtPwd.Text.Trim().Equals(string.Empty))
            {              
                this.txtPwd.Focus();
                MessageBox.Show("请输入密码！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (this.txtXingPwd.Text.Trim().Equals(string.Empty))
            {
                this.txtPwd.Focus();
                MessageBox.Show("请输入密码！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (!this.txtPwd.Text.Trim().Equals(this.oPwd))
            {
                MessageBox.Show("密码与登录密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Clear();
                this.txtXingPwd.Clear();
                this.txtPwd.Focus();
            }
            else
            {                
                valid = true;
            }
            
            return valid;
        }
        #endregion

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAmend_Load(object sender, EventArgs e)
        {
            this.txtAccount.Text = StaticStore.managerID.ToString();
            
            this.LoginPwd();
        }
        #endregion
    }
}
