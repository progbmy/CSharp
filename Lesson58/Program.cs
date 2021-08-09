using System;

namespace Lesson58
{
    class Gun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            isLoaded = true;
            Console.WriteLine("Заряжен...");
        }

        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();

            }
            Console.WriteLine("Стреляем\n");
            isLoaded = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
        }
    }
}
