using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15

 /*
 *Оператор Switch - реализовать принятие решение о выборе - переключатель.
 * ConsoleKey consoleKey = Console.ReadKey().Key;
*/
{
    class Program
    {
        static void Main(string[] args)

        {
            /*
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы ввели число 1");
                    break;
                case 2:
                    Console.WriteLine("Вы ввели число 2");
                    break;
                default:
                    Console.WriteLine("Я не знаю что делать");
                    break;
              */
            while (true)
            {

                Console.Clear(); // Очистка консоли

                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("Введите число 1");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    secondValue = double.Parse(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Написал хрень");
                    Console.ReadLine();
                    continue; // Обязательно указывать в исключении
                }

                

                Console.WriteLine("Выберите операцию");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;
                    default:
                        Console.WriteLine("Не знаю что делать");
                        break;

                }
                Console.ReadLine();


            }
        }
    }
}
