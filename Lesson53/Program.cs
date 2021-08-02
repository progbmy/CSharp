using System;

namespace Lesson53
{
    /*
     * Ключевое слово var 
     * неявно типизированные переменные 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // var t = new float[10];
            // Console.WriteLine(t.GetType());
            var t = new { Name = "Мартин", Age = 34 };
            Console.WriteLine(t.GetType());
        }
    }
}
