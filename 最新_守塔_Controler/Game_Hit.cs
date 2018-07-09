using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 最新_守塔_Model;
using System.Windows.Forms;
namespace 最新_守塔_Controler
{
    class Game_Hit: IGame_Hit
    {
        IMonster Monster;
        I子彈 子彈;
        IGame_User能力 能力;
        Timer Check_Attack;
        IGame_傷害數字 Show_Number;
        IfrmMain Main;
        IGame_傷害特效 特效;
        Random random = new Random();


        static string yy = "0";
        private void 造成攻擊(object sender,EventArgs e)
        {
            Monster.Monster_Die();
            foreach(var monster in Monster.Monster_Information)
            {
                
                for(int i=0;i<子彈.子彈位置.Count;i++)
                {
                    if (monster.point.X < 子彈.子彈位置[i].X && monster.point.X + 30 > 子彈.子彈位置[i].X)
                    { 
                        
                        子彈.子彈位置.Remove(子彈.子彈位置[i]);
                        造成傷害();
                        怪物受傷(monster, yy);
                        產生特效();
                    }
                }
            }

        }

        private void 產生特效()
        {
            特效.Add();
        }


        private void 造成傷害()
        {
            
            String[] number = 能力.傷害區間.Split(',');
            int x = Int32.Parse(number[0]);
            int y = Int32.Parse(number[1]);
            double 暴率 = 能力.暴擊率;
            double 暴傷 = 能力.暴擊傷害;
            int z;
            double zz;
                bool 是否暴擊 = ((random.Next(0, 10000)/100) <= 暴率) ? true : false;

                z = random.Next(x, y);
                if(是否暴擊)
                 zz = (z * 暴傷);
                else
                zz = z;

            yy = zz.ToString("F0");
            Show_Number.Add(yy,是否暴擊);
            
        }

        private void 怪物受傷(Monster_Information monster, string number)
        {
            monster.Life -= double.Parse(number);
        }


        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="monster"></param>
        /// <param name="_子彈"></param>
        /// <param name="_傷害"></param>
        public Game_Hit(IfrmMain main,IMonster monster, I子彈 _子彈, IGame_User能力 _傷害,IGame_傷害數字 Number,IGame_傷害特效 _特效)
        {
            Main = main;
            Monster = monster;
            子彈 = _子彈;
            能力 = _傷害;

            特效 = _特效;
            Show_Number = Number;
            Check_Attack = new Timer();
            Check_Attack.Enabled = true;
            Check_Attack.Interval = 10;
            Check_Attack.Tick += new EventHandler(造成攻擊);

        }

    }
}
