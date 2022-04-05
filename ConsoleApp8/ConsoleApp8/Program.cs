using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter Name: ");
            string name = Console.ReadLine();
           
            Console.Write("Please enter ID: ");
            string id = Console.ReadLine();
            
            Console.Write("Enter your CGPA: ");
            float cg = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your ID is: " + id);
            Console.WriteLine("Your CGPA is: " + cg);


        }
    }
}
