using System;

namespace Lesson49
{

    /*
     * Рекурсия -вызов методом самого себя.
     * 
     * Методы и стек
     * 
     * 
     * Переполнение стека
     */

    
    class Program
    {
        static void Foo(int i)
        {
            Console.WriteLine(i);
            i++;
            Foo(i);

        }
        static void Main(string[] args)
        {
            Foo(0);
        }
    }
}
