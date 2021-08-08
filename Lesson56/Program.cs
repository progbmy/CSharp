using System;

namespace Lesson56
{
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

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            // firstStudent.Print();
            string fullName = firstStudent.GetFullName();

        }
    }
}
