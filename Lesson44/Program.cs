using System;

namespace Lesson44
{ /*
   * Ключевое слово Out 
   * Разница между out и ref
   */

    class Program
    {
        static void Foo(ref int value)
        {
            value++;
            Console.WriteLine(value);
        }

        static void Bar(out int value)
        {
            value = 0;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a = 10;
            Foo(ref a);
            //Bar(out a);

        }
    }
}
