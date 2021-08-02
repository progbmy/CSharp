using System;

namespace LEsson51
{
    /*
     * Переполнение по верхней и нижней границе
     */
    class Program
    {
        static void Main(string[] args)
        {
            byte aggression = 0;
            byte democracyModifire = 1;
            aggression = checked((byte)(aggression - democracyModifire));
            Console.WriteLine(aggression);
        }
    }
}
