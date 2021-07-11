using System;

namespace Lesson41
{
    /*
     * Оператор присваивания объединения со значением null ??=
     * 
     */
    class Program
    {
        /*
        static void Main(string[] args)
        {
            string str = null;
            str ??= "Default string"; // Работа оператора ??=
            // или
            str ??= string.Empty; // Присваиваем переменной явно пустое значение
            Console.WriteLine("Количество символов в строке: " + str.Length);
        }
        */

        static int[] GetArray()
        {
            //int[] myArray = null;
            int[] myArray = new int[10];
            return myArray;
        
        }
        
        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            myArray ??= new int[0];

            Console.WriteLine("Кол-во элементов в массиве: " + myArray.Length);
        
        
        }
    }
}
