using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_Sharp
{
    public class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool Type;

        public Student(string fullname, string groupno, bool type=false)
        {
            Fullname = fullname;
            GroupNo = groupno;
                                
            Type = type;
        }
        public void GetInfo()
        {
            Console.WriteLine("Student Fullname:" +" "+ Fullname );
            Console.WriteLine("Student Group No:" + " " + GroupNo);
            if (Type)
            {
                Console.WriteLine("Student Type:" + " " + "zemanetlidir");

            }
            else
            {
                Console.WriteLine("Student Type:" + " " + "zemanetli deyil");
            }
            Console.WriteLine();
        }

    }
}
