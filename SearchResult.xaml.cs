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
    /// SearchResult.xaml 的交互逻辑
    /// </summary>
    public partial class SearchResult : UserControl
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        commonClass commonC = new commonClass();
        IQueryable<TextEvolution> textEvo = null;
        private int flag = 0;
        private void Search_ButtonClick(object sender, RoutedEventArgs e)
        {
            textEvo = commonC.GetSearchResult(searchText.Text.Trim());
            if (textEvo != null)
            {
                ImageFillIMage.Source = commonC.ConvertLayout(textEvo.FirstOrDefault().MinImage.ToArray());
                textFill.Text = textEvo.FirstOrDefault().Text;
            }
            else
            {
                Messagebox.Show("错误", "对不起，没有你要找的字，请重新输入！");
            }
        }

        private void Left_MouseClickDown(object sender, MouseButtonEventArgs e)
        {
            flag = flag + 1;
        }

        private void Right_MouseClickUp(object sender, MouseButtonEventArgs e)
        {
            if (searchText.Text != null)
            {
                if (flag < 0)
                {
                    flag = textEvo.Count() - 1;
                }
                List<TextEvolution> textevo = textEvo.ToList();
                ImageFillIMage.Source = commonC.ConvertLayout(textevo[flag].MinImage.ToArray());
                textFill.Text = textevo[flag].Text;
            }
            else
            {
                Messagebox.Show("错误！", "请在查询框中输入你想查询的字！");
            }
        }

        private void Left_MouseClickUp(object sender, MouseButtonEventArgs e)
        {
            if (searchText.Text != null)
            {
                if (flag > textEvo.Count() - 1)
                {
                    flag = 0;
                }
                List<TextEvolution> textevo = textEvo.ToList();
                ImageFillIMage.Source = commonC.ConvertLayout(textevo[flag].MinImage.ToArray());
                textFill.Text = textevo[flag].Text;
            }
            else
            {
                Messagebox.Show("错误！", "请在查询框中输入你想查询的字！");
            }
        }

        private void Right_MouseClickDown(object sender, MouseButtonEventArgs e)
        {
            flag = flag - 1;
        }


        
    }
}
