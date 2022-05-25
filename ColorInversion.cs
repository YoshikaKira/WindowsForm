﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class ColorInversion : IFilter
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
                    Color c = Color.FromArgb( 255-color.R, 255-color.G, 255-color.B);
                    result.SetPixel(j, i, c);
                }
            }
            return result;
        }

        public string GetName()
        {
            return "Инверся цвета";
        }
    }
}
