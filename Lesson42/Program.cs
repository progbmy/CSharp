using System;

namespace Lesson42
{
    /*
     *  Оператр условного null ?.
     * 
     */
    class Program
    {
        /*
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        
        
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("Сумма элементов массива " + (myArray?.Length??0)); // Работа оператора ?. после ?? выводим дефолтное значение
        }
        * Первый блок
        */

        static Person GetPerson()
        {
            Person person = new Person() { Contacts = new Contacts() { PhoneNumber = "123456789"} };
            return person;
        }

        static void Main(string[] args)
        {
            Person person = GetPerson();
            string phoneNumber = person.Contacts.PhoneNumber;
            Console.WriteLine(phoneNumber);
        
        }
    }
}
