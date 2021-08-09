using System;
using System.Reflection;

namespace Lesson57
{
    /*
     * Модификаторы доступа public private
     */
    class Point
    {
        public int x = 88;

        private int y = 55;

        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }
        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.PrintY();
            point.PrintPoint();
        }
    }
}
