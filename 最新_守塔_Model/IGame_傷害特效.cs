using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 最新_守塔_Model
{
   public  interface IGame_傷害特效
    {

        Bitmap[] 特效圖_Bitmap { get; }


        /*上面測試用 給特效2**/



        void Add();
        Bitmap 組合特效();
        Bitmap 飛鏢 { get; }
        Point SuperMan_Point { get; }

        void SuperMan_Hit();
        void SuperMan_NotHit();
    }
   public class 打擊特效List
    {
        public float 透明度 { get; set; }
        public int 順序 { get; set; }

        public 打擊特效List()
        {
            透明度 = 0;
            順序 = 0;
        }

    }





}
