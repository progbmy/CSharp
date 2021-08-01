using System;

namespace Home15
{
    /*
     * 
     */
    class Program
    {
        static void PrinArray(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                PrinArray(myArray, i + 1);
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 5,3,5,6};

            PrinArray(myArray);
        }
    }
}
