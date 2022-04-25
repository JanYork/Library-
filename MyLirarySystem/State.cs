using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLirarySystem
{
    /// <summary>
    /// 图书状态枚举
    /// </summary>
    public enum BookState
    { 
        可借 = 1,
        已借,
        不可借,
        已预订,
        可预订,
    }
}
