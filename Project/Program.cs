using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            double lastName, firstName; // переменные и тип
            Console.WriteLine("Введи число 1");
            lastName = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи число 2");
            firstName = double.Parse(Console.ReadLine());
            double result = (lastName + firstName) / 2;
            Console.WriteLine("Среднеарифметическая 2 чисел "+result);

        }
    }
}
