using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace onepiece
{
    class Pirate
    {
        public void draw(Graphics g, float x, float y)
        {
            Pen p = new Pen(Color.Red);
            SolidBrush sb = new SolidBrush(Color.Red);
            g.DrawEllipse(p, x, y, 10, 10);
            g.FillEllipse(sb, x, y, 10, 10);
        }
    }
}
