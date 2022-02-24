using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._22_Homework
{
    class Group
    {
        public string No;
        public int Limit;

        public Student[] _students;

        public Group(string no, int limit)
        {
            No = no;
            Limit = limit;
        }
        public void AddStudent(Student student)
        {

            if (_students.Length < Limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("yer yoxdur");
            }
        }
        public Student[] GetStudents()
        {
            return _students;
        }
    }

}

