using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 最新_守塔_Model;
using System.Windows.Forms;


namespace 最新_守塔_Controler
{
    class Game_AutoAttack:IGame_AutoAttack
    {
        I子彈 子彈;
        IGame_User能力 能力;
        Timer Timer_AutoAttack;
        int count=0;
        IGame_傷害特效 特效;

        public Timer Timer_Auto => Timer_AutoAttack;

        public Game_AutoAttack(I子彈 _子彈,IGame_User能力 _能力, IGame_傷害特效 _特效)
        {
            子彈 = _子彈;
            能力 = _能力;

            特效 = _特效;

            Timer_AutoAttack = new Timer();
            Timer_AutoAttack.Enabled = true;
            Timer_AutoAttack.Tick += new EventHandler(speed_Tick);
            Timer_AutoAttack.Interval = 35;
        }







        /// <summary>
        /// timer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speed_Tick(object sender, EventArgs e)
        {
            if (count >能力.攻擊速度)
            { 
                count = 0;
                子彈.發射子彈();
                
            }
            else
            {
                count++;
                特效.SuperMan_NotHit();
            }

        }
    }
}
