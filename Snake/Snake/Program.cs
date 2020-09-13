using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(9, 4, '$');
            Point p4 = new Point(7, 6, '@');

            List<Point> plst = new List<Point>();

            plst.Add(p1);
            plst.Add(p2);
            plst.Add(p3);
            plst.Add(p4);

            foreach(Point point in plst)
            {
                point.Draw();
            }


            Console.WriteLine();

            List<int> numlist = new List<int>();

            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];
           
            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }

            numlist.Remove(0);

            List<Point> plist  = new List<Point>();


            Console.ReadLine();
        }

        
    }
}
    