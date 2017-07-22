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
using System.Windows.Shapes;

namespace CharacterEvolution
{
    /// <summary>
    /// NormalUI.xaml 的交互逻辑
    /// </summary>
    public partial class NormalUI : Window
    {
        int Mainstate = 1;  //记录主菜单按钮的按下状态
         public NormalUI()
        {
            InitializeComponent();
            SearchResult sr = new SearchResult();
            CenterPanelGrid.Children.Add(sr);
            CenterPanelGrid.RegisterName("newHomePage", sr);

            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Purpe.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
            ///更改透明度为0.8
            MainBorder.Opacity = 0.8;
            
           
        }
        //关闭按钮点击事件
        private void CloseWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        //缩小窗口到托盘事件
        private void MinWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Minimized)
            {

                this.WindowState = System.Windows.WindowState.Normal;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Minimized;
            }
        }
        //显示主菜单界面
        private void MainMenuMessageShow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mainstate == 1)
            {
                MainMenuBorder.Margin = new Thickness(640, 40, 60, 370);
               //改变主菜单状态
                Mainstate = 2;   
            }
            else
            {
                MainMenuBorder.Margin = new Thickness(800, 0, -100, 370);
                //改变主菜单状态
                Mainstate = 1;
            }
          
            
        }
        //针对设置皮肤界面的Expander下拉功能
        private void SceneryExpanderChange_Expanded(object sender, RoutedEventArgs e)
        {
            PureColorExpander.IsExpanded = false;
        }
        //隐藏设置皮肤窗口
        private void SetColorWindowClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ChangeSkinBorder.Visibility =  System.Windows.Visibility.Hidden;
        }
        //显示设置皮肤窗口
        private void ChangeSkin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ChangeSkinBorder.Visibility = System.Windows.Visibility.Visible;
        }
        //更换Red
        private void ChangeColor1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush( Colors.Red);
        }
        //更换Spring图片背景
        private void ChangeSkin1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/SpringSkin.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
           ///更改透明度为0.8
            MainBorder.Opacity = 0.8;
        }
        //更换blue
        private void ChangeColor2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Blue);
        }
        //更换Pink
        private void ChangeColor3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Pink);
        }
        //更换Gray
        private void ChangeColor4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Gray);
        }
        //更换Navy
        private void ChangeColor5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Navy);
        }
        //更换DarkCyan
        private void ChangeColor6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.DarkCyan);
        }
        //更换Aqua
        private void ChangeColor7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Aqua);
        }
        //更换DarkGoldenrod
        private void ChangeColor8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.DarkGoldenrod);
        }
        //更换Black
        private void ChangeColor9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Black);
        }
        //更换Brown
        private void ChangeColor10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Brown);
        }
        //更换 BurlyWood
        private void ChangeColor11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.BurlyWood);
        }
        //更换 Chocolate
        private void ChangeColor12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Chocolate);
        }
        //更换 Coral
        private void ChangeColor13_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Coral);
        }

        //更换 Green
        private void ChangeColor14_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Green);
        }
        //更换Firebrick
        private void ChangeColor15_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.Firebrick);
        }
        //更换GreenYellow
        private void ChangeColor16_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeadBorder.Background = new SolidColorBrush(Colors.GreenYellow);
        }
        //更换Ball图片背景
        private void ChangeSkin2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Ball.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
            ///更改透明度为0.8
            MainBorder.Opacity = 0.8;
        }
        //更换Flower图片背景
        private void ChangeSkin3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Flower.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
            ///更改透明度为0.8
            MainBorder.Opacity = 0.8;
        }
        //更换Paint图片背景
        private void ChangeSkin4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Paint.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
            ///更改透明度为0.8
            MainBorder.Opacity = 0.8;

        }
        //更换Town图片背景
        private void ChangeSkin5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Town.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
            ///更改透明度为0.8
            MainBorder.Opacity = 0.8;

        }
        //更换Sea图片背景
        private void ChangeSkin6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Sea.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
            ///更改透明度为0.8
            MainBorder.Opacity = 0.8;
        }
        //更换Yellow图片背景
        private void ChangeSkin7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Yellow.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
            ///更改透明度为0.8
            MainBorder.Opacity = 0.8;
        }
        //更换Purpe图片背景
        private void ChangeSkin8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Purpe.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
            ///更改透明度为0.8
            MainBorder.Opacity = 0.8;
        }
        //更换Beach图片背景
        private void ChangeSkin9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Beach.jpg", UriKind.Relative));
            MainBorder.Background = imabush;
            ///更改透明度为0.8
            MainBorder.Opacity = 0.8;
        }
        //定义主窗口移动事件
        private void MainWindwMove_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        //返回到主页面
        private void ReturnHomePage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            ImageDiy page = CenterPanelGrid.FindName("newEditImagePage") as ImageDiy;//找到刚新添加的控件  
            LittleGame game = CenterPanelGrid.FindName("newlittleGamePage") as LittleGame;
            if (page != null)//判断是否找到，以免在未添加前就误点了  
            {
                CenterPanelGrid.Children.Remove(page);//移除对应按钮控件  
                CenterPanelGrid.UnregisterName("newEditImagePage");//还需要把对用的名字注销掉，否则再次点击Button_Add会报错  
            }
            if (game != null)//判断是否找到，以免在未添加前就误点了  
            {
                CenterPanelGrid.Children.Remove(game);//移除对应按钮控件  
                CenterPanelGrid.UnregisterName("newlittleGamePage");//还需要把对用的名字注销掉，否则再次点击Button_Add会报错  
            }
            if (page != null || game != null)
            {
                SearchResult sr = new SearchResult();
                CenterPanelGrid.Children.Add(sr);
                CenterPanelGrid.RegisterName("newHomePage", sr);
            }
           
        }
        //进入编辑图片界面
        private void EnterEditImagePage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchResult page = CenterPanelGrid.FindName("newHomePage") as SearchResult;//找到刚新添加的控件  
            LittleGame game = CenterPanelGrid.FindName("newlittleGamePage") as LittleGame;
            if (page != null)//判断是否找到，以免在未添加前就误点了  
            {
                CenterPanelGrid.Children.Remove(page);//移除对应按钮控件  
                CenterPanelGrid.UnregisterName("newHomePage");//还需要把对用的名字注销掉，否则再次点击Button_Add会报错  
            }
            if (game != null)//判断是否找到，以免在未添加前就误点了  
            {
                CenterPanelGrid.Children.Remove(game);//移除对应按钮控件  
                CenterPanelGrid.UnregisterName("newlittleGamePage");//还需要把对用的名字注销掉，否则再次点击Button_Add会报错  
            }
            if (page != null || game != null)
            {
                ImageDiy sr = new ImageDiy();
                CenterPanelGrid.Children.Add(sr);
                CenterPanelGrid.RegisterName("newEditImagePage", sr);
            }
            
        }
        //进入小游戏界面
        private void EnterLittleGamePge_MouseDown(object sender, MouseButtonEventArgs e)
        {

            SearchResult page = CenterPanelGrid.FindName("newHomePage") as SearchResult;//找到刚新添加的控件  
            ImageDiy game = CenterPanelGrid.FindName("newEditImagePage") as ImageDiy;
            if (page != null)//判断是否找到，以免在未添加前就误点了  
            {
                CenterPanelGrid.Children.Remove(page);//移除对应按钮控件  
                CenterPanelGrid.UnregisterName("newHomePage");//还需要把对用的名字注销掉，否则再次点击Button_Add会报错  
            }
            if (game != null)//判断是否找到，以免在未添加前就误点了  
            {
                CenterPanelGrid.Children.Remove(game);//移除对应按钮控件  
                CenterPanelGrid.UnregisterName("newEditImagePage");//还需要把对用的名字注销掉，否则再次点击Button_Add会报错  
            }
            if (page != null || game != null)
            {
                LittleGame sr = new LittleGame();
                CenterPanelGrid.Children.Add(sr);
                CenterPanelGrid.RegisterName("newlittleGamePage", sr);
            }
        }
        // 进入迷你界面
        private void EnterMiniWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mini = new MainWindow();
            this.Hide();
            mini.Show();
        }
        //打开帮助文档
        private void OpenHelpWindw_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HelpWindow helpwindow = new HelpWindow();
            helpwindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            helpwindow.Show();
        }
      

      
    }
}
