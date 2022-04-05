using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> hobbies = new List<string>();
            hobbies.Add("Reading");
            hobbies.Add("Swimming");
            hobbies.Add("Learning");
            hobbies.Add("Travelling");

            foreach (string item in hobbies)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
