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

namespace MyLirarySystem
{
    /// <summary>
    /// 关于我们的窗体
    /// </summary>
    public partial class FrmAboutUs : MetroForm
    {
        public FrmAboutUs()
        {
            InitializeComponent();
            //皮肤加载方法
           // //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ////this.skinEngine1.SkinFile = Application.StartupPath + "//CalmnessColor2.ssk";
        }
        /// <summary>
        /// 点击确定事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            //点击之后关闭这个窗口
            this.Close();
        }

     
    }
}
