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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow :Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        commonClass commonC = new commonClass();
        IQueryable<TextEvolution> textEvo = null;
        private int flag = 0;
        //此处定义输入文字后返回结果的事件
        private void Textbox_Enter(object sender, KeyEventArgs e)
        {
            //判断输入是否为回车键
            if(e.Key == Key.Enter)
            {
                textEvo = commonC.GetSearchResult(Message_Text.Text.Trim());
            if (textEvo != null)
            {
                ImageBrush imabush = new ImageBrush();
                imabush.ImageSource = commonC.ConvertLayout(textEvo.FirstOrDefault().MinImage.ToArray());
                borderImage.Background = imabush;
            }
            else
            {
                Messagebox.Show("错误", "对不起，没有你要找的字，请重新输入！");
            }
              
            }
        }
        //左边按钮被点击事件
        private void LeftBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            flag = flag + 1;
        }
        //定义窗口移动事件
         private void MainBorderMove_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        //上边按钮被单击事件
         private void MouseTop_MouseDown(object sender, MouseButtonEventArgs e)
         {
             NormalUI normal = new NormalUI();
             this.Hide();
             normal.Show();
         }
        //右边按钮被单击事件
         private void RightBtn_MouseDown(object sender, MouseButtonEventArgs e)
         {
             flag = flag - 1;
         }
        //下边按钮被单击事件
         private void DownBtn_MouseDown(object sender, MouseButtonEventArgs e)
         {
             MessageBox.Show("Down");
         }

         private void RightBtn_MouseUp(object sender, MouseButtonEventArgs e)
         {
             if (flag < 0)
             {
                 flag = textEvo.Count() - 1;
             }
             List<TextEvolution> textevo = textEvo.ToList();
             ImageBrush imabush = new ImageBrush();
             imabush.ImageSource = commonC.ConvertLayout(textevo[flag].MinImage.ToArray());
             borderImage.Background = imabush;
         }

         private void LeftBtn_MouseUp(object sender, MouseButtonEventArgs e)
         {
             if (flag > textEvo.Count() - 1)
             {
                 flag = 0;
             }
             List<TextEvolution> textevo = textEvo.ToList();
             ImageBrush imabush = new ImageBrush();
             imabush.ImageSource = commonC.ConvertLayout(textevo[flag].MinImage.ToArray());
             borderImage.Background = imabush;
         }
         
       

     
    }
}
