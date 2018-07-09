using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 最新_守塔_Controler;
using 最新_守塔_Model;

namespace 最新_守塔_UI
{
    public partial class Form1 : Form, IfrmMain
    {
        User_Information User_Information;
        private Bitmap 畫面;
        Panel mypanel = new MyPanel();
        class MyPanel : Panel
        {
            public MyPanel()
            {
                SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            }
        }
        public Bitmap bitmap
        {
            get { return 畫面; }
            set { 畫面 = value; }
        }

        public string Set_Level { set { label1.Text = value; } }

        public string Set_KillAmount { set { label2.Text = value; } }

        public int _width => this.Width;
        
        public void ShowMessage(string message) => MessageBox.Show(message);
       
        public void GameOver()
        {

        }
        public void show_information()
        {

            User_Information.Show();
        }
        public void close_information()
        {
            User_Information.Hide();
        }

        public  IControler _controler => controler;



        private Controler controler;

        public Form1()
        {
            InitializeComponent();

            Bitmap a = new Bitmap(Properties.Resources.圖片, new Size(this.Width, this.Height));
            controler = new Controler(this);
            User_Information = new User_Information(this);
            controler.initial(User_Information);
            /* -------------------------------------------------------------*/
            /*建立畫布相關內容*/
            mypanel.Size = this.Size; //大小ˇ
            mypanel.Location = new Point(0, 0); //位置
            mypanel.Paint += new PaintEventHandler(this.mypanel_Paint);  //指 Mypanel 加入有 Mypanel_paint處理事件
            this.Controls.Add(mypanel); //建立畫布
            mypanel.BackgroundImage = a;
            this.BackgroundImage = a;

            畫面 = new Bitmap(mypanel.Width, mypanel.Height); //建立畫面暫存


            /*建立controler的邏輯處理*/


            controler.Stop();

            /*  測試Form2*/


        }


        private void mypanel_Paint(Object sender,PaintEventArgs e)
        {
            controler.繪圖();
            e.Graphics.DrawImage(畫面, 0, 0);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            mypanel.Size = this.Size;
            畫面 = new Bitmap(mypanel.Width, mypanel.Height); //建立畫面暫存
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.A)
            {
                
                show_information();
                controler.Stop();

            }
            if (e.KeyCode == Keys.Space)
            {
                controler.發射子彈();
                
            }
            if (e.KeyCode == Keys.Add)
            {
                controler.Stop();
            }
            if (e.KeyCode == Keys.Subtract)
                controler.Start();

            
        }

        private void 更新畫布_Tick(object sender, EventArgs e)
        {
            mypanel.Refresh();
            
            
            
        }

        private void Hit_test_Tick(object sender, EventArgs e)
        {
            //controler.造成傷害();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            /*  測試Form2*/

            controler.Start();
            button1.Hide();
        }
        public void NextStart_Button_Show()
        {
            button1.Text = "進入下一關";
            button1.Show();
        }
    }
}
