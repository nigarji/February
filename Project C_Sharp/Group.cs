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

        public Group()
        {

        }
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

        public void ShowListStudents()
        {
            foreach (Student student in Students)
            {
                student.GetInfo();
            }
        }
        public static void NewStuInGroup(Student newstudent, Group[] grouplist)
        {
            foreach (Group grp in grouplist) 
            {
                if (grp.No==newstudent.GroupNo)
                {
                    grp.AddStudent(newstudent);
                    break;
                }
            }
            
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length-1]=student;
        }
        public static void NewGroupNo(string newGroupNo, string oldGroupNo, Group[] grouplist)
        
        {
            foreach (Group grp in grouplist)
            {
                if (grp.No==oldGroupNo)
                {
                    grp.No = newGroupNo;
                    break;
                }
            }
        }
    }
}
