using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 最新_守塔_Model;
using System.Threading;

namespace 最新_守塔_Controler
{
     interface 繪圖
    {  
        void 繪圖();
    }
    class _繪圖:繪圖
    {
        IfrmMain View;
        IGame_傷害數字 傷害數字;
        IMonster Monster;
       
        I子彈 子彈;
        IGame_傷害特效 特效;
        IGame_User能力 能力;
        Bitmap SuperMan;

        Bitmap 經驗底線;

        Point Point = new Point(9999, 9999);
      public _繪圖(IfrmMain _View, IGame_傷害數字 _傷害數字, IMonster _Monster, I子彈 _子彈,IGame_傷害特效 _特效,IGame_User能力 _能力)
        {
            View = _View;
            傷害數字 = _傷害數字;
            Monster = _Monster;
            
            子彈 = _子彈;
            特效 = _特效;
            能力 = _能力;
            SuperMan = new Bitmap(Properties.Resources.超人, 200, 150);
            Pen pen_write = new Pen(Color.White, 30);

            經驗底線 = new Bitmap(1920,30);
            using (var g = Graphics.FromImage(經驗底線))
            {
                
                int x = (int)(View._width / 10);
                for(int y = x;y<View._width;y+=x)
                { 
                    g.DrawLine(pen_write, new Point(y,0), new Point(y+2,0));
                }

            }

        }

        private Point 轉換EXP長度()
        {
            Point size = new Point(0, 340);
            int width = View._width;


            decimal x = (decimal)width * (decimal)double.Parse(能力.取得目前經驗百分比數)/(decimal)100;
            size.X = (int)x;

            return size;
        }





        public void 繪圖()
        {
            Pen pen = new Pen(Color.Yellow, 30);
            Pen pen_Black = new Pen(Color.Black, 30);
            
            using (var g = Graphics.FromImage(View.bitmap))
            {
                g.Clear(Color.Transparent);  //清除


                子彈.子彈位置.ForEach(a => g.DrawImage(特效.飛鏢, a.X, a.Y));
                //子彈.子彈位置.ForEach(a => g.FillEllipse((子彈.子彈位置.IndexOf(a) % 2 == 1 ? Brushes.Red : Brushes.Blue), a.X, a.Y, 20, 20));

                //g.DrawImage(Monster.Monster_Image, 0, 0);
                Monster.Monster_Information.ForEach(a => g.DrawImage(Properties.Resources.怪, a.point));


                Bitmap 傷害文字 = 傷害數字.組合數字();
              //  Bitmap 傷害特效 = 傷害特效.
                    if ( Monster.Monster_Information.Count != 0)
                    {
                        Point = new Point(Monster.Monster_Information[0].point.X + (Properties.Resources.怪.Width / 2) - (傷害文字.Width / 2), 0);

                        g.DrawImage(傷害文字,Point.X,0);

                    foreach(var 特效 in 特效.特效圖_Bitmap)
                        if(特效!=null)
                        g.DrawImage(特效, Monster.Monster_Information[0].point.X-40, Monster.Monster_Information[0].point.Y-40);
                    }
                    else 
                    g.DrawImage(傷害文字, Point.X, 0);
                //}
                //   g.FillRectangle(Brushes.Red, 300, 20, game_雜.Monster_目前血槽寬度(Monster[0], level), 50);


                g.DrawImage(SuperMan,特效.SuperMan_Point);
                g.DrawLine(pen_Black, new Point(0, 340),new Point(View._width,340));
                g.DrawLine(pen, new Point(0, 340), 轉換EXP長度());
                g.DrawImage(經驗底線, 0, 340);
            }



        }

    }
}
