using System;

namespace zmejka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Hline upLine = new Hline(0, 78, 0, '+');
            Hline downLine = new Hline(0, 78, 24, '+');
            vLine leftLine = new vLine(0, 24, 78, '+');
            vLine RightLine = new vLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            RightLine.Draw();




            Point p1 = new Point(1, 3, '*');
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw();

            Point p2 = new Point(4, 5, '#');//тут в скобках есть 3 позиции, и они означают вот что:x,y,символ

            p2.Draw();
            /*int x1 = 1;
            int y1 = 3;//тут устанавливаем координаты для знанка *
            char sym1 = '*';
            Console.SetCursorPosition(x1, y1);//тут мы даем курсору позицию по координатам которые мы ввели выше
            Console.Write(sym1);//тут мы выводим на экран символ в данном случяи это * */

            /*int x2 = 4;//тут устанавливаем координаты для знанка #
            int y2 = 5;
            char sym2 = '#';
            Draw(x2, y2, sym2)
            Console.SetCursorPosition(x2, y2);//тут мы даем курсору позицию по координатам которые мы ввели выше
            Console.Write(sym2);//тут мы выводим на экран символ в данном случяи это #*/
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAlt(0);
            List<int> Plist = new List<int>();
            Plist.Add(p1);
            Plist.Add(p2);


            Console.ReadLine();
        }
    }
}
