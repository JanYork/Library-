using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Drawing.Drawing2D;
using MailVeriCode;
using System.Net;

namespace MyLirarySystem
{
    /// <summary>
    /// MyLibrary 登录窗体
    /// </summary>
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public const string HINT = "提示";
        public const string ERROR = "错误";

        #region 全局定义计控件与验证码
        /// <summary>
        ///  定义控件全局
        /// </summary>    
        int seconds1 = 60;//倒计时60s
        int seconds2 = 60 * 2;//验证码有效时间2分钟
        string strMailVeriCode;//验证码
        #endregion

        #region 取消
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //退出登录判断
            if (DialogResult.Yes == MessageBox.Show("确定取消登录吗？", HINT, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
        #endregion

        #region 获取登录类型
        /// <summary>
        /// 获取登录类型
        /// </summary>
        /// <returns>true:管理员；false:读者</returns>
        private bool LoginType()
        {
            //默认为管理员
            bool valid = true;
            
            //管理员
            if(this.rbManager.Checked)
            {
                valid = true;
                
                //存储登录类型
                StaticStore.loginType = true;
            }

            //读者
            if(this.rbReader.Checked)
            {
                valid = false;

                //存储登录类型
                StaticStore.loginType = false;
            }

            return valid;
        }
        #endregion

        #region 判断输入的有效性
        /// <summary>
        /// 判断输入的有效性
        /// </summary>
        /// <returns>true or false</returns>
        public bool InputCheck()
        {
            //默认输入无效
            bool valid = false;

            if (this.txtLoginID.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入登录账号！",HINT,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.txtLoginID.Focus();
            }
            else if (this.txtPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入登录密码！", HINT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtPwd.Focus();
            }
            else
            {
                valid = true;
            }

            return valid;
        }
        #endregion

        #region 管理员登录
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <returns></returns>
        private bool ManagerLogin()
        {
            //默认登录登录失败
            bool isValid = false;

            string sql = string.Format(@"select ManagerID from admin 
                            where ManagerID = '{0}' and Pwd = '{1}';",
                            this.txtLoginID.Text.Trim().ToString(), this.txtPwd.Text.Trim().ToString());

            string iRet = Convert.ToString(DBHelper.ExecuteScalar(sql));

            if (!iRet.Equals(string.Empty) && !iRet.Equals("-1"))
            {
                //存储登录用户名
                StaticStore.loginName = "管理员："+iRet;
                StaticStore.managerID = this.txtLoginID.Text.Trim().ToString();
                isValid = true;
            }

            return isValid;
        }
        #endregion

        #region 读者登录
        /// <summary>
        /// 读者登录
        /// </summary>
        /// <returns></returns>
        private bool ReaderLogin()
        {
            //默认登录登录失败
            bool isValid = false;

            string sql = string.Format(@"select ReaderName from Reader 
                            where ReaderID = '{0}' and Pwd = '{1}';",
                            this.txtLoginID.Text.Trim().ToString(), this.txtPwd.Text.Trim().ToString());

            string iRet = Convert.ToString(DBHelper.ExecuteScalar(sql));

            if (!iRet.Equals(string.Empty) && !iRet.Equals("-1"))
            {
                //存储登录用户名
                StaticStore.loginName = "读者："+iRet;
                StaticStore.readerID = this.txtLoginID.Text.Trim().ToString();
                isValid = true;
            }

            return isValid;
        }
        #endregion

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string mailVeriCode = txtMailVeriCode.Text.Trim();//邮箱验证码  

            //判断验证码
            if (string.IsNullOrEmpty(mailVeriCode) == true)
            {
                MessageBox.Show("请输入验证码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMailVeriCode.Focus();
            }
            else if (mailVeriCode.ToLower() != strMailVeriCode.ToLower())//判断邮箱验证码是否输入正确；不区分字母大小写
            {
                MessageBox.Show("您输入的验证码有误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMailVeriCode.Focus();
                return;
            }
            else
            {
                //判断输入有效性
                if (this.InputCheck())
                {
                    //判断登录类型
                    if (this.LoginType())
                    {
                        //判断是否登录成功
                        if (this.ManagerLogin())
                        {
                            //管理员登录
                            StaticStore.IsLogin = true;
                            StaticStore.loginType = true;
                            this.Close();
                        }
                        else
                        {
                            //修改为未登录
                            StaticStore.IsLogin = false;
                            StaticStore.loginType = false;
                            MessageBox.Show("登录账号或密码不正确", HINT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtPwd.Clear();
                            this.txtPwd.Focus();
                        }
                    }
                    else
                    {
                        //判断是否读者登录成功
                        if (this.ReaderLogin())
                        {
                            //读者类型登录
                            StaticStore.IsLogin = true;
                            StaticStore.loginType = false;
                            FrmReaderMain frmReaderMain = new FrmReaderMain();
                            this.Close();
                            frmReaderMain.ShowDialog();
                        }
                        else
                        {
                            //未登录
                            StaticStore.IsLogin = false;
                            StaticStore.loginType = false;
                            MessageBox.Show("登录账号或密码不正确", HINT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtPwd.Clear();
                            this.txtPwd.Focus();
                        }
                    }
                }
            }
        }

        #endregion

        #region 通过图片选中管理员登录
        /// <summary>
        /// 通过图片选中管理员登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbManager_Click(object sender, EventArgs e)
        {
            this.rbManager.Checked = true;
        }
        #endregion

        #region 通过图片选中读者登录
        /// <summary>
        /// 通过图片选中读者登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbReader_Click(object sender, EventArgs e)
        {
            this.rbReader.Checked = true;
        }
        #endregion

        #region 注册
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblzhuce_Click(object sender, EventArgs e)
        {
            FrmReaderAdd frmReaderAdd = new FrmReaderAdd();
            frmReaderAdd.ShowDialog();
        }
        #endregion

        #region 获取验证码
        /// <summary>
        /// 获取验证码事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMailVeriCode_Click_1(object sender, EventArgs e)
        {
            string recEMailAddress = txtLoginID.Text.Trim();//收件人邮箱             

            strMailVeriCode = MailVeriCodeClass.CreateRandomMailCode(6);
            string strBody = "验证码：" + strMailVeriCode + " \n该验证码2分钟内有效,请勿泄漏于他人。如非本人操作，请忽略。\n系统邮件请勿回复。";//邮件内容            
            string strSubject = "【极简图书】注册验证";//邮件标题
            string strMyEmailAddress = "747945307@qq.com";//发件人邮箱
            string strAuthorizationCode = "klxtv****furbbag";//邮箱授权码

            if (string.IsNullOrEmpty(recEMailAddress))//判断是否输入了邮箱
            {
                MessageBox.Show("请输入邮箱！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginID.Focus();
            }
            else if (MailVeriCodeClass.CheckAllMail(recEMailAddress) == false)//判断邮箱格式是否正确
            {
                MessageBox.Show("您输入的邮箱有误，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoginID.Focus();
                return;
            }
            else//发送验证码
            {
                //发送
                if (MailVeriCodeClass.SendMailMessage(strMyEmailAddress, recEMailAddress, strSubject, strBody, strAuthorizationCode) == true)
                {
                    btnMailVeriCode.Enabled = false;

                    //计时器初始化              
                    timer1.Interval = 1000;
                    timer1.Start();
                    timer2.Interval = 1000;
                    timer2.Start();

                }
                else
                {
                    txtLoginID.Focus();
                }
            }
        }
        /// <summary>
        /// 按钮控件获取验证码后计时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds1 > 0)
            {
                seconds1--;
                btnMailVeriCode.Text = seconds1.ToString();
            }
            else
            {
                timer1.Stop();

                btnMailVeriCode.Text = ":-)";
                btnMailVeriCode.Enabled = true;
            }
        }

        /// <summary>
        /// 验证码过期事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (seconds2 == 0)
            {
                timer2.Stop();
                //旧的验证码过期,生成一个新的验证码
                strMailVeriCode = MailVeriCodeClass.CreateRandomMailCode(6);
            }
        }
        #endregion

        #region 获取QQ头像方法
        /// <summary>
        /// 获取QQ头像和随机头像
        /// </summary>
        private void UpdataAvatar()
        {
            //邮箱
            string UserEmail = this.txtLoginID.Text.Trim();
            //邮箱后缀
            string EmailSuffix = UserEmail.Substring(UserEmail.IndexOf("@"));
            string www = UserEmail.Substring(UserEmail.IndexOf("."));
            if (IsNetWorkConnect())
            {

                if (EmailSuffix.Equals("@qq.com"))
                {
                    //获取QQ号
                    string QQ = UserEmail.Substring(0, UserEmail.IndexOf("@"));
                    //获取头像链接
                    string QQ_imger = "http://q1.qlogo.cn/g?b=qq&nk="+QQ+"&s=640";
                    Image _image = Image.FromStream(WebRequest.Create(QQ_imger).GetResponse().GetResponseStream());
                    this.PicBoxForQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    //图像显示适应的大小
                    this.PicBoxForQQ.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.PicBoxForQQ.Image = _image;
                }
                else
                {
                    Image _image = Image.FromStream(WebRequest.Create("https://cdn.ideaopen.cn/JanYork/JahIVuYo.jpg").GetResponse().GetResponseStream());
                    this.PicBoxForQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    //图像显示适应的大小
                    this.PicBoxForQQ.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.PicBoxForQQ.Image = _image;
                }
            }
        }
        #endregion

        #region 调用头像与随机图API
        /// <summary>
        /// 调用获取QQ头像方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLoginID_TextChanged(object sender, EventArgs e)
        {
            string Email = txtLoginID.Text;
            if (txtLoginID.Text.Length > 5 && MailVeriCodeClass.CheckAllMail(Email))
            {
                //调用验证QQ邮箱正则
                if (MailVeriCodeClass.CheckMail(Email))
                {
                    UpdataAvatar();
                }
                else
                {
                    if (IsNetWorkConnect())
                    {
                        //左侧头像
                        this.PicBoxForQQ.BackgroundImage = null;
                        Image _image1 = Image.FromStream(WebRequest.Create("http://test.inis.cn/api/file/random").GetResponse().GetResponseStream());
                        this.PicBoxForQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        //图像显示适应的大小
                        this.PicBoxForQQ.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.PicBoxForQQ.Image = _image1;
                    }
                }
            }
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plLogin_Paint(object sender, PaintEventArgs e)
        {
            //头像圆形
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(PicBoxForQQ.ClientRectangle);
            Region region = new Region(gp);
            PicBoxForQQ.Region = region;
            gp.Dispose();
            region.Dispose();
        }
        #endregion

        #region 清除控件内容事件
        /// <summary>
        /// 点击清除控件内容
        /// 同时联网情况下获取动态gif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLoginID_Click(object sender, EventArgs e)
        {
            if (IsNetWorkConnect())
            {
                //左下角动画
                this.pictureBox2.BackgroundImage = null;
                Image _image2 = Image.FromStream(WebRequest.Create("https://cdn.ideaopen.cn/JanYork/JahIVuYo.jpg").GetResponse().GetResponseStream());
                this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                //图像显示适应的大小
                this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox2.Image = _image2;
            }

            if (this.txtLoginID.Text.Length > 0)
            {
                this.txtLoginID.Clear();
            }
        }
        #endregion

        #region 判断接入互联网
        //调用操作系统API 
        [System.Runtime.InteropServices.DllImport("wininet")]
        private extern static bool InternetGetConnectedState(out int connectionDescription, int reservedValue);

        /// <summary>
        /// 判断是否连接到外网
        /// </summary>
        private static bool IsNetWorkConnect()
        {
            int i = 0;
            return InternetGetConnectedState(out i, 0) ? true : false;
        }
        #endregion

        #region 获取左侧头像
        /// <summary>
        /// 获取gif头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPwd_Click(object sender, EventArgs e)
        {
            if (IsNetWorkConnect())
            {
                this.pictureBox2.BackgroundImage = null;
                Image _image = Image.FromStream(WebRequest.Create("https://cdn.ideaopen.cn/JanYork/iCTFeI3H.jpg").GetResponse().GetResponseStream());
                this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                //图像显示适应的大小
                this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox2.Image = _image;
            }
        }

        /// <summary>
        /// 获取gif头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMailVeriCode_Click(object sender, EventArgs e)
        {
            if (IsNetWorkConnect())
            {
                this.pictureBox2.BackgroundImage = null;
                Image _image = Image.FromStream(WebRequest.Create("https://cdn.ideaopen.cn/JanYork/7M2O0kpz.gif").GetResponse().GetResponseStream());
                this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                //图像显示适应的大小
                this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox2.Image = _image;
            }
        }
        #endregion
    }
}