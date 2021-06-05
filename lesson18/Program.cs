using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            uint oddNumbersCount = 0; // Счетчики
            uint evenNumbersCount = 0;

            int oddNumberSum = 0; // Счетчики суммы
            int evenNumberSum = 0;

            Console.WriteLine("Введите первое число диапазона");
            int currentValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введиет второе число диапазона");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumberSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumberSum += currentValue;
                   
                }
                currentValue++;
            }

            Console.WriteLine("Количество нечетных чисел: " + oddNumbersCount);
            Console.WriteLine("Количество четных чисел: " + evenNumbersCount);
            Console.WriteLine("Сумма четных чисел " + evenNumberSum);
            Console.WriteLine("Сумма нечетных чисел " + oddNumberSum);

            */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            

        }
    }
}
