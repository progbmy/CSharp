using System;

namespace Lesson24
{
    class Program
    {
        /*
         * Массивы
         * Одномерные массивы
         * Совокупность элементов одного типа []
         */
        static void Main(string[] args)
        {
            int[] myArray; // объявляем массив
            myArray = new int[5]; // Создаем массив с пятью индексами

            myArray[1] = 3; // Добавляем в массив в индекс 1 значение 3
            myArray[0] = 10;
            
            int a = myArray[0];
            Console.WriteLine(a); // Выводим информацию из массива с индексом 1
            Console.ReadLine();

        }
    }
}
