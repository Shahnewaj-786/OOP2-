using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property;

namespace ClassVsInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = ""; //Instance member is accessed through object reference 
            Student.University = ""; //Class member is accessed through class reference 
            Console.WriteLine(Student.constFild);
            Console.WriteLine(student.readonlyField);
        }
    }
}
