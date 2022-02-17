using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[5] { 40, 50, 60, 90, 100 };
            //int index = arr.Length;
            //int sum = 0;
            //int total = sum;
            //Console.WriteLine(Twomethods(arr,ref sum));
            //Console.WriteLine("Enter any key to see the number of students");
            //Console.ReadLine();
            //Console.WriteLine(Avrg(total,index));



            Student student = new Student("Nigar", "Isa", "P127",95);

           
            Console.WriteLine(student.GetInfo());
            Console.WriteLine(student.Fullname());
            student.grd();
            student.NextStep(95);






        }

        //static int Twomethods(int[] array,ref int sum)

        //{
        //    int[] students= new int[array.Length];  


        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum = array[i] + sum;

        //    }
        //    return sum;

        //}
        //static int Avrg(int total, int index)
        //{
        //    {
        //        total = total / index;

        //        return index;
        //    }


        //}



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
        public void grd ()
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
            Console.WriteLine("Bu metod yalniz ad ve familyanizi gosterir");
            return Name + " " + Lastname;

        }

        public void NextStep(int num)
        {
            Console.WriteLine("Bu metod sizin imtahana buraxilis neticesini gosterir");

            if (num>=80)

                Console.WriteLine("Tebrikler. Siz novbeti imtahana buraxilirsiniz");
        }
    }
}

