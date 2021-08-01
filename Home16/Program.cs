using System;

namespace Home16
{
    /*
     * Находим сумму элементов массива с помощью рекурсии 
     * 
     */
    class Program
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;

            return myArray[i] + Sum(myArray, i + 1);
        }


        static void Main(string[] args)
        {
            int[] myArray = { 4, 6, 9};

            int result = Sum(myArray);
            Console.WriteLine(result);
        }
    }
}
