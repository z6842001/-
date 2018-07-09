using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最新_守塔_Model
{
    public interface IUser_Information
    {
            int 傷害點 { get; set; }
            int 敏捷點 { get; set; }
            int 暴率點 { get; set; }
            int 暴擊傷害點 { get; set; }
            int 剩餘點數 { get; set; }
            int 等級 { set; }
    }
}
