using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace onepiece
{
    class Pirate
    {
        PictureBox unit = new PictureBox();

        public PictureBox instantiate(int x, int y)
        {
            unit.Size = new Size(10, 10);
            unit.Location = new Point(x, y);
            unit.BackColor = Color.Red;

            return unit;
        }

        //public void draw(Graphics g, float x, float y)
        //{
        //    Pen p = new Pen(Color.Red);
        //    SolidBrush sb = new SolidBrush(Color.Red);
        //    g.DrawEllipse(p, x, y, 10, 10);
        //    g.FillEllipse(sb, x, y, 10, 10);
        //}
        
    }
        
}
