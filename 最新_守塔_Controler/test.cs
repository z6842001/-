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


namespace 最新_守塔_Controler
{
    public partial class test : Form
    {
        IMonster Monster;
        public test(IMonster monster)
        {
            Monster = monster;
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Monster.Monster_Information.Count>0)
                label1.Text = "怪物血量： " + Monster.Monster_Information[0].Life;
        }
    }
}
