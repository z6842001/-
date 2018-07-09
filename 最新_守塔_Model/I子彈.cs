using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 最新_守塔_Model
{
    public interface I子彈
    {
         List<Point> 子彈位置 { get; set; }
        /// <summary>
        /// 顧名思義 就是射了~
        /// </summary>
        void 發射子彈();


        Timer Timer_子彈 { get; }
    }
}
