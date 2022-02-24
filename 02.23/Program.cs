using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Enter your Fullname");
       
           bool validFullname = false;
            while (!validFullname)
            {
                string fullname = Console.ReadLine();
                 validFullname = Student.FullName(fullname);
                if (!validFullname)
                {
                    Console.WriteLine("Your fullname is not validated.Try again.");
                }
            }
            
            
            Console.WriteLine("Enter your GroupNo");
            bool validGroupNo = false;

            while (!validGroupNo)

            {
                string groupNo = Console.ReadLine();
                validGroupNo = Student.GroupNumber(groupNo);
                if (!validGroupNo)
                {
                    Console.WriteLine("Your GroupNo is not validated.Try again.");
                }

            }

           
         

       
        }
    }
}
