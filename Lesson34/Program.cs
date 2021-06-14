using System;

namespace Lesson34
{
    // трехмерные массивы
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,,] myArray = new int[3, 5, 7];


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(100); // Заполняем трехмерный массив случайными данными
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Страница № " + (i + 1));

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + " "); // Выводим на консоль в табличку данные 
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("************************");
            }

                
         Console.ReadLine();

        }
    }
}
