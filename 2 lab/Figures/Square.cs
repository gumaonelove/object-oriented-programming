using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square : Rectangle
    {
        public Square(int id, int x, int y, int w) : base(id, x, y, w, w)
        {
            name = "Квадрат";
        }
    }
}
