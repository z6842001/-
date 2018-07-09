using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace 最新_守塔_Model
{
    public interface IfrmMain
    {
       // int Get_Level { get; } //取得等級

        Bitmap bitmap { get; set; }     //圖片

        void ShowMessage(string _string); //

        void GameOver();
        int _width { get;  }

        string Set_Level { set; }

        string Set_KillAmount { set; }


        IControler _controler { get; }

      
    }
}
