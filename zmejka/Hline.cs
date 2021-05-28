using System;
using System.Collections.Generic;
using System.Text;

namespace zmejka
{
    class Hline
    {
        List<Point> Plist;
        
        public Hline(int Yup, int Ydown, int x, char sym)
        {
            Plist = new List<Point>();
            for(int y = Yup; y<= Ydown; x++)
            {
                Point p = new Point(x, y, sym);
                Plist.Add(p);
            }
            /*Point p1 = new Point(4, 4, '#');
            Point p2 = new Point(5, 4, '#');
            Point p3 = new Point(6, 4, '#');
            Plist.Add(p1);
            Plist.Add(p2);
            Plist.Add(p3);*/
        }

        public void Draw()
        {
            foreach(Point p in Plist)
            {

                p.Draw();
            }
        }
    }
}
