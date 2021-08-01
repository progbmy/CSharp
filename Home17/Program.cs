using System;

namespace Home17
{
    /*
     * Найти сумму числа с помощью рекурсии 561 = 12
     */
    class Program
    {
        static int Foo(int value)
        {
            if (value < 10)
                return value;
            int digit = value % 10; // Берем остаток от деления на 10
            int nextValue = value / 10; // Сохраняем результат деления на 10
            return digit + Foo(nextValue);
        }

        static void Main(string[] args)
        {
            int myValue = 561;

            int result = Foo(myValue);
        }
    }
}
