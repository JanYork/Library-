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
    /// 添加管理员窗体
    /// </summary>
    public partial class FrmAddition : MetroForm
    {
        string STR = @"Data Source=.;Initial Catalog=MyLibrary;Integrated Security=True";
        public FrmAddition()
        {
            InitializeComponent();     
        }

        #region  检查输入的有效性，非空验证
        /// <summary>
        /// 检查输入的有效性，非空验证
        /// </summary>
        /// <returns></returns>
        public bool InputCheck()
        {
            bool valid = false;           
            if (this.txtPwd.Text.Trim().Equals(string.Empty))
            {                     
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
            }          
            else if (this.txtYesPwd.Text.Trim().Equals(string.Empty))
            {                                              
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtYesPwd.Focus();
            }           
            else if (!this.txtPwd.Text.Trim().Equals(this.txtYesPwd.Text.Trim()))
            {              
                MessageBox.Show("密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                this.txtYesPwd.Clear();             
                this.txtPwd.Clear();
                this.txtPwd.Focus();
            }
            else
            {
                valid = true;
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
        private void butAddition_Click(object sender, EventArgs e)
        {
            //执行添加操作前，需要非空验证
            if (this.InputCheck())
            {
                string pwd = this.txtPwd.Text.Trim();
                //编写SQL语句，执行添加操作
                string sql = string.Format(@"insert into Admin values('{0}');select @@identity;",pwd);  
                //连接对象
                SqlConnection conn = new SqlConnection(STR);
                try
                {
                    conn.Open();
                    //使用Comand()执行命令
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //返回单行单列
                    int jg = Convert.ToInt32(cmd.ExecuteScalar());
                    if (jg > 0)
                    {
                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtYesPwd.Clear();
                        this.txtPwd.Clear();
                        this.txtPwd.Focus();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                { 
                    //关闭数据库
                    conn.Close();
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
        private void butCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
       
    }
}
