using System;

namespace Lesson43Home2
{

    /*
     *  Методы которые удаляют первый и последний элемент массива
     * 
     */
    class Program
    {
        static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];
            array = newArray;
            
        }
        static void RemoveFirst(ref int[] array)
        {
            RemoveAt(ref array, 0);
        }

        static void RemoveLast(ref int[] array)
        {
            RemoveAt(ref array, array.Length -1);
        
        }

        static void Main(string[] args)
        {
            int[] myArray = { 2, 4, 5, 6};
            //   RemoveAt(ref myArray, 2);
            RemoveFirst(ref myArray);

        }
    }
}
