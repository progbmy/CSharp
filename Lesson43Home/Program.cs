using System;

namespace Lesson43Home
{

    /* Метод Resize изменяющий количество элементов массива
     * (должен иметь возможность увеличить или уменьшить количество элементов массива)
     * 
     *  Resize<> - позволяет указать что принимаются люой тип данных в массив
     *  T - Шаблон
     */
    class Program
    {

        static void Resize<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            // int[] myArray = { 1, 2, 3};
            string[] myArray = {"one", "two", "free" };

            Resize(ref myArray, 10);
        }
    }
}
