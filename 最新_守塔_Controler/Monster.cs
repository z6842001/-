using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using 最新_守塔_Model;
using System.Windows.Forms;

namespace 最新_守塔_Controler
{

    class monster : IMonster
    {
        static List<Monster_Information> _monster = new List<Monster_Information>();
        IControler Controler;   //  可以取得等級 Controler . GetXXXXX
        public List<Monster_Information> Monster_Information
        {
            get { return _monster; }
            set { _monster = value; }
        }

        private Point 怪物座標 = new Point();  //暫存用
        private readonly Point 初始座標 = new Point(1100, 200);
        private double 基礎血量 = 3000;

        private int speed = 3;
        int speed_count = 0;
        int Monster_Count = 0;

        Timer Monster_Tick;
        static int KillAmount = 0;

        public Timer Timer_Monster => Monster_Tick;



        public int Get_kill => KillAmount;
        IGame_User能力 user;
        IfrmMain Main;

        test test;
        public monster(IfrmMain main, IControler controler,IGame_User能力 _User) //建構式
        {
            test = new test(this);
            test.Show();
            Main = main;
            //Monster_Blood = 基礎血量 + ((level - 1) * 0.1 * 基礎血量);    //計算血量

            // _monster.Add(new Monster_Information(基礎血量, 初始座標));
            Controler = controler;
            user =_User;


            Monster_Tick = new Timer();
            Monster_Tick.Enabled = true;
            Monster_Tick.Tick += new EventHandler(Monster_Move);
            Monster_Tick.Interval = 10;
        }




        private bool 是否產生怪物()
        {
            bool boollean = true;
            if (Monster_Count >= 6 && _monster.Count <= 30)
            {
                boollean = true;
                Monster_Count = 0;

            }
            else
            {
                boollean = false;
                Monster_Count++;
            }

            return boollean;
        }

        public void Add_Monster()
        {

            if (是否產生怪物())
                _monster.Add(new Monster_Information(基礎血量 + ((user.Get_Set_level - 1) * 0.5 * 基礎血量), 初始座標));

        }
        List<Monster_Information> bb;
        public void Monster_Die()
        {
            
                bb = _monster;
                foreach (var a in bb.ToArray())
                {
                if (a.point.X < 50)
                    bb.Remove(a);
                    if (a.Life <= 0)
                    {
                        bb.Remove(a);
                        user.經驗值++;
                        user.check_EXP();
                        KillAmount++;
                        Main.Set_KillAmount = "一共擊殺了 " + KillAmount + " 個敵人";
                    }
                }
                _monster = bb;
          
        }


        private void Monster_Move(object sender, EventArgs e)
        {
            //int x = 怪物座標.X;
            if (speed_count > speed)
            {

                for (int i = 0; i < _monster.Count; i++)
                {
                    怪物座標 = _monster[i].point;
                    怪物座標.X -= 10;
                    if (_monster[i].jump >= 0)
                        怪物座標.Y += 5;
                    else
                        怪物座標.Y -= 5;

                    _monster[i].jump++;
                    _monster[i].point = 怪物座標;

                }
                speed_count = 0;
            }
            else
                speed_count++;

            _monster.Sort(
                    delegate (Monster_Information s1, Monster_Information s2)
                        {
                            return s1.point.X.CompareTo(s2.point.X);
                        });
            


        }


    }





}