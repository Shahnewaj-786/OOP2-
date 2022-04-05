using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.SetName("Shahnewaj");
            //Console.WriteLine(student.GetName());
            student.Name = "Shahnewaj";
            student.Id = "18-36146-1";
            student.Cgpa = 3.2f;
            student.University = "AIUB";
            //Console.WriteLine(student.Name);
            student.PrintStudent();
        }
    }
}
