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
    /// 添加读者窗体
    /// </summary>
    public partial class FrmReaderAdd : MetroForm
    {
        public FrmReaderAdd()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }

        #region 检查数据输入的有效性
        /// <summary>
        /// 非空验证
        /// </summary>
        public bool CheckInput()
        {
            string message = string.Empty;

            bool valid = false;

            if (this.txtReaderName.Text.Trim().Equals(string.Empty))
            {
                message = "请输入姓名！";
                this.txtReaderName.Focus();
            }
            else if (this.txtPwd.Text.Trim().Equals(string.Empty))
            {
                message = "请输入密码！";
                this.txtPwd.Focus();
            }
            else if (this.txtNewPwd.Text.Trim().Equals(string.Empty))
            {
                message = "请输入再次密码！";
                this.txtNewPwd.Focus();
            }
            else if (this.txtIDCard.Text.Trim().Equals(string.Empty) || this.txtIDCard.Text.Trim().Length < 18)
            {
                message = "请输入有效身份证！";
                this.txtIDCard.Clear();
                this.txtIDCard.Focus();
            }
            else if (this.txtAddress.Text.Equals(string.Empty))
            {
                message = "请输入有效地址！";
                this.txtAddress.Focus();
            }
            else if (this.txtPhone.Text.Trim().Equals(string.Empty))
            {
                message = "请输入有效联系方式！";
                this.txtPhone.Focus();
            }
            else if(!this.txtPwd.Text.Trim().ToLower().Equals(this.txtNewPwd.Text.Trim().ToLower()))
            {
                message = "两次密码不一致！";
                this.txtNewPwd.Focus();
            }
            else
            {
                return true;
            }

            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return valid;
        }
        #endregion

        #region 添加操作
        /// <summary>
        /// 添加操作
        /// </summary>
        /// <returns></returns>
        public bool AddReader()
        {
            bool valid = false;

            //添加语句
            string sql = string.Format(@"insert into Reader(ReaderName,Pwd,Phone,Address,IDCard) 
                           values('{0}','{1}','{2}','{3}','{4}');select @@identity;",this.txtReaderName.Text.Trim().ToString(),
                           txtPwd.Text.Trim().ToString(),this.txtPhone.Text.Trim().ToString(),
                           this.txtAddress.Text.Trim().ToString(),this.txtIDCard.Text.Trim().ToString());

            //执行
            int readerID = Convert.ToInt32(DBHelper.ExecuteScalar(sql));
            //判断是否添加成功
            if(readerID > 0)
            {
                //将值赋值给读者卡号文本框
                this.txtReaderID.Text = readerID.ToString();
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            //检查用户的输入是否有效
            if(this.CheckInput())
            {
                
                //判断身份证是否有效
                if(!this.IsIDcard(this.txtIDCard.Text.ToString()))
                {
                    MessageBox.Show("请输入有效身份证！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //重置数据
                    this.txtReaderName.Clear();
                    this.txtReaderName.Focus();
                    this.txtPwd.Clear();
                    this.txtNewPwd.Clear();
                    this.txtIDCard.Clear();
                    this.txtPhone.Clear();
                    this.txtAddress.Clear();
                    return;
                }

                //判断是否添加成功
                if (this.AddReader())
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //重置数据
                    this.txtReaderName.Clear();
                    this.txtReaderName.Focus();
                    this.txtPwd.Clear();
                    this.txtNewPwd.Clear();
                    this.txtIDCard.Clear();
                    this.txtPhone.Clear();
                    this.txtAddress.Clear();
                    this.Close();
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

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReaderAdd_Load(object sender, EventArgs e)
        {
            this.txtReaderName.Focus();

            this.txtIDCard.Text = "身份证为18位有效字符";
        }
        #endregion

        #region 验证身份证的有效性
        /// <summary>
        /// 验证身份证的有效性
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        private bool IsIDcard(string idCard)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(idCard, @"(^\d{18}$)|(^\d{15}$)");
        }
        #endregion

        #region 身份证输入框提示
        /// <summary>
        /// 身份证输入框提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIDCard_TextChanged(object sender, EventArgs e)
        {
            if (this.txtIDCard.Text.Trim().Equals("身份证为18位有效字符"))
            {
                this.txtIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.txtIDCard.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
            else
            {
                this.txtIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                this.txtIDCard.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }
        #endregion

        #region 当身份证输入框为空时，显示提示信息
        /// <summary>
        /// 当身份证输入框为空时，显示提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIDCard_Leave(object sender, EventArgs e)
        {
            if (this.txtIDCard.Text.Trim().Equals(string.Empty))
            {
                this.txtIDCard.Text = "身份证为18位有效字符";
                this.txtIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.txtIDCard.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }
        #endregion

        #region 输入框点击事件
        /// <summary>
        /// 输入框点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIDCard_Click(object sender, EventArgs e)
        {
            //清空身份证输入框，并获取焦点
            this.txtIDCard.Clear();
            this.txtIDCard.Focus(); 
        }
        #endregion
    }
}
