using System;
using System.Threading.Tasks;
using System.Linq;

namespace Lesson27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 2, 44, 45, 44, 2, 35, 56, 2 };
          
            Console.WriteLine(myarray.Where(i => i % 2 == 0).Sum()); // Вывод суммы четных чисел
            Console.WriteLine(myarray.Where(i => i % 2 != 0).Min()); // Самое маленькое число в массиве
            int[] result = myarray.Distinct().ToArray(); // Выводим уникальные значения массива и пишем в др массив
            int[] res = myarray.OrderBy(i => i).ToArray();
            int minar = Array.Find(myarray, i => i < 70); // All
              

        }
    }
}
