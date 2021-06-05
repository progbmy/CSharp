using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */
            for (int i = 0, j =5; i < 5; i++, j--)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }
            Console.ReadLine();
        }
    }
}
