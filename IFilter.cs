using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    interface IFilter
    {
        Bitmap Appy(Bitmap bitmap);
        string GetName();
    }
}
