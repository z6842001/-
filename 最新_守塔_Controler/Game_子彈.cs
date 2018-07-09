using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 最新_守塔_Model;
using System.Windows.Forms;

namespace 最新_守塔_Controler
{
    class Game_子彈:I子彈
    {
        IControler Controler;
        IGame_傷害特效 特效;
        Timer I子彈;

        List<Point> 子彈_位置 = new List<Point>();      //子彈

        public List<Point> 子彈位置
        {
            get { return 子彈_位置; }
            set { 子彈_位置 = value; }
        }

        public Timer Timer_子彈 => I子彈;

       

        public Game_子彈(Controler controler,IGame_傷害特效 _特效)
            {
            特效 = _特效;
                Controler = controler;
            I子彈 = new Timer();
            I子彈.Enabled = true;
            I子彈.Tick += new EventHandler(子彈移動);
            I子彈.Interval = 10;

        }

        public void 發射子彈()
        {
            子彈_位置.Add(new Point(40, 220));
            特效.SuperMan_Hit();
        }

        private void 子彈移動(object sender,EventArgs e)
        {
            Point x = new Point();

            for (int i = 0; i < 子彈_位置.Count; i++)
            {

                x = 子彈_位置[i];
                x.X += 10;
                子彈_位置[i] = x;
            }
            子彈_位置.Sort(delegate (Point s1,Point s2)
            {
                return s2.X.CompareTo(s1.X);
            });
            子彈消失();
        }



        private void 子彈消失()
        {
            for(int i = 0;i<子彈_位置.Count;i++)
            {
                if(子彈_位置[i].X>=Controler.Get_Width)
                {
                    子彈_位置.RemoveAt(i);
                }
                //else if(子彈_位置[i].X >= (Controler.Get_Monster_amount == 0 ? 9999 : Controler.Get_MonsterPoint.X) && 子彈_位置[i].X < (Controler.Get_Monster_amount == 0 ? 9999 : Controler.Get_MonsterPoint.X+50))
                //{
                //    子彈_位置.RemoveAt(i);
                //}
            }
            

        }


            
        //public List<Point> 子彈移動(List<Point>)
        //{
        //    Point x = new Point();
        //    try
        //    {
        //        for (int i = 0; i < 子彈_位置.Count; i++)
        //        {

        //            x = 子彈_位置[i];
        //            x.X += 5;
        //            子彈_位置[i] = x;

        //            if (x.X > this.Width)
        //            {
        //                子彈_位置.RemoveAt(i);
        //                i--;
        //            }
        //            else if (Monster.Count > 0)
        //            {
        //                if ((x.X + 10) > Monster[0].Get_怪物位置X() && (x.X + 30) < Monster[0].Get_怪物位置X() + 50)
        //                {
        //                    傷害 = random.Next(1, 10000000);
        //                    子彈_位置.RemoveAt(i);
        //                    i--;
        //                    Game.Hit(Monster[0], 傷害);
        //                    Game.hit = true;
        //                }

        //                //count++;
        //            }

        //            // else
        //            //  count++;
        //        }
        //        if (Game.hit)
        //            Game.結束打擊();
        //        //Parallel.For(0,(子彈_位置.Count-1), i =>
        //        //{
        //        //    x = 子彈_位置[i];
        //        //    x.X += 30;
        //        //    子彈_位置[i] = x;

        //        //    if (x.X > this.Width)
        //        //    {
        //        //        子彈_位置.RemoveAt(i);
        //        //        i--;
        //        //    }
        //        //    else if (Monster.Count > 0)
        //        //    {
        //        //        if ((x.X + 40) > Monster[0].怪物位置X())
        //        //        {
        //        //            子彈_位置.RemoveAt(i);
        //        //            i--;
        //        //            Game.Hit(Monster[0], 2);
        //        //        }
        //        //        //count++;
        //        //    }
        //        //});
        //    }
        //    catch
        //    {
        //        //  MessageBox.Show("!!");
        //    }
        //}

    }
}
