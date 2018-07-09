using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 最新_守塔_Model
{
   public interface IMonster
    {
        /// <summary>
        ///  顯示怪物資訊(生命 座標)
        /// </summary>
        List<Monster_Information> Monster_Information { get; set; }
        


        /// <summary>
        ///  建立怪物
        /// </summary>
        void Add_Monster();
        /// <summary>
        ///  刪除怪物 
        /// </summary>
        void Monster_Die();
        Timer Timer_Monster { get; }
    }

    public class Monster_Information : IMonster_Information
    {


        double _Life;
        Point _point;
        int _Jump = 0;

        /// <summary>
        /// 建構式 填入建立怪物所需資訊
        /// </summary>
        /// <param name="MonsterLife"> 怪物血量</param>
        /// <param name="Monster_point">怪物目前座標</param>
        public Monster_Information(double MonsterLife, Point Monster_point)
        {
            _Life = MonsterLife;
            _point = Monster_point;
        }
        /// <summary>
        /// 空白建立怪物建構式
        /// </summary>
        public Monster_Information()
        {
            _Life = 999999999;
            _point = new Point(1000, 230);
        }  //空白建構子


        /// <summary>
        /// 實作 回傳生命值
        /// </summary>
        public double Life
        {
            get { return _Life; }
            set { _Life = value; }
        }
        /// <summary>
        /// 實作 座標值寫入及回傳
        /// </summary>
        public Point point
        {
            get { return _point; }
            set { _point = value; }
        }
        /// <summary>
        /// 實作 跳躍動作數值回傳
        /// </summary>
        public int jump
        {
            get
            {
                if (_Jump > 4)
                {
                    _Jump = -5;
                }
                return _Jump;
            }
            set
            {
                _Jump = value;
            }

        }


    }
}
