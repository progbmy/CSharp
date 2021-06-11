using System;

namespace Lesson22_home
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Введите высоту: ");
            int height = int.Parse(Console.ReadLine());


            for (int i = 0; i < height; i++)
                {

                for (int j = 0; j <= i; j++)
                    {
                    Console.Write("*");
                    }

                Console.WriteLine();
                }
            
          
            Console.ReadLine();
            */
            /*
            Console.Write("Введите высоту");
            int weight = int.Parse(Console.ReadLine());

            for (int i = 0; i < weight; i++)
            {
                for (int j =  weight; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
            */

            Console.Write("Введите высоту: "); // Выводим текст
            int height = int.Parse(Console.ReadLine()); // Сохраняем в переменную значение ввода


            for (int i = 0; i < height; i++) // Цикл
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            Console.ReadLine();
        }
        
    }
}
