using System;

namespace Lesson46
{
    class Program
    {
        /*
         * Ключевое слово params
         

        static int Sum(params int[] parameters)
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }


        static void Main(string[] args)
        {
            int result = Sum(5, 10);
            Console.WriteLine(result);
        }
        */

        static void Foo(params object[] parameters)
        {
            string message = "Тип данных {0}, значение переменной {1}";
            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        
        }

        static void Main(string[] args)
        {
            Foo("test", 4, 'g', 5.56f, true);
        
        }
    }
}
