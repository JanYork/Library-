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
    /// 图书类型统计
    /// </summary>
    public partial class FrmChart : MetroForm
    {
        public FrmChart()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ////this.skinEngine1.SkinFile = Application.StartupPath + "//CalmnessColor2.ssk";
        }

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmChart_Load(object sender, EventArgs e)
        {
            ShowChart();
        }
        #endregion

        #region 图表
        /// <summary>
        /// 图表
        /// </summary>
        public void ShowChart()
        {

            DBHelper.ConnectionOpen();

            string sql = string.Format(@"select classname,count(*) from Book,BookClass where book.ClassID = BookClass.ClassID group by book.ClassID,ClassName");

            SqlCommand cmd = new SqlCommand(sql, DBHelper.Connection);
            SqlDataReader dr = cmd.ExecuteReader();

            Bitmap bitM = new Bitmap(this.panel1.Width, this.panel1.Height);    //创建画布
            Graphics g = Graphics.FromImage(bitM);                        //创建Graphics对象
            Pen p = new Pen(new SolidBrush(Color.SlateGray), 1.0f);            //创建Pen对象
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;        //设置虚线
            g.Clear(Color.White);                                    //设置画布颜色
            for (int i = 0; i < 25; i++)
            {
                //绘制水平线条


                g.DrawLine(p, 50, this.panel1.Height - 20 - i * 20, this.panel1.Width - 20, this.panel1.Height - 20 - i * 20);
                //绘制商品的增长值
                g.DrawString(Convert.ToString(i * 10), new Font("Times New Roman", 10, FontStyle.Regular), new SolidBrush(Color.Black), 20, this.panel1.Height - 27 - i * 20);
            }

            for (int j = 0; j < 10; j++)
            {
                g.DrawLine(p, 50, this.panel1.Height - 20, 50, 10);            //绘制垂直线条
                if (dr.Read())
                {
                    int x, y, w, h;                                    //声明变量存储坐标和大小
                    g.DrawString(dr[0].ToString(), new Font("宋体", 9, FontStyle.Regular), new SolidBrush(Color.Black), 76 + 60 * j, this.panel1.Height - 16); //绘制商品名称
                    x = 78 + 60 * j;                                    //X坐标
                    y = this.panel1.Height - 20 - Convert.ToInt32((Convert.ToDouble(Convert.ToDouble(dr[1].ToString()) * 20 / 10)));//Y坐标
                    w = 24;                                        //宽度
                    
                    //
                    h = Convert.ToInt32(Convert.ToDouble(dr[1].ToString()) * 20 / 10);//高度


                    g.FillRectangle(new SolidBrush(Color.MediumSpringGreen), x, y, w, h);    //绘制柱形图

                    //
                    g.DrawString((h * 10 / 20).ToString(), new Font("宋体", 8, FontStyle.Bold), new SolidBrush(Color.Purple), new Point(x + 5, y - 10));     //在柱形图指定的位置绘制文字
                }
            }
            this.panel1.BackgroundImage = bitM;                        //显示绘制的图形
        }
        #endregion

        #region 确定
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
