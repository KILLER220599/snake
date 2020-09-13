using System;
using System.Reflection.Metadata.Ecma335;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char symb1 = '*';
            Console.SetCursorPosition(x1, y1);
            Console.Write(symb1);

            int x2 = 4;
            int y2 = 5;
            char symb2 = '#';
            Console.SetCursorPosition(x2, y2);
            Console.Write(symb2);

            Console.ReadLine();
        }
    }
}
    