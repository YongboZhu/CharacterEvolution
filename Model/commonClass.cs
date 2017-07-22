using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CharacterEvolution.Model
{
    public class commonClass
    {
        //获取查询TextEvolution表得到的集合
        public IQueryable<TextEvolution> GetSearchResult(string character)
        {
            TextEvolutionDataContext textEvo = new TextEvolutionDataContext();
            try
            {
                IQueryable<TextEvolution> textData = textEvo.TextEvolution.Where(o => o.Character == character);
                if (textData.Count() !=0)
                {
                    return textData;
                }
                else
                {
                    return null;
                }
            }
            catch(ArgumentNullException ane)
            {
                return null;
            }
        }

        //获取查询GameImage表得到的集合
        public IQueryable<GameImage> GetGameImageSearchResult(string character)
        {
            TextEvolutionDataContext textEvo = new TextEvolutionDataContext();
            try
            {
                IQueryable<GameImage> textData = textEvo.GameImage.Where(o => o.Name == character);
                if (textData.Count() != 0)
                {
                    return textData;
                }
                else
                {
                    return null;
                }
            }
            catch (ArgumentNullException ane)
            {
                return null;
            }
        }

        //转换图片的数据类型
        public BitmapImage ConvertLayout(byte[] image)
        {
            BitmapImage bmimage = new BitmapImage();
            MemoryStream m_ImageStream = new MemoryStream(image);
            try
            {
                bmimage.BeginInit();
                bmimage.StreamSource = m_ImageStream;
                bmimage.EndInit();
                return bmimage;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //得到随机数
        public int GetRandom(int max)
        {
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            int num = random.Next(0, max-1);
            return num;
        }

        //得到随机方向
        public int GetRandomDirection()
        {
            commonClass common = new commonClass();
            int angle = 0;
            int num=common.GetRandom(3);
            switch(num)
            {
                case 1:
                    angle= 90;
                    break;
                case 2:
                    angle = 180;
                    break;
                case 3:
                    angle = 270;
                    break;

            }
            return angle;
        }

        
    }
}
