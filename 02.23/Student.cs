using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._23
{
    internal class Student
    {
        public string Fullname;
        public string GroupNo;
        public int Age;

        public Student(string fullname, string groupno, int age)
        {
            this.Fullname= fullname;
            this.GroupNo= groupno;
            this.Age=age;   
        }

        public static bool FullName(string fullname)
        {
            fullname=fullname.Trim();
            string[] arr = fullname.Split(' '); //nigar ismayilova
            
            if(arr.Length==2)              
            {
                for (int i = 1; i < arr[0].Length; i++)
                {
                    if ( Char.IsLower(arr[0][0]) || Char.IsUpper(arr[0][i]))
                    {
                        return false;

                    }
                }

                for (int i = 1; i < arr[1].Length; i++)

                {
                    if (Char.IsLower(arr[1][0]) || Char.IsUpper(arr[1][i]))
                    {
                        return false;

                    }
                }
                return true;
            }
            return false;  
        }

        public static bool GroupNumber(string groupNum)
       
        { 

            if(groupNum.Length!=4 || Char.IsLower(groupNum[0]))

            {
                return false;
            }

            for (int i = 1; i < groupNum.Length; i++)
            {
                if (!Char.IsDigit(groupNum[i]))
                    return false;
            }
            return true;
        }

    }
}
