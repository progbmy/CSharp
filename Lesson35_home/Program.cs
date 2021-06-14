using System;

namespace Lesson35_home
{
    /*
     * 1. Написать метод который выводит на экран строку.
     * Символы из которых состоит строка и их количество вводятся пользователем.
     * 
     * 2. Написать метод для поиска индекса элемента массива (тип элементов в массиве int), 
     * метод должне вернуть индекс первого найденного элемента (если он будет найден)
     * 
     */
    class Program
    {
        /*
        static void PrintLine(string symbol, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        }
        */

        static int[] GetRandomArray(uint lenght, int minValue, int maxValue)
        {
            int[] myArray = new int[lenght]; // Выделяем память массиву
            // Заполняем массив значениями
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }
            return myArray;    
        }

        static int IndexOff(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, -20, 10);

            int result = IndexOff(myArray, 2);

            Console.WriteLine(result);
        }


        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите сивол: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("Введите кол-во: ");
            uint symbolCount = uint.Parse(Console.ReadLine());

            PrintLine(symbol, symbolCount);
        }
        */
    }
}
