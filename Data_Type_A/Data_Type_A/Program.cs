using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;


namespace Data_Type_A
{
    class Program
    {
        static void Main(string[] args)
        {
            /* System.Console.Write("Enter your name: ");
             string name = System.Console.ReadLine();

             System.Console.Write("Enter your ID: ");
             string id = System.Console.ReadLine();

             System.Console.Write("Enter your semester: ");
             int semester = System.Convert.ToInt32(System.Console.ReadLine());

             System.Console.Write("Enter your cgpa: ");
             float cgpa = System.Convert.ToSingle(System.Console.ReadLine());

             System.Console.WriteLine("***************************************");

             System.Console.WriteLine("Name: {0}, \n ID: {1}, \n CGPA: {2}", name,id,cgpa);*/

            //MyLibrary.Student student = new MyLibrary.Student();

            Student student = new Student("Sanjida", "18-2", 3.9f);
            student.PrintStudent();

        }
    }
}
