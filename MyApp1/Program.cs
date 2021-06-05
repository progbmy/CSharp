using System;
using System.Globalization;

/*
 * Моя первая программа
 */
// Двойной комментарий

namespace MyApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет Мир");

        }
    }
    
}



/*
 * Конвертер валют
 * Console.WriteLine("Введи сколько хочшь сконвертировать баксов в рубди курс 78р");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = 78;
            int c = a * b;
            Console.WriteLine("Вот сколько получилось в деревяшках " + c);

 * 
 * Средне арифиметическое 2 чисел
 * 
 *  int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double c = (a + b) / 2; // Выводим среднеарифметическое 2 чисел
            Console.WriteLine(c);

Произведение 3 чисел
int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = a + b + c;
            Console.WriteLine(d);
            Console.WriteLine(a* b * c);
        }


            //string data;
            // string data = Console.ReadLine();
            //Console.WriteLine("Привет " + data + "!!!");
            // Для создания Console.WriteLine вводим cw и жмем 2 раза TAB
            // Convert/ToInt32 - конвертация строк в числа
            //Console.WriteLine("Введи число");
            //int bbb = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(bbb);
            //string bbb = "5.9";
            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = ".",
            //};

            //double a = double.Parse(bbb, numberFormatInfo);

            string str = "1 wwwwsdv";

            int a;
            bool result = int.TryParse(str, out a);
            if (result)
            {
                Console.WriteLine("Успешная Операция" + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }
            */