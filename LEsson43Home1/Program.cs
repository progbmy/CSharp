using System;

namespace LEsson43Home1
{
    /*
     * Создать методы для добавления элемента в начало массива,
     * в конец массива и по указанному индуексу.
     * 
     * 
     */
    class Program
    {

        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < value; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            array = newArray;
        }
        static void AddFirst(ref int[] array, int value)
        {
            Insert(ref array, value, 0); // Добавление в массив под индесом 0 новый элемент
        
        }

        static void AddLast(ref int[] array, int value)
        {
            Insert(ref array, value, array.Length);
        }

        static void Main(string[] args)
        {
            int[] myArray = {1, 3, 5};

            AddFirst(ref myArray, -5);

        }
    }
}
