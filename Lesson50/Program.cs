using System;

namespace Lesson50
{
    /*
     * Преобразование и приведение типов
     * Неявное преобразование implicit
     * Явное преобразование explicit double a =5.3; float b = (float)a
     * 
     */
    class Program
    {
        static void Foo(float value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a = 5;

            Foo(a);
        }
    }
}
