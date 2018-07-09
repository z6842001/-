
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 最新_守塔_Model;

namespace 最新_守塔_Controler
{
    static class MyResource
    {
        public static Bitmap GetImage(string name)
        {
            Bitmap bmp;
            Assembly _assembly = Assembly.GetExecutingAssembly();

            using (Stream _imageStream = _assembly.GetManifestResourceStream("最新_守塔_Controler.Image." + name))
                {
                    bmp = new Bitmap(_imageStream);
                }
                return bmp;
        }
        public static Bitmap Get標1(string x)
        {
            Bitmap _bmp;
            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream _imageStream = assembly.GetManifestResourceStream("最新_守塔_Controler.AAA.標" + x + ".gif"))
            {
                _bmp = new Bitmap(_imageStream);
            }
            return _bmp;
        }
        public static Bitmap Get標2(string x)
        {
            Bitmap _bmp;
            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream _imageStream = assembly.GetManifestResourceStream("最新_守塔_Controler.AAA.BBB.標" + x+".gif"))
            {
                _bmp = new Bitmap(_imageStream);
            }
            return _bmp;
        }
    }
    class Game_傷害數字:IGame_傷害數字
    {
        Timer 淡化;
        static ImageList ImageList_Normal = new ImageList();  // 無暴擊傷害
        static ImageList ImageList_Crit = new ImageList();  // 無暴擊傷害
        Bitmap 傷害數字;
       static readonly int Normal_間距 = 40;
        static readonly int Crit_間距 = 50;
        // 建立 Paint 物件
        static List<AttackList> strings = new List<AttackList>();

        //static strings[] 傷害 = new strings[10];
        

        /// <summary>
        /// 建構式
        /// </summary>
        public Game_傷害數字()
        {
            ImageList_Normal.TransparentColor = System.Drawing.Color.Transparent;
            ImageList_Normal.ImageSize = new Size(Normal_間距*2, Normal_間距 * 2);
            ImageList_Normal.Images.Add(Properties.Resources._0);
            ImageList_Normal.Images.Add(Properties.Resources._1);
            ImageList_Normal.Images.Add(Properties.Resources._2);
            ImageList_Normal.Images.Add(Properties.Resources._3);
            ImageList_Normal.Images.Add(Properties.Resources._4);
            ImageList_Normal.Images.Add(Properties.Resources._5);
            ImageList_Normal.Images.Add(Properties.Resources._6);
            ImageList_Normal.Images.Add(Properties.Resources._7);
            ImageList_Normal.Images.Add(Properties.Resources._8);
            ImageList_Normal.Images.Add(Properties.Resources._9);


            ImageList_Crit.TransparentColor = System.Drawing.Color.Transparent;
            ImageList_Crit.ImageSize = new Size(Crit_間距*2, Crit_間距*2);

            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_0.gif"));
            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_1.gif"));
            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_2.gif"));
            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_3.gif"));
            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_4.gif"));
            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_5.gif"));
            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_6.gif"));
            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_7.gif"));
            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_8.gif"));
            ImageList_Crit.Images.Add(MyResource.GetImage("Goad_9.gif"));



            淡化 = new Timer();
            淡化.Enabled = true;
            淡化.Tick += new EventHandler(淡化效果_Tick);
            淡化.Interval = 50;
        }

      

        /// <summary>
        /// timer 淡化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 淡化效果_Tick(object sender,EventArgs e)  
        {
            foreach(var a in strings)
            {
                 
                 a.透明度 -= 0.1f;
                
            }
        }


        /// <summary>
        /// 回傳畫面目前呈現傷害數量
        /// </summary>
      //  public int 傷害_Amount => strings.Count;

        /// <summary>
        /// 產生傷害~
        /// </summary>
        /// <param name="a"></param>
        public void Add(string a,bool 是否暴擊)
        {

            strings.Add(new AttackList(a, 1,是否暴擊));
        }

        /// <summary>
        /// 將所有傷害組合成一張Image 在回傳
        /// </summary>
        /// <returns></returns>
        public Bitmap 組合數字()
        { 


            Bitmap 傷害圖 = new Bitmap(480, 255);
            文字消失();

            using (var g = Graphics.FromImage(傷害圖))
            {
                g.Clear(Color.Transparent);
                for (int i = 0; i < strings.Count; i++)
                {
                    if (!String.IsNullOrEmpty(strings[i].傷害))
                    {
                        Bitmap a = 畫成數字(strings[i].傷害, strings[i].透明度,strings[i].是否暴擊);
                        g.DrawImage(a, 240 - (a.Width / 2), 95 + (strings[i].透明度 * 40));
                     //   strings[i].透明度 -= 0.1f;
                    }
                }
                return 傷害圖;
            }
        }

        /// <summary>
        /// 將透明度為0 or 太多重疊的圖刪除
        /// </summary>
        private void 文字消失()
        {
            int count = 0;
            
            foreach (var a in strings)
            {
                if (a.透明度 <= 0)
                {
                    count++;
                }
            }
            strings.RemoveRange(0, count);

            if (strings.Count > 10)
            {
                strings.RemoveRange(0, strings.Count - 10);
            }

        }

       
        /// <summary>
        /// 將傳入的字串轉成圖片輸出
        /// </summary>
        /// <param name="傷害值">字串</param>
        /// <param name="透明度">透明度</param>
        /// <returns></returns>
        private Bitmap 畫成數字(string 傷害值, float 透明度,bool 是否暴擊)
        {
            int 間距 = (是否暴擊 ? Crit_間距 : Normal_間距);
            int 間隔 = 8;
            ImageList ImageList = (是否暴擊 ? ImageList_Crit : ImageList_Normal);

            int 字串長度 = 傷害值.Length;
            傷害數字 = new Bitmap(((字串長度 - 1) * (間距+間隔) + (間距*2)), (間距*2));
            using (var g = Graphics.FromImage(傷害數字))
            {
                g.Clear(Color.Transparent);
                for (int i = 0; i < 字串長度; i++)
                {
                    float 寬度 = (間隔 * i) + (間距 * i);   // 5 為文字間隔
                    int number = int.Parse(傷害值.Substring(i, 1));
                    g.DrawImage(ImageList.Images[number], 寬度, 0);
                }
                傷害數字 = 重繪透明圖(傷害數字, 透明度);
                return 傷害數字;
            }
        }


/// <summary>
/// 將圖片重繪成透明的
/// </summary>
/// <param name="srcImage">輸入圖檔</param>
/// <param name="opacity">所需透明度</param>
/// <returns></returns>
        private Bitmap 重繪透明圖(Bitmap srcImage, float opacity)
        {
            float[][] nArray ={ new float[] {1, 0, 0, 0, 0},
                        new float[] {0, 1, 0, 0, 0},
                        new float[] {0, 0, 1, 0, 0},
                        new float[] {0, 0, 0, opacity, 0},
                        new float[] {0, 0, 0, 0, 1}};
            ColorMatrix matrix = new ColorMatrix(nArray);
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Bitmap resultImage = new Bitmap(srcImage.Width, srcImage.Height);
            Graphics g = Graphics.FromImage(resultImage);
            g.DrawImage(srcImage, new Rectangle(0, 0, srcImage.Width, srcImage.Height), 0, 0, srcImage.Width, srcImage.Height, GraphicsUnit.Pixel, attributes);

            return resultImage;
        }
    }
    
}