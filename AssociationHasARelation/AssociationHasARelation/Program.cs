using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property;

namespace AssociationHasARelation
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("2nd Lane", "85/A", "Kalabagan");
            Student student1 = new Student() { Name = "Shahnewaj", Id = "18-36146-1", Cgpa = 3.21f, University = "AIUB", Address=address1};
            //student1.PrintStudent();
            University university = new University("AIUB", 5);
            university.AddStudent(student1);
            university.PrintStudentsInformation();
        }
    }
}
