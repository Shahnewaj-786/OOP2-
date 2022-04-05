using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ class Parent
    {
        public int myField;
        public void MyMethod()
        {
            Console.WriteLine("Paternt --> My method");
        }
    }

    class Child:Parent
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.MyMethod();

        }
    }
}
