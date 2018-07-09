using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最新_守塔_Model
{
    public interface IControler
    {
        void Stop();
        void Start();

        int Get_Level { get; }

        int Get_剩餘點數 { get; }

        int Get_Width { get; }

        int Get_Monster_amount { get; }

        Point Get_MonsterPoint { get; }
        void Information_AddorLow(IUser_Information information,string Button_Name);

        void Information_Show(IUser_Information information);

        void Information_Define(IUser_Information information);

        string Information_傷害Text { get; }
    }
}
