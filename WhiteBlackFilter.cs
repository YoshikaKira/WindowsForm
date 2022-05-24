using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class WhiteBlackFilter : IFilter
    {
        public Bitmap Appy(Bitmap bitmap)
        {
            int h = bitmap.Height;
            int w = bitmap.Width;
            Bitmap result = new Bitmap(w, h);

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Color color = bitmap.GetPixel(j, i);
                    Color c = Color.FromArgb((color.R + color.G + color.B) / 3, (color.R + color.G + color.B) / 3, (color.R + color.G + color.B) / 3);
                    result.SetPixel(j, i, c);
                }
            }
            return result;
        }

        public string GetName()
        {
            return "Черно-белый фильтер";
        }
    }
}
