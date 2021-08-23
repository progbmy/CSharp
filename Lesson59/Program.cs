using System;

namespace Lesson59
{
    class Program
    {
        class Gun
        {
            public Gun(bool isLoaded)
            {
                _isLoaded = isLoaded;
            }

            private bool _isLoaded;
            private void Reload()
            {
                Console.WriteLine("Заряжаю...");
                _isLoaded = true;
                Console.WriteLine("Заряжено...");
            }
            public void Shoot()
            {
                if (!_isLoaded)
                {
                    Console.WriteLine("Орудие заряжено!");
                    Reload();
                }
                Console.WriteLine("Бах-Бах\n");
                _isLoaded = false;
            }
        }
            
            
        static void Main(string[] args)
        {
            Gun gun = new Gun(isLoaded: true);
            gun.Shoot();
        }
    }
}
