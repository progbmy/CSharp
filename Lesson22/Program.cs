using System;

namespace Lesson22
{

    /*
     * Вложенные циклы
     */
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int j = 0; j<=10; j ++)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
            }
        }
    }
}
