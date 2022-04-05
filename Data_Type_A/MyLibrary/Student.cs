using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Student
    {

        string name, id;
        float cgpa;

        public Student (string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }

        public void PrintStudent()
        {
            Console.WriteLine("Name: {0}, \n ID: {1}, \n CGPA: {2}", this.name, this.id, this.cgpa);
        }

    }
}
