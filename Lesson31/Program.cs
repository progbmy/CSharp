using System;
using System.Linq;

namespace Lesson31
{
    /*
     * ДВумерный массив вывод данных.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int[,] myarray = new int[,]
            {
                { 2,34,54,43,43 },
                { 43,54,654,345,3 },
                { 3434,5566,9866,345,123 },
                { 3434,5566,9866,33,345 }
            };
            /*
            foreach (var item in myarray)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(myarray.Rank); //Вывод информации о массиве.
            
            
            Console.WriteLine(myarray.GetLength(1)); //0 вертикальный подсчет, 1 горизонт+
            */
           // int height = myarray.GetLength(0);
            //int width = myarray.GetLength(1);

            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j]+ "\t");
                }
                Console.WriteLine(); // Переход на сл строку
            }
        }
    }
}
