using System;

namespace Lesson30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 5] 
            {
                { 23, 45,643,234,23},
                { 65566, 5656,6345,2345,645},
                { 822, 1661, 56511, 456465, 5334}
            }; 
            
            
            // Объявляем двумерный массив

           // myArray[0, 2] = 99; // Помещаем значение в ячейку массива
            
            Console.WriteLine(myArray[0, 3]); // Считывем значение ячейки массива
            

        }
    }
}
