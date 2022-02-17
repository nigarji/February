using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("Nigar", "Isa", "P127", 95);


            Console.WriteLine(student.GetInfo()); // Instance aldigi metod - constractor
            Console.WriteLine(student.Fullname()); //Bu metod yalniz ad ve familyanizi gosterir
            student.GRD(); //Bu metod sizin imtahan neticesini gosterir
            student.NextStep(95); //Bu metod sizin imtahana buraxilis neticesini gosterir

        }
    }
    class Student

    {
        public string Name;
        public string Lastname;
        public string Group;
        public int Point;


        public Student(string name, string lastname, string group, int point)

        {

            Name = name;
            Lastname = lastname;
            Group = group;
            Point = point;



        }
        public void GRD()
        {

            int point = 80;
            bool isGraduated = point >= 80;
            if (isGraduated)

                Console.WriteLine("Tebrikler. Siz mezun oldunuz!");
            else
            {
                Console.WriteLine("Imtahandan kesildiniz");
            }

        }


        public string GetInfo()
        {
            return Name + " " + Lastname + ":" + " " + Group + " -" + " " + Point;


        }
        public string Fullname()
        {

            return Name + " " + Lastname;

        }

        public void NextStep(int num)
        {

            if (num >= 80)

                Console.WriteLine("Tebrikler. Siz novbeti imtahana buraxilirsiniz");
        }
    }

}
