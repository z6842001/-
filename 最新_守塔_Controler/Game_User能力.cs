using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 最新_守塔_Model;

namespace 最新_守塔_Controler
{
    class Game_User能力 : IGame_User能力
    {
        static int 等級;
        static int 傷害點;
        static int 敏捷點;
        static int 暴擊率點;
        static int 暴擊傷害點;
        static int 剩餘點數;
        static int 經驗點;
        IfrmMain Main;
        IUser_Information User;


        public int 經驗值
        {
            get { return 經驗點; }
            set { 經驗點 = value; }
        }

        public void check_EXP()
        {
            if (經驗點>計算升級所需經驗())
                LevelUP();
        }
        private void LevelUP()
            {
                經驗點 = 0;
                等級 += 1;
                剩餘點數 += 5;
                Get_Set_level = Get_Set_level;
                User.剩餘點數 = 剩餘點數;
                User.等級 = 等級;
            }
        public void Set_Level()
        {
            
        } //寫入目前等級
        #region Return 基本數值
        public double 暴擊率  => 計算暴擊率();
        public double 暴擊傷害 => 計算暴擊傷害();
        public int 攻擊速度 => 計算攻擊速度();


       public int Get_Set_level
        {
            get { return 等級; }
            set { Main.Set_Level = "目前等級為： " + 等級 + "等"; }
        }

        public string 取得目前經驗百分比數 => ((Decimal)經驗點 / (Decimal)計算升級所需經驗()*(decimal)100).ToString("F2");
        public int Get_剩餘點數 => 剩餘點數;
        #endregion


        /// <summary>
        /// 建構式
        /// </summary>
        public Game_User能力(IfrmMain main)
        {
            Main = main;
           等級 = 1;
           傷害點 = 9990;
           敏捷點 = 920;
           暴擊率點 = 900;
           暴擊傷害點 = 890;
           剩餘點數 = 20;
            經驗點 = 0;
            暫_傷害點 = 傷害點;
        } // 建構式
       
        public void Initial(IUser_Information user)
        {
            User = user;
            user.傷害點 = 傷害點;
            user.敏捷點 = 敏捷點;
            user.暴擊傷害點 = 暴擊傷害點;
            user.暴率點 = 暴擊率點;
        }

        private int 計算升級所需經驗()
        {
            decimal x;

            x = (decimal)(0.9937 * Math.Pow(等級, 2)) + (decimal)(6.5376 * 等級) + (decimal)42.4679;

            return (Int32)x;
        }


        #region 計算及顯示能力素質

        int 暫_傷害點 = 0;
        public string 傷害區間 => ((傷害點 + 1) * 2000 / 3).ToString("F0") + "," + ((傷害點 + 1) * 3000 / 3);

        public string Show_傷害區間toUI => ((暫_傷害點 + 1) * 2000 / 3).ToString("F0") + " ~ " + ((暫_傷害點 + 1) * 3000 / 3);
        /// <summary>
        /// 使用公式計算暴率 最高就95% 
        /// </summary>
        /// <returns></returns>
        private double 計算暴擊率()
        {
            double a = -0.02;
            double b = 2.89;

            double _暴擊率 = (a * Math.Pow(暴擊率點, 2)+(b*暴擊率點)+5);

            return ((_暴擊率>95||_暴擊率<0)?95:_暴擊率);

        }

        private double 計算暴擊傷害()
        {
            
            decimal 暴擊傷害 = (decimal)(150 + (暴擊傷害點 * 5))/ (decimal)100;

            return (double)暴擊傷害;
        }
 

        private int 計算攻擊速度()
        {
            double 攻擊速度 = (-0.0016 * Math.Pow(敏捷點, 2) + 0.26 * 敏捷點 +0.5); //每秒Hit數
            decimal x = (decimal)30 / (decimal)攻擊速度;




            return (Int32)x;
        }
        #endregion
        public void Show(IUser_Information user)
        {

        }
        #region Button or Check
        int count = 0;
        public void Add_or_Low(IUser_Information user,string ButtonName)
        {
            if (剩餘點數 > 0)
            {
                switch (ButtonName)
                {
                    case "Attack_Add":
                        count++;
                        暫_傷害點++;
                        user.傷害點++;
                        break;

                    case "Speed_Add":
                        count++;
                        user.敏捷點++;
                        break;

                    case "Crit_Add":
                        count++;
                        user.暴率點++;
                        break;

                    case "CritAttack_Add":
                        count++;
                        user.暴擊傷害點++;
                        break;
                    default:
                        剩餘點數++;
                        break;
                }
                剩餘點數--;
            }
            
            if(count>0)
            {
                switch (ButtonName)
                {
                    case "Attack_Low":
                        if (user.傷害點 > 0)
                        {
                            暫_傷害點--;
                            user.傷害點--;
                            
                            count--;
                        }
                        else
                            剩餘點數--;
                        
                        break;
                    case "Speed_Low":
                        if (user.敏捷點 > 0)
                        {
                            user.敏捷點--;
                            count--;
                        }
                        else
                            剩餘點數--;
                        break;
                    case "Crit_Low":
                        if (user.暴率點 > 0)
                        {
                            user.暴率點--;
                            count--;
                        }
                        else
                            剩餘點數--;
                        break;
                    case "CritAttack_Low":
                        if (user.暴擊傷害點 > 0)
                        {
                            user.暴擊傷害點--;
                            count--;
                        }
                        else
                            剩餘點數--;
                        break;

                    default:
                        剩餘點數--;
                        break;

                }
                剩餘點數++;
            }
            user.剩餘點數 = 剩餘點數;
        }

        public void define(IUser_Information user)
        {
            傷害點 = user.傷害點;
            敏捷點 = user.敏捷點;
            暴擊率點 = user.暴率點;
            暴擊傷害點 = user.暴擊傷害點;
            count = 0;
            
        }
        #endregion
        
    }
}
