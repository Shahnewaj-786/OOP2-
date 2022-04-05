using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{  abstract class Parent
    {
        abstract public void MyMethod();
    }

    abstract class Child: Parent
    {


        override public void MyMethod()
        {
            Console.WriteLine("Child -> MyMethod");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //new Parent();
           // Parent parent;
            //Parent parent = new Child();
           // parent.MyMethod();
        }
    }
}
