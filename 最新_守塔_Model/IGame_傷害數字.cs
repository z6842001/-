using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 最新_守塔_Model
{
    public interface IGame_傷害數字
    {
        //int 傷害_Amount { get; }
        /// <summary>
        /// 打擊造成傷害
        /// </summary>
        /// <param name="傷害">傷害值</param>
        /// <param name="是否暴擊">是否造成暴擊</param>
        void Add(string 傷害,bool 是否暴擊);
        Bitmap 組合數字();

      //  AttackList Get_AttackList { get; }
        
    }

    public  class AttackList_1 
    {
       public AttackList_1(string _傷害, float _透明度, bool _是否暴擊)
        {

        }
        public List<AttackList> Strings{get;set;}


    }

    public class AttackList
    {
        public String 傷害 { get; set; }
        public float 透明度 { get; set; }
        public bool 是否暴擊 { get; set; }

        public AttackList(string _傷害, float _透明度, bool _是否暴擊)
        {
            傷害 = _傷害;
            透明度 = _透明度;
            是否暴擊 = _是否暴擊;

        }
    }
}
