using System;

namespace Lesson32
{
    // Заполнение массива данными.
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,] myarray = new int[10, 6];

            Random random = new Random();

            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j= 0; j < myarray.GetLength(1); j++)
                {
                    myarray[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */

            int[,] myarray = new int[2, 3];


            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + "X: "+ j);

                    myarray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
