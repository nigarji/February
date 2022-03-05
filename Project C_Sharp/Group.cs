using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_Sharp
{
    public class Group
    {
        public string No;
        public string Category;
        public bool IsOnline;
        public int Limit;
        public Student[] Students=new Student[] {};
        public Group(string groupNo, int limit, string category, 
            bool isOnline = false)
        {
            No = groupNo;
            IsOnline = isOnline;
            Category = category;
            Limit = limit;

        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 4 || !char.IsLetter(groupNo[0]))
            {
                return false;
            }

                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (char.IsLetter(groupNo[i]))
                    {
                    return false;                  
                    }
                   
                }
            return true;
        }

        public void ShowListGroups(string studentList, string groupNo)
        {

        }

        public void EditGroup(string groupNo, string newGroup)
        {
        }
        public static void AddStu(Student student, string groupNo, Group[] grouplist)
        {
        }
    }
}
