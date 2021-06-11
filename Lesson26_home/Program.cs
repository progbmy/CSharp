using System;

namespace Lesson26_home
{
    /*
     * 1 Заполнить массив с клавиатуры
     * 2 Вывести массив в обратном порядке
     * 3 Найти сумму четных чисел
     * 4 Найти наименьшее число.
     */
    class Program
    {
        static void Main(string[] args)

        {
            /*
             *  Наполнение массива с клавиатуры
             
            Console.Write("Введите кол-во элементов массива: "); // Выводим сообщение
            
            int elementsCount = int.Parse(Console.ReadLine()); // Сохраняем данные размер массива
            
            int[] myArray = new int[elementsCount]; //Сохраняем данные в массив о кол-ве

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент массива под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine()); //Вводим данные для каждого элемента массива 
            }

            Console.WriteLine("\nВывод массива: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            */

            /*
             *  Вывод массива в обратном порядке.////////////////
             */
            /*
             int[] error = { 1,22, 324, 545 };

             for (int i = error.Length - 1; i >= 0; i--)
             {
                 Console.WriteLine(error[i]);
             }

             Console.ReadLine();
             */

            /*
             * 
             * Найти сумму положительных чисел.
            int[] myArray = { 1, 10, 324, 2, 77, 44 };
            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();

            */
            /*
             * 
             *Находим минимальный элемент в массиве 
             */

            int[] arra = { 34, 55, 66, 78 };

            int minVal = arra[0];

            for (int i = 1; i < arra.Length; i++)
            {
                if (arra[i] < minVal)
                {
                    minVal = arra[i];
                }
            }
            Console.WriteLine(minVal);

            Console.ReadLine();



        }
    }
}
