using System;

namespace Lesson43
{
    /*
     * Ключевое слово ref
     * 
     * 
     * Передача аргументов по ссылке
     */
    class Program
    {
        static void Foo(ref int a)
        {
            a = -5;
        }


        static void Main(string[] args)
        {
            int a = 2;
            Foo(ref a);
            Console.WriteLine(a);
        }
    }
}
