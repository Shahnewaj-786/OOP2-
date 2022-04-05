using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    class Program
    {
        static void MyMethod( ref int x)
        {
            x = 50;
        }
        static void Main(string[] args)
        {
            int a = 10;
            //MyMethod(a); //pass by value 
            //(ref, out) keyword 
            MyMethod(ref a); //pass by reference 
            Console.WriteLine(a);
        }
    }
}
