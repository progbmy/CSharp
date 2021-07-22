using System;

namespace Lesson48
{
    /*
     * Именованные параметры
     */
    class Program
    {
        static int Sum(int a, int b, bool enableLogging =false)
        {
            int result = a + b;
            if (enableLogging)
            {
                Console.WriteLine("Занчение переменной а= " + a);
                Console.WriteLine("Значение переменной b = "+ b);
                Console.WriteLine("Результат сложения = " + result);
            }
            return result;
        }


        static void Main(string[] args)
        {
            int result = Sum(b: 2, a: 6, enableLogging: true);
        }
    }
}
