using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._22_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student student = new Student("Kamran", "Abilov");
            Student student1 = new Student("Oruc", "Dostuyev");
            Student student2 = new Student("Leo", "Messi");
            Student student3 = new Student("Tiago", "Messi");


            Group group = new Group("P111", 3);
            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            foreach (Student stu in group.GetStudents())
            {
                Console.WriteLine($"Name: {stu.Name}\nSurname: {stu.Surname}");
            }

        }
    }
}
