using System;

namespace Lesson23
{
    class Program
    {
        /*
         * Тернарные операторы - ? условие, затем true : false
         */
        static void Main(string[] args)
        {
            /*
            bool accessAllowed;
            string storePassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            accessAllowed = storePassword == enteredPassword ? true : false;

            Console.WriteLine(accessAllowed);
            Console.ReadLine();
            */

            int inputData = int.Parse(Console.ReadLine());

            int outputData = (inputData < 0) ? 1 : inputData; // Тернарные операторы сравнения
            Console.WriteLine(outputData);
            Console.ReadLine();

        }
    }
}
