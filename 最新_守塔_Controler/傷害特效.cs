using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 最新_守塔_Model;
using 最新_守塔_Other;
//using System.Threading;

namespace 最新_守塔_Controler
{
    delegate Bitmap mydelegate();

    class 傷害特效 : IGame_傷害特效
    {



        Bitmap[] Bitmap_特效 = new Bitmap[10];
        public Bitmap[] 特效圖_Bitmap => Bitmap_特效;

        /*Test用*/

        Timer 特效光影;
       
        Other_AutoGif autoGif;  //委派

        Other_AutoGif autoGif_A;

        Other_AutoGif autoGif_B;

        Point _SuperMan_Point;

        public Point SuperMan_Point => _SuperMan_Point;

        //static ImageList 飛鏢A = new ImageList();

        public Bitmap 飛鏢 => Delegate_飛鏢();


        static List<打擊特效List> List_打擊特效 = new List<打擊特效List>();
        Bitmap 特效;


        #region 主角_Hit 動作
        public void SuperMan_Hit()=>_SuperMan_Point.X -= 15;
        public void SuperMan_NotHit() => _SuperMan_Point.X = -50;
        #endregion


        mydelegate Delegate_飛鏢;

        /// <summary>
        /// 建構式
        /// </summary>
        public 傷害特效()
        {
            _SuperMan_Point = new Point(-50, 180);
            特效 = new Bitmap(Properties.Resources.特效,new Size(80,80));

            特效光影 = new Timer();
            特效光影.Enabled = true;
            特效光影.Tick += new EventHandler(淡化效果_Tick);
            特效光影.Interval = 10;



            autoGif_A = new Other_AutoGif(new Bitmap[] {
                                                    MyResource.Get標1("1") , MyResource.Get標1("2") , MyResource.Get標1("3"),
                                                    MyResource.Get標1("4"),MyResource.Get標1("5"),MyResource.Get標1("6"),
                                                    MyResource.Get標1("7"),MyResource.Get標1("8"),MyResource.Get標1("9"),
                                                    MyResource.Get標1("10"),MyResource.Get標1("11"),MyResource.Get標1("12")}, 
                                                    new Size(40, 40));
            autoGif_B = new Other_AutoGif(new Bitmap[] {
                                                    MyResource.Get標2("1") , MyResource.Get標2("2") , MyResource.Get標2("3"),
                                                    MyResource.Get標2("4"),MyResource.Get標2("5"),MyResource.Get標2("6"),
                                                    MyResource.Get標2("7"),MyResource.Get標2("8"),MyResource.Get標2("9"),
                                                    MyResource.Get標2("10"),MyResource.Get標2("11"),MyResource.Get標2("12")},
                                                    new Size(60, 60));


            Delegate_飛鏢 = new mydelegate(autoGif_A.NextBitmap);
        }


        private void Get_NextBitmap()
        {

            Delegate_飛鏢 = new mydelegate(autoGif_A.NextBitmap);

        }

       



        public void Add()
        {
            List_打擊特效.Add(new 打擊特效List());
        }


        /// <summary>
        /// timer 淡化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 淡化效果_Tick(object sender, EventArgs e)
        {

            foreach (var a in List_打擊特效)
            {
                if(a.順序< 5)
                    a.透明度 += 0.2f;
                else if (a.順序 >= 5)
                    a.透明度 -= 0.2f;

                a.順序++;
            }
        }

        private void 特效消失()
        {
            int count = 0;

            foreach (var a in List_打擊特效)
            {
                if (a.順序 >= 10)
                {
                    count++;
                }
            }

            List_打擊特效.RemoveRange(0, count);

            if (List_打擊特效.Count > 5)
            {
                List_打擊特效.RemoveRange(0, List_打擊特效.Count - 5);
            }

        }

        public Bitmap 組合特效()
        {


            Bitmap 特效組合圖 = new Bitmap(100, 100);
            特效消失();

            using (var g = Graphics.FromImage(特效組合圖))
            {
                g.Clear(Color.Transparent);
                for (int i = 0; i < List_打擊特效.Count; i++)
                {
                    if (!String.IsNullOrEmpty(List_打擊特效[i].順序.ToString()))
                    {
                        Bitmap a = 重繪透明圖(特效,List_打擊特效[i].透明度);
                        g.DrawImage(a,0+(i*4), 20 - (i * 4));
                        //   strings[i].透明度 -= 0.1f;
                    }
                }
                return 特效組合圖;
            }
        }


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
