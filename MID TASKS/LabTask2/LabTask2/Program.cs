using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property;
using AssociationHasARelation;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("20/A", "7-B", "Kuratoli");
            Student student1 = new Student() { Name = "Shakib", Id = "18-yyyyy-1", Cgpa = 3.5f, University = "AIUB", Address = address1 };
            //student1.PrintStudent();
            University university = new University("AIUB", 5);
            university.AddStudent(student1);
            university.AddStudent(new Student() { Name = "X", Id = "18-yyyyy-1", Cgpa = 3.75f, University = "AIUB", Address = new Address("10", "9", "Banani") });
            university.AddStudent(new Student() { Name = "Y", Id = "18-yyyyy-2", Cgpa = 3.50f, University = "AIUB", Address = new Address("9", "8", "Mohammadpur") });
            university.AddStudent(new Student() { Name = "Z", Id = "18-yyyyy-3", Cgpa = 3.85f, University = "AIUB", Address = new Address("15", "10", "Dhanmondi") });
            university.AddStudent(new Student() { Name = "F", Id = "19-yyyyy-1", Cgpa = 3.80f, University = "AIUB", Address = new Address("22", "13", "Kuril") });
            university.AddStudent(new Student() { Name = "K", Id = "19-yyyyy-2", Cgpa = 3.60f, University = "AIUB", Address = new Address("2", "13", "Bashundhara") });
            Console.WriteLine("============================");
            university.PrintStudentsInformation();
        }
    }
}
