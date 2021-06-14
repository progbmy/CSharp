using System;

namespace Lesson35
{
    class Program
    {
        static int Sum(int val_1, int val_2)
        {
            //int result = a + b;

            return val_1 + val_2;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Результат сложения: " + result);
        
        }
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);

            PrintResult(c);
        }
    }
}
