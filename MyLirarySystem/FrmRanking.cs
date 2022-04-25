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
    /// 排行榜
    /// </summary>
    public partial class FrmRanking : MetroForm
    {
        public FrmRanking()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "//CalmnessColor2.ssk";
        }

        /// <summary>
        /// 排行榜页面窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRanking_Load(object sender, EventArgs e)
        {
            ShowRanking();
        }

        /// <summary>
        /// 图表
        /// </summary>
        public void ShowRanking()
        {
            string sql = string.Format(@"select Book.BookName,count(borrow.BookID) from Book
                            inner join BookClass on BookClass.ClassID = Book.ClassID
                            inner join BookType on Book.BookTypeID = BookType.BookTypeID
                            inner join Books on Book.ID = Books.ID
                            inner join Borrow on Books.BookID = Borrow.BookID
                            where books.BookID
                            in (select top 5 BookID from Borrow group by BookID order by count(BookID) desc)
                            group by Book.BookName
                            order by count(borrow.BookID) desc");

            SqlDataReader dr = DBHelper.ExecuteReader(sql);

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
                g.DrawString(Convert.ToString(i * 5), new Font("Times New Roman", 10, FontStyle.Regular), new SolidBrush(Color.Black), 20, this.panel1.Height - 27 - i * 20);
            }

            for (int j = 0; j < 10; j++)
            {
                g.DrawLine(p, 50, this.panel1.Height - 20, 50, 10);            //绘制垂直线条
                if (dr.Read())
                {
                    int x, y, w, h;                                    //声明变量存储坐标和大小
                    g.DrawString(dr[0].ToString(), new Font("黑体", 8, FontStyle.Regular), new SolidBrush(Color.Black), 50 + 100 * j, this.panel1.Height - 16); //绘制商品名称
                    x = 50 + 100 * j;                                    //X坐标
                    y = this.panel1.Height - 20 - Convert.ToInt32((Convert.ToDouble(Convert.ToDouble(dr[1].ToString()) * 20 / 10)));//Y坐标
                    w = 24;                                        //宽度

                    //
                    h = Convert.ToInt32(Convert.ToDouble(dr[1].ToString()) * 20 / 10);//高度


                    g.FillRectangle(new SolidBrush(Color.LightSkyBlue), x, y, w, h);    //绘制柱形图

                    //
                    g.DrawString((h * 10 / 20).ToString(), new Font("宋体", 8, FontStyle.Bold), new SolidBrush(Color.DarkOrange), new Point(x + 5, y - 10));     //在柱形图指定的位置绘制文字
                }
            }
            this.panel1.BackgroundImage = bitM;       //显示绘制的图形
            dr.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
