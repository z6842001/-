using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 最新_守塔_Model;
using 最新_守塔_Controler;

namespace 最新_守塔_UI
{
    public partial class User_Information : Form, IUser_Information
    {
       

        private static int Points_Attack;

        public int 等級 { set { Level.Text = value.ToString(); } }
        public int 傷害點
        {
            get { return Points_Attack; }
            set {
                Points_Attack = value;
                Attack.Text = controler.Information_傷害Text;
            }
        }
        
        public int 敏捷點
        {
            get { return Int32.Parse(Speed.Text); }
            set { Speed.Text = value.ToString(); }
        }
   
        public int 暴率點
        {
            get { return Int32.Parse(Crit機率.Text); }
            set { Crit機率.Text = value.ToString(); }
        }

        public int 暴擊傷害點
        {
            get { return Int32.Parse(Crit傷害.Text); }
            set { Crit傷害.Text = value.ToString(); }
        }

        
        public int 剩餘點數
        { 
            get { return Int32.Parse(Points.Text); }
            set { Points.Text = value.ToString();
                  }
        }

       
        private IfrmMain Main;
        private IControler controler;

        bool button_Click = false;
        public User_Information(IfrmMain x)
        {
            InitializeComponent();

            Main = x;
            controler = x._controler;

            this.FormClosing += new FormClosingEventHandler(User_Information_FormClosing);
            //加入關閉事件-User_Information_FormClosing
            #region Button 建立
            Bitmap add = new Bitmap(Properties.Resources.加, new Size(35, 35));
            Bitmap sub = new Bitmap(Properties.Resources.減, new Size(35, 35));
            Bitmap _save = new Bitmap(Properties.Resources.Save, new Size(100, 50));
          
            /*button設定*/
            Attack_Add.BackgroundImage = add;
            Attack_Add.Size = Attack_Add.BackgroundImage.Size;
            Speed_Add.BackgroundImage = add;
            Speed_Add.Size = Attack_Add.BackgroundImage.Size;
            CritAttack_Add.BackgroundImage = add;
            CritAttack_Add.Size = Attack_Add.BackgroundImage.Size;
            Crit_Add.BackgroundImage = add;
            Crit_Add.Size = Attack_Add.BackgroundImage.Size;

            Attack_Low.BackgroundImage = sub;
            Attack_Low.Size = Attack_Add.BackgroundImage.Size;
            Speed_Low.BackgroundImage = sub;
            Speed_Low.Size = Attack_Add.BackgroundImage.Size;
            CritAttack_Low.BackgroundImage = sub;
            CritAttack_Low.Size = Attack_Add.BackgroundImage.Size;
            Crit_Low.BackgroundImage = sub;
            Crit_Low.Size = Attack_Add.BackgroundImage.Size;
            /*button設定*/
            #endregion

            Save.BackgroundImage = _save;
            Save.Size = _save.Size;


            
            
            Level.Text = controler.Get_Level.ToString(); ;
            Points_Attack = 0;
            Speed.Text = "0";
            Crit機率.Text = "0";
            Crit傷害.Text = "0";
            Points.Text = controler.Get_剩餘點數.ToString();
            Attack.Text = controler.Information_傷害Text;
        }
        private void AddorLow_Click(object sender, EventArgs e)
        {
            button_Click = true;
            string a = ((Button)sender).Name;  //傳回按下的按鈕名稱

            controler.Information_AddorLow(this,a);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否確定要儲存所設定的內容?", "是否儲存檔案?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controler.Information_Define(this);
                this.Hide();
                controler.Start();
                button_Click = false;
            }
           
            
        }

        private void Save_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap _save1 = new Bitmap(Properties.Resources.Save1, new Size(100, 50));
            Save.BackgroundImage = _save1;
        }

        private void Save_MouseLeave(object sender, EventArgs e)
        {
            Bitmap _save = new Bitmap(Properties.Resources.Save, new Size(100, 50));
            Save.BackgroundImage = _save;
        }

        private void User_Information_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("是否確定要儲存所設定的內容?", "是否儲存檔案?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controler.Information_Define(this);
            }
            e.Cancel = true;
            this.Hide();
            controler.Start();
            button_Click = false;
        }  //當介面隱藏或關閉時觸發

        private void User_Information_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                if (button_Click)
                    Save_Click(sender, e);
                else
                {
                    this.Hide();
                    controler.Start();
                }
        }
    }
}
