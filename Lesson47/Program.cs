using System;

namespace Lesson47
{
    /*
     * Необязательные параметры методов
     */
    class Program
    {
        static int Sum(int a, int b, bool enableLogging = false)
        { 
            int result = a+ b;

            if (enableLogging)
            {
                Console.WriteLine("Значение переменной a = " + a);
                Console.WriteLine("Значение переменной b = " + b);
                Console.WriteLine("Результат сложения = " + result);
            }
            return result;
        }

        static void Main(string[] args)
        {
            int result = Sum(2, 5);
            Console.WriteLine(result);

        }
    }
}
