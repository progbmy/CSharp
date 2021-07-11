using System;

namespace lesson38
{
    /*
     * Ссылочные типы(reference type) в куче и значимые типы (value type) в стеке
     *
     *Stack - маленький обьем для каждого потока 1М, для хранения пременных
     *last in first out
     * 
     * Heap - динамическая память Управляемая куча. Много но  медленно.
     */
    class Program
    {
        static void Lets(int value)
        {
            value = 77;
        }
        static void Main(string[] args)
        {
            int a = 5;

            Lets(a);
            Console.WriteLine(a);
           
        }
    }
}
