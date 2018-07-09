using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 最新_守塔_Other
{
    public class Other_AutoGif
    {

        Bitmap[] map;
        Size Size;
        int count = 0;
        int 次數 = 0;
        public Other_AutoGif(Bitmap[] x, Size size)
        {
            map = x;
            Size = size;



        }

        public Bitmap NextBitmap()
        {
            Bitmap a;
           
            int length = map.Length;
            
            if (count < length)
            {
                次數++;
                a = new Bitmap(map[count], Size.Width, Size.Height);
               if(次數>10)
                { 
                    count++;
                    次數 = 0;
                }

            }
            else
            {
                次數++;
                if (次數 > 10)
                {
                    count = 0;
                    次數 = 0;
                    a = new Bitmap(map[count], Size.Width, Size.Height);
                }
                else
                    a = new Bitmap(map[11], Size.Width, Size.Height);
            }
           // a.MakeTransparent(Color.Transparent);
            return a;

        }



    }
}
