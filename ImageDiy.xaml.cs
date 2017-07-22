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
using System.Drawing;
using Microsoft.Win32;
using System.IO;
namespace CharacterEvolution
{
    /// <summary>
    /// ImageDiy.xaml 的交互逻辑
    /// </summary>
    public partial class ImageDiy : UserControl
    {
        public ImageDiy()
        {
            InitializeComponent();
        }

        commonClass commonC = new commonClass();
        IQueryable<TextEvolution> textEvo = null;
        private int flag = 0;
        //设置画笔大小为1
        private void SetPenSize1_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Height = 1;
            EditInkCanvas.DefaultDrawingAttributes.Width = 1;

        }
        //设置画笔大小为5
        private void SetPenSize2_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Height = 5;
            EditInkCanvas.DefaultDrawingAttributes.Width = 5;
        }
        //设置画笔大小为10
        private void SetPenSize3_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Height = 10;
            EditInkCanvas.DefaultDrawingAttributes.Width = 10;
        }
        //设置画笔大小为20
        private void SetPenSize4_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Height = 20;
            EditInkCanvas.DefaultDrawingAttributes.Width = 20;
        }
        //设置画笔大小为50
        private void SetPenSize5_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Height = 20;
            EditInkCanvas.DefaultDrawingAttributes.Width = 20;
        }
        //设置画笔颜色为Red
        private void SetColor1_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.Red);
        }
        //设置画笔颜色为Red
        private void SetColor2_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.Black);
        }
        //设置画笔颜色为Blue
        private void SetColor3_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.Blue);
        }
        //设置画笔颜色为Green
        private void SetColor4_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.Green;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.Green);
        }
        //设置画笔颜色为Pink
        private void SetColor5_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.Pink;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.Pink);

        }
        //设置画笔颜色为DarkMagenta
        private void SetColor6_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.DarkMagenta;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.DarkMagenta);
        }
        //设置画笔颜色为Yellow
        private void SetColor7_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.Yellow;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.Yellow);

        }
        //设置画笔颜色为Aqua
        private void SetColor8_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.Aqua;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.Aqua);
        }
        //设置画笔颜色为Coral
        private void SetColor9_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.Coral;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.Coral);
        }
        //设置画笔颜色为Brown
        private void SetColor10_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            EditInkCanvas.DefaultDrawingAttributes.Color = Colors.Brown;
            //修改画笔大小颜色
            FirstBrushSize.Fill = new SolidColorBrush(Colors.Brown);
        }
        //清除笔画
        private void ClearPen_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
        //清楚上一笔
        private void ClearStept_Click(object sender, RoutedEventArgs e)
        {
            EditInkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;

        }

        private void imageSearch_ButtonClick(object sender, RoutedEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            textEvo = commonC.GetSearchResult(textSearch.Text.Trim());
            if (textEvo != null)
            {
                imabush.ImageSource = commonC.ConvertLayout(textEvo.FirstOrDefault().MinImage.ToArray());
                imageResult.Background = imabush;
            }
            else
            {
                Messagebox.Show("错误", "对不起，没有你要找的字，请重新输入！");
            }
        }

        //左边按钮的相关事件
        private void left_MouseDown(object sender, MouseButtonEventArgs e)
        {
            flag = flag + 1;
        }

        private void left_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imagebursh = new ImageBrush();
            if (flag > textEvo.Count() - 1)
            {
                flag = 0;
            }
            List<TextEvolution> textevo = textEvo.ToList();
            imagebursh.ImageSource = commonC.ConvertLayout(textevo[flag].MinImage.ToArray());
            imageResult.Background = imagebursh;
        }

        //与右边按钮有关的事件

        private void right_MouseDown(object sender, MouseButtonEventArgs e)
        {
            flag = flag - 1;
        }

        private void right_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imagebursh = new ImageBrush();
            if (flag < 0)
            {
                flag = textEvo.Count() - 1;
            }
            List<TextEvolution> textevo = textEvo.ToList();
            imagebursh.ImageSource = commonC.ConvertLayout(textevo[flag].MinImage.ToArray());
            imageResult.Background = imagebursh;
        }
        //设置画板背景
        private void image2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Background2.jpg", UriKind.Relative));
            EditInkCanvas.Background = imabush;

        }
        //设置画板背景
        private void image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Background1.jpg", UriKind.Relative));
            EditInkCanvas.Background = imabush;
        }
        //设置画板背景
        private void image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Background3.jpg", UriKind.Relative));
            EditInkCanvas.Background = imabush;
        }
        //设置画板背景
        private void image4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImageBrush imabush = new ImageBrush();
            imabush.ImageSource = new BitmapImage(new Uri(".../.../Skin/Background4.jpg", UriKind.Relative));
            EditInkCanvas.Background = imabush;
        }

        private void SaveImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //double width = EditInkCanvas.ActualWidth;
            //double height = EditInkCanvas.ActualHeight;
            //RenderTargetBitmap bmpCopied = new RenderTargetBitmap((int)Math.Round(width), (int)Math.Round(height), 96, 96, PixelFormats.Default);
            //DrawingVisual dv = new DrawingVisual();
            //using (DrawingContext dc = dv.RenderOpen())
            //{
            //    VisualBrush vb = new VisualBrush(EditInkCanvas);
            //    dc.DrawRectangle(vb, null, new Rect(new System.Windows.Point(), new System.Windows.Size(width, height)));
            //}
            //bmpCopied.Render(dv);
            //if()
            //{
            //}
            //using (FileStream file = new FileStream(, FileMode.Create, FileAccess.Write))
            //{

            //    BmpBitmapEncoder encoder = new BmpBitmapEncoder();
            //    encoder.Frames.Add(BitmapFrame.Create(bmpCopied));
            //    encoder.Save(file);
            //}
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "图片文件(.jpeg)|*.jpg";   //new一个方法
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);  //定义打开的默认文件夹位置
            ofd.ShowDialog();          //显示打开文件的窗口
            string  path = ofd.FileName;               //获得选择的文件路径
             //获得文件扩展名
            if (path == "")
            {
                Messagebox.Show("错误", "未输入文件名！");
                return;
            }
            Transform transform = EditInkCanvas.LayoutTransform;
            EditInkCanvas.LayoutTransform = null;

            Size size = new Size(EditInkCanvas.Width, EditInkCanvas.Height);
            EditInkCanvas.Measure(size);
            EditInkCanvas.Arrange(new Rect(size));
 
            RenderTargetBitmap renderBitmap = new RenderTargetBitmap((int)size.Width, (int)size.Height, 96d,96d,PixelFormats.Pbgra32);
            renderBitmap.Render(EditInkCanvas);
            using (FileStream outStream = new FileStream(path, FileMode.Create))
            {
                  PngBitmapEncoder encoder = new PngBitmapEncoder();
                 encoder.Frames.Add(BitmapFrame.Create(renderBitmap));
                 encoder.Save(outStream);
           }
           EditInkCanvas.LayoutTransform = transform;
        }
    }
}
