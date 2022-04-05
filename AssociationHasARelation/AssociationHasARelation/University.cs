using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property;

namespace AssociationHasARelation
{
    class University
    {
        private string name;
        private Student[] students;

        public University(string name, int size)
        {
            this.name = name;
            students = new Student[size];

        }
        public void AddStudent(Student student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    students[i] = student;
                    break;
                }
            }
        }

        public void PrintStudentsInformation()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    continue;
                }
                else
                {
                    students[i].PrintStudent();
                }
                
            }
        }
    }
}
