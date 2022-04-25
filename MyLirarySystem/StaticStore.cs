using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLirarySystem
{
    static class StaticStore
    {
        //存储登录用户名
        public static string loginName = "尚未登录";

        //存储读者登录账号
        public static string readerID = string.Empty;

        //存储管理员账号
        public static string managerID = string.Empty;

        //判断是否登录
        public static bool IsLogin = false;

        //存储登录类型
        public static bool loginType = false;//false:读者；true：管理员
    }
}
