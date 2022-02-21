using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Group
    {
       public string No;
       public int Limit;
        Student[] _students;
        public Group(string no,int limit)
        {
            No=no;
            Limit=limit;
            _students = new Student[Limit];
        }
        public void GetStudent()
        {
            foreach (Student item in _students)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Info());
                }
                
            }
        }
        public Student [] AddStudent(Student person)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i]==null)
                {
                    _students[i] = person;
                    break;
                }
            }
            return _students;
        }

        






    }
}
