using System;
using System.Drawing;
using 最新_守塔_Model;
using System.Windows.Forms;

namespace 最新_守塔_Controler
{
    public class Controler: IControler
    { 
        //Test form2;
        //IUser_Information information;  // Information 
        /*以上測試介面*/
        IfrmMain View;
        //private static int level=1;  //等級  非常重要  關係到怪物生命
        
        public int Get_Level => User能力.Get_Set_level;
        public int Get_剩餘點數 => User能力.Get_剩餘點數;
        public int Get_Width => View._width;
        public Point Get_MonsterPoint =>Monster.Monster_Information[0].point ;

        IGame_傷害數字 傷害數字;  //顯示傷害數字用
       

        繪圖 繪圖Action;
        IGame_User能力 User能力;
        I子彈 子彈;
        IMonster Monster;
        IGame_Hit hit;
        IGame_傷害特效 特效;
        IGame_AutoAttack Auto;


        Timer timer;
        Random random = new Random();

        public Controler(IfrmMain view)
        {

            

            timer = new Timer();
            timer.Enabled = true;
            timer.Tick += new EventHandler(test);
            timer.Interval = 20;

            View = view;
            

            User能力 = new Game_User能力(View);
            特效 = new 傷害特效_2();
            Monster = new monster(View, this,User能力);
            傷害數字 = new Game_傷害數字();
            
            子彈 = new Game_子彈(this, 特效);
            Auto = new Game_AutoAttack(子彈, User能力,特效);
            hit = new Game_Hit(View,Monster, 子彈, User能力, 傷害數字,特效);
            
            繪圖Action = new _繪圖(View, 傷害數字, Monster, 子彈,特效,User能力);
            /* 以下為建立Test用*/
            //form2 = new Test();

            //form2.Visible = true;
            /* 以上為建立Test用*/
            // information = user;


            
            View.Set_Level = "目前等級為： " + User能力.Get_Set_level + "等！";

            
        }
        #region to_information 介面實作功能
        public void Information_AddorLow(IUser_Information information, string Button_Name) => User能力.Add_or_Low(information, Button_Name);

        public void Information_Define(IUser_Information information) => User能力.define(information);

        public void Information_Show(IUser_Information information) => User能力.Show(information);

        public string Information_傷害Text => User能力.Show_傷害區間toUI;

        public void initial(IUser_Information information) => User能力.Initial(information);


        #endregion



        private void test(object sender,EventArgs e)
        {
            Monster.Add_Monster();

        }

        public void Stop()
        {
            timer.Stop();
            Monster.Timer_Monster.Stop();
            子彈.Timer_子彈.Stop();
            Auto.Timer_Auto.Stop();
        }
        public void Start()
        {
            timer.Start();
            Monster.Timer_Monster.Start();
            子彈.Timer_子彈.Start();
            Auto.Timer_Auto.Start();
        }
        #region Monster
       
      
        

        public int Get_Monster_amount => Monster.Monster_Information.Count;
        #endregion

        #region 子彈
        public void 發射子彈()=> 子彈.發射子彈();   
        #endregion
        public void 繪圖()=> 繪圖Action.繪圖();
       
    }
}