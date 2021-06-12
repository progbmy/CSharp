using System;
using System.Linq;

namespace Lesson28
{
    /*
     * Индексы и диапазоны
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 4, 5, 6, 77, 88 };
            /*
            Console.WriteLine(myArray[^1]); // Получачем первый элемент с конца
           
            Index  myIndex = ^1;
            Range myRange = 1..4;
         
            Range myRange = ^4..^1; // Берем 4 с конца и 1 с конца
       
            int[] myArray2 = myArray[myRange];
       
            int[] myarray2 = myArray[1..4];// Диапазоны ..4, 4..
            
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");
            */

            string str = "Hello world !!! . =)";
            Console.WriteLine(str[^2..]);

            }
    }
}
