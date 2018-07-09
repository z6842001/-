using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 最新_守塔_Model
{
 
    public interface IMonster_Information
    {
        /// <summary>
        /// 怪物血量
        /// </summary>
         double Life
        {
            get;set;
        }
        /// <summary>
        /// 怪物座標
        /// </summary>
         Point point
        {
            get ; set; 
        }
        /// <summary>
        /// 取得怪物跳躍數值 給別人無用啦 哈哈
        /// </summary>

         int jump
        {
            get;set;
        }
    }
}
