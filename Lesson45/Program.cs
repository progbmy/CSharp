using System;

namespace Lesson45
{ /*
   * Параметр in передаваемый как аргумент
   * 
   */
    class Program
    {
        static void Foo(in int value)
        {
            Console.WriteLine(value);
            //value = 5;
        }
    
        static void Main(string[] args)
        {
            int a = 10;
            Foo(a);
        }
    }
}
