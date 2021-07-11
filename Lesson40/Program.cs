using System;

namespace Lesson40
{
    /*
     *  Оператор null - объединение ??
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Test";

            Console.WriteLine(str ?? "Нет данных");
        }
    }
}
