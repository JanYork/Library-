using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLirarySystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmBorrowRecord());
            Application.Run(new FrmMain());
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmBooksInfo());
            //Application.Run(new FrmBookInfoManager());
            //Application.Run(new FrmManageReader());
            //Application.Run(new FrmOverdue());
            //Application.Run(new FrmBorrowAndReturn());
            //Application.Run(new FrmBorrowRecord());
            //Application.Run(new FrmBookAdd());
            //Application.Run(new FrmReaderMain());
            // Application.Run(new FrmPhiloloy());
            //Application.Run(new FrmRecommend());
            //Application.Run(new FrmPhiloloy());
            //Application.Run(new FrmReaderAdd());
            //Application.Run(new FrmBookUpdate());
            //Application.Run(new FrmBookputaway());
            //Application.Run(new FrmRecommend());
        }
    }
}
