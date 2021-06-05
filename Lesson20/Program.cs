using System;

namespace Lesson20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            { 
               
                string msw = Console.ReadLine();
                if (msw == "exit")
                {
                    break;
                }
                Console.WriteLine(i);     
            }
               
               

            Console.ReadLine();
        }
    }
}
