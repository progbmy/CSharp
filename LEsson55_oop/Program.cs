using System;

namespace LEsson55_oop
{
    //enum Color
    //{ 
    //    Red,
    //    Green,
    //    Orange,
    //    Yellow,
    //    Blue
    //}
    //class Point
    //{
    //    public int x;
    //    public int y;
    //    public Color color;

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Point p = new Point();
    //        p.x = 4;
    //        p.y = 2;
    //        p.color = Color.Orange;
    //        Console.WriteLine($"X: {p.x} | Y: {p.y} | Color: {p.color}");

    //        Point p2 = new Point();
    //        p2.x = 2;
    //        p2.y = 6;
    //    }
    // }

   
    class Program
    {
        static Student GetStudent()
        {
            var student = new Student();
            student.firstname = "Мартин";
            student.lastname = "Игоревич";
            student.middlename = "Рубинштейн";
            student.age = 38;
            student.id = Guid.NewGuid(); // Автогенерация id
            student.group = "Лихтенгельн1";
            return student;
        }

        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте");
            Console.WriteLine($"id: {student.id}");
            Console.WriteLine($"Фамилия: {student.lastname}");
            Console.WriteLine($"Имя: {student.firstname}");
            Console.WriteLine($"Отчество: {student.middlename}");
            Console.WriteLine($"Группа: {student.group}");       
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);   
        }
    }
}
