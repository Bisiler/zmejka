using System;

namespace zmejka
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int x1 = 1;
            int y1 = 3;//тут устанавливаем координаты для знанка *
            char sym1 = '*';
            Console.SetCursorPosition(x1, y1);//тут мы даем курсору позицию по координатам которые мы ввели выше
            Console.Write(sym1);//тут мы выводим на экран символ в данном случяи это * */
            Point p1 = new Point(1,3,'*');
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw();
            
            Point p2 = new Point(4,5,'#');//тут в скобках есть 3 позиции, и они означают вот что:x,y,символ

            p2.Draw();
            List<int> numList = List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAlt(0);
            List<Point> pList = List<Point>();
            pList.add(p1);
            pList.add(p2);
            /*int x2 = 4;//тут устанавливаем координаты для знанка #
            int y2 = 5;
            char sym2 = '#';
            Draw(x2, y2, sym2)
            Console.SetCursorPosition(x2, y2);//тут мы даем курсору позицию по координатам которые мы ввели выше
            Console.Write(sym2);//тут мы выводим на экран символ в данном случяи это #*/
            Console.ReadLine();
        }
    }
}
