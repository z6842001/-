using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 最新_守塔_Model
{
   public interface IGame_User能力
    {

        #region Button or Check
        /// <summary>
        /// 當按下能力值加減觸發
        /// </summary>
        /// <param name="user_">介面Iuser_Information</param>
        /// <param name="ButtonName">按下的按鈕名稱 寫法為： ((Button)sender).Name</param>
        void Add_or_Low(IUser_Information user_,string ButtonName);
        /// <summary>
        /// 按下儲存鈕
        /// </summary>
        /// <param name="user">介面Iuser_Information</param>
        void define(IUser_Information user);
        #endregion



        /// <summary>
        /// User_Information Show新數值
        /// </summary>
        void Show(IUser_Information user);

        /// <summary>
        /// 初始化 將素質寫入
        /// </summary>
        /// <param name="user"></param>
        void Initial(IUser_Information user);

        /// <summary>
        /// 回傳 目前等級
        /// </summary>
        int Get_Set_level { get; set; }

        void check_EXP();
        /// <summary>
        /// Get 目前經驗的百分比
        /// </summary>
        string 取得目前經驗百分比數 { get; }

        int 經驗值 { get; set; }

        #region 能力參數
        double 暴擊率 { get; }
        double 暴擊傷害 { get; }

        int 攻擊速度 { get; }
        /// <summary>
        /// Hit使用  傷害區間
        /// </summary>
        string 傷害區間 { get; }

        /// <summary>
        /// 將傷害區間給UI顯示
        /// </summary>
        string Show_傷害區間toUI { get; }
        /// <summary>
        /// 回傳剩餘點數
        /// </summary>
        int Get_剩餘點數 { get; }
        #endregion
    }
}
