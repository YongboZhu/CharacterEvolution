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
    /// ComputerUI.xaml 的交互逻辑
    /// </summary>
    public partial class ComputerUI : Window
    {
        public ComputerUI()
        {
            InitializeComponent();
        }
        //定义左按钮点击事件
        private void LeftButtonBorderClicik_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("left");
        }
        //定义home按钮点击事件
        private void HomeButtonBorderClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Home");
        }
        //定义皮肤按钮点击事件
        private void SkinButtnBorderClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Skin");
        }
        //定义右按钮点击事件
        private void RightButtonBorderClicik_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right");
        }
        //定义文本输入事件
        private void SearchTextboxEndInput_KeyDown(object sender, KeyEventArgs e)
        {
            //判读是否输入完成
            if (e.Key == Key.Enter)
            {
               
                //清空上次输入文本内容
                SearchTextbox.Text = "";
            }
        }
        //定义窗口移动事件
        private void MoveWindowBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        //当鼠标进入移动窗口区域后修改光标
        private void MoveWindowCurserChange_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
