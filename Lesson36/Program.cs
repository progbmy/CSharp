using System;

namespace Lesson36
{
    /*
     * Перегрузка методов 
     */
    class Program
    {
        /// <summary>
        /// Возвращает сумму 2 целых цисле
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Возвращает сумму 2 числе с плавающей точкой.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2.5, 4.7));
        }
    }
}
