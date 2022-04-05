using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabCode
{
    public class Student
    {
        String name, id;
        float cgpa;

        public Student (String name, String id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }

        public void PrintStudent()
        {
            Console.WriteLine("Name:{0}, \n ID:{1}, \n CGPA{2}", this.name, this.id, this.cgpa);
        }
    }
}
