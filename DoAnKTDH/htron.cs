using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DoanKTDH
{
    public class htron
    {
        public int bkinh;
        public Point tam;
        public Color mau;
        public htron()
        {
            bkinh = 0;
            tam = new Point(0, 0);
            mau = Color.DarkGreen;
        }
        public htron(int bk, Point tamht, Color m)
        {
            bkinh = bk;
            tam = new Point(tamht.X, tamht.Y);
            mau = m;
        }
    }
}
