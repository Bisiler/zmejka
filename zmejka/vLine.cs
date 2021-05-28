

namespace zmejka
{
    class vLine
    {
        list<Point> pList;
        public vLine(int Yup, int Ydown, int x, char sym)
        {
            Point p = new Point(x, y, sym);
            pList.Add(p);
        }
    }
    public void Draw()
    {
        foreach(Point p in pList)
        {
            p.Draw();
        }
    }
}
