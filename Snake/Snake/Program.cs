using System;
using System.Reflection.Metadata.Ecma335;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();

            p1.x = 1;
            p1.y = 3;
            p1.symb = '*';

            p1.Draw();

            Point p2 = new Point();

            p2.x = 4;
            p2.y = 5;
            p2.symb = '#';

            p2.Draw();

            Console.ReadLine();
        }

        
    }
}
    