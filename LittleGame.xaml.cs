using CharacterEvolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CharacterEvolution
{
    /// <summary>
    /// LittleGame.xaml 的交互逻辑
    /// </summary>
    public partial class LittleGame : UserControl
    {
        public LittleGame()
        {
            InitializeComponent();
        }
        commonClass commonC = new commonClass();
        IQueryable<TextEvolution> textEvo = null;
        IQueryable<GameImage> gameIma = null;
        List<GameImage> listImage = new List<GameImage>();
        ImageBrush imabush1 = new ImageBrush();
        private int flag = 0;
        private int angle = 0;
        private int count = 9;
        private int[] flage =new  int[9] ;
        private int[] fge = new int[9];
        int time = 0;
        private void LittleGame_Loaded(object sender, RoutedEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            try
            {
                textEvo = commonC.GetSearchResult("雪");
                gameIma = commonC.GetGameImageSearchResult("雪");
                listImage = gameIma.ToList();
                if (textEvo != null )
                {
                    imabush.ImageSource = commonC.ConvertLayout(textEvo.FirstOrDefault().MinImage.ToArray());
                    ForeBorder.Background = imabush;
                }
                else
                {
                    Messagebox.Show("错误", "对不起，没有你要找的字，请重新输入！");
                }

                for (int i = 0; i < 9; i++)
                {
                    flage[i] =  0; // 标记索引
                    fge[i] = i + 1;
                }
            }
            catch (Exception ex)
            {
                Messagebox.Show("错误", ex.ToString());
            }
        }

        private void leftRotate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            roteteTransform.Angle += 270;
            time++;
            if (angle == 0 )
            {
                angle = 90;
            }
            else
            {
                angle -= 90;
            }
        }

        private void rightRotate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            roteteTransform.Angle += 90;
            time++;
            if (angle == 360)
            {
                angle = 90;
            }
            else
            {
                angle += 90;
            }
        }

        private void small_ImageBoder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.CommonMethod();
        }

        private void small_ImageBoder_Drop(object sender, DragEventArgs e)
        {
            
        }

        private void Border1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            time++;
            time++;
            if (gameIma != null)
            {
                GameImage gi = gameIma.Where(o => o.ID == 1).FirstOrDefault();
                imabush.ImageSource = commonC.ConvertLayout(gi.littleImage.ToArray());
                if ((angle==0||angle==360) && imabush.ToString()==imabush1.ToString())
                {
                    border1.Background = imabush;
                    if (flage[0] == 0)
                    {
                        flage[0] = 1;
                        count -= 1;
                        for (int i= flag; i < 8; i++)
                        {
                            fge[i] = fge[i +1] ;
                        }
                           
                    }
                    this.CommonMethod();
                    Messagebox.Show("恭喜", "赞一个！");
                    TestFinish();
                }
                else
                {
                    Messagebox.Show("对不起", "请再来一次吧！");
                }
            }
            else
            {
                Messagebox.Show("1", "1");
            }
        }

        private void Border2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            time++;
            if (gameIma != null)
            {
                GameImage gi = gameIma.Where(o => o.ID == 2).FirstOrDefault();
                imabush.ImageSource = commonC.ConvertLayout(gi.littleImage.ToArray());
                if ((angle == 0 || angle == 360) && imabush.ToString() == imabush1.ToString())
                {
                    border2.Background = imabush;
                    if (flage[1] == 0)
                    {
                        flage[1] = 1;
                        count -= 1;
                        for (int i = flag; i < 8; i++)
                        {
                            fge[i] = fge[i+1] ;
                        }
                       
                    }
                    this.CommonMethod();
                    Messagebox.Show("恭喜", "赞一个！");
                    TestFinish();
                }
                else
                {
                    Messagebox.Show("对不起", "请再来一次吧！");
                }
            }
            else
            {
                Messagebox.Show("2", "2");
            }
        }

        private void Border3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            time++;
            if (gameIma != null)
            {
                GameImage gi = gameIma.Where(o => o.ID == 3).FirstOrDefault();
                imabush.ImageSource = commonC.ConvertLayout(gi.littleImage.ToArray());
                if ((angle == 0 || angle == 360) && imabush.ToString() == imabush1.ToString())
                {
                    border3.Background = imabush;
                    if (flage[2] == 0)
                    {
                        flage[2] = 1;
                        count -= 1;
                        for (int i = flag; i < 8; i++)
                        {
                            fge[i] = fge[i + 1];
                        }

                    }
                    this.CommonMethod();
                    Messagebox.Show("恭喜", "赞一个！");
                    TestFinish();
                }
                else
                {
                    Messagebox.Show("对不起", "请再来一次吧！");
                }
            }
            else
            {
                Messagebox.Show("3", "3");
            }
        }

        private void Border4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            time++;
            if (gameIma != null)
            {
                GameImage gi = gameIma.Where(o => o.ID == 4).FirstOrDefault();
                imabush.ImageSource = commonC.ConvertLayout(gi.littleImage.ToArray());
                if ((angle == 0 || angle == 360) && imabush.ToString() == imabush1.ToString())
                {
                    border4.Background = imabush;
                    if (flage[3] == 0)
                    {
                        flage[3] = 1;
                        count -= 1;
                        for (int i = flag; i < 8; i++)
                        {
                            fge[i] = fge[i +1] ;
                        }
                       
                    }
                    this.CommonMethod();
                    Messagebox.Show("恭喜", "赞一个！");
                    TestFinish();
                }
                else
                {
                    Messagebox.Show("对不起", "请再来一次吧！");
                }
            }
            else
            {
                Messagebox.Show("4", "4");
            }
        }

        private void Border5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            time++;
            if (gameIma != null)
            {
                GameImage gi = gameIma.Where(o => o.ID == 5).FirstOrDefault();
                imabush.ImageSource = commonC.ConvertLayout(gi.littleImage.ToArray());
                if ((angle == 0 || angle == 360) && imabush.ToString() == imabush1.ToString())
                {
                    border5.Background = imabush;
                    if (flage[4] == 0)
                    {
                        flage[4] = 1;
                        count -= 1;
                        for (int i = flag; i < 8; i++)
                        {
                            fge[i] = fge[i +1] ;
                        }
                      
                    }
                    this.CommonMethod();
                    Messagebox.Show("恭喜", "赞一个！");
                    TestFinish();
                }
                else
                {
                    Messagebox.Show("对不起", "请再来一次吧！");
                }
            }
            else
            {
                Messagebox.Show("5", "5");
            }
        }

        private void Border6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            time++;
            if (gameIma != null)
            {
                GameImage gi = gameIma.Where(o => o.ID == 6).FirstOrDefault();
                imabush.ImageSource = commonC.ConvertLayout(gi.littleImage.ToArray());
                if ((angle == 0 || angle == 360) && imabush.ToString() == imabush1.ToString())
                {
                    border6.Background = imabush;
                    if (flage[5] == 0)
                    {
                        flage[5] = 1;
                        count -= 1;
                        for (int i = flag; i < 8; i++)
                        {
                            fge[i] = fge[i +1];
                        }
                       
                    }
                    this.CommonMethod();
                    Messagebox.Show("恭喜", "赞一个！");
                    TestFinish();
                }
                else
                {
                    Messagebox.Show("对不起", "请再来一次吧！");
                }
            }
            else
            {
                Messagebox.Show("6", "6");
            }
            
        }

        private void Border7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            time++;
            if (gameIma != null)
            {
                GameImage gi = gameIma.Where(o => o.ID == 7).FirstOrDefault();
                imabush.ImageSource = commonC.ConvertLayout(gi.littleImage.ToArray());
                if ((angle == 0 || angle == 360) && imabush.ToString() == imabush1.ToString())
                {
                    border7.Background = imabush;
                    if (flage[6] == 0)
                    {
                        flage[6] = 1;
                        count -= 1;
                        for (int i = flag; i < 8; i++)
                        {
                            fge[i] = fge[i + 1];
                        }

                    }
                    this.CommonMethod();
                    Messagebox.Show("恭喜", "赞一个！");
                    TestFinish();
                }
                else
                {
                    Messagebox.Show("对不起", "请再来一次吧！");
                }
            }
            else
            {
                Messagebox.Show("7", "7");
            }
        }

        private void Border8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            time++;
            if (gameIma != null)
            {
                GameImage gi = gameIma.Where(o => o.ID == 8).FirstOrDefault();
                imabush.ImageSource = commonC.ConvertLayout(gi.littleImage.ToArray());
                if ((angle == 0 || angle == 360) && imabush.ToString() == imabush1.ToString())
                {
                    border8.Background = imabush;
                    if (flage[7] == 0)
                    {
                        flage[7] = 1;
                        count -= 1;
                        for (int i = flag; i < 8; i++)
                        {
                            fge[i] = fge[i + 1];
                        }

                    }
                    this.CommonMethod();
                    Messagebox.Show("恭喜", "赞一个！");
                    TestFinish();
                }
                else
                {
                    Messagebox.Show("对不起", "请再来一次吧！");
                }
            }
            else
            {
                Messagebox.Show("8", "8");
            }
        }

        private void Border9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            time++;
            if (gameIma != null)
            {
                GameImage gi = gameIma.Where(o => o.ID == 9).FirstOrDefault();
                imabush.ImageSource = commonC.ConvertLayout(gi.littleImage.ToArray());
                if ((angle == 0 || angle == 360) && imabush.ToString() == imabush1.ToString())
                {
                    border9.Background = imabush;
                    if (flage[8] == 0)
                    {
                        flage[8] = 1;
                        count -= 1;
                        for (int i = flag; i < 8; i++)
                        {
                            fge[i] = fge[i + 1];
                        }

                    }
                    this.CommonMethod();
                    Messagebox.Show("恭喜", "赞一个！");
                    TestFinish();
                }
                else
                {
                    Messagebox.Show("对不起", "请再来一次吧！");
                }
            }
            else
            {
                Messagebox.Show("9", "9");
            }
        }

        private void CommonMethod()
        {

            try
           {
                if(count  > 0)
                {
                    int flaged = 0;
                    flag = commonC.GetRandom(count);  //随机产生图片
                    flaged = fge[flag];
                    if (gameIma != null)
                    {
                        imabush1.ImageSource = commonC.ConvertLayout(listImage[flaged - 1].littleImage.ToArray());
                        small_ImageBoder.Background = imabush1;
                        angle = commonC.GetRandomDirection();
                        roteteTransform.Angle = angle;
                    }
                    else
                    {
                        Messagebox.Show("错误", "对不起，没有你要找的字，请重新输入！");
                    }
                }
            }
            catch (Exception ex)
            {
                Messagebox.Show("错误", ex.ToString());
            }
        }
        private void TestFinish()
        {
            
            if(count == 0)
            {
                Messagebox.Show("恭喜","祝贺你顺利过关！\n  您总共花了 "+ time.ToString() + "步完成！加油！");
                
            }
        }
    }
}
