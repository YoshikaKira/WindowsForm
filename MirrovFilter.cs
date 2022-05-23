using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class MirrovFilter : IFilter
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
                    result.SetPixel(w - j - 1, i, bitmap.GetPixel(j, i));
                }
            }
            return result;
        }

        public string GetName()
        {
            return "Отразить изображение";
        }
    }
}
