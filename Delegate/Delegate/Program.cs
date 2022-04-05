using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Sample
    {
        public void MyMethod(int x)
        {
            Console.WriteLine("MyMethod:"+x);
        }

        public void AnotherMethod(int x)
        {
            Console.WriteLine("AnotherMethod:" + x);
        }
    }

    //delegate delaration
    public delegate void MyDelegate(int a);



    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            MyDelegate myDelegate = new MyDelegate(s.MyMethod); //method subscription
            //myDelegate.Invoke(100);
            //myDelegate(200); //shortcut of Invoke
            myDelegate += s.AnotherMethod;
            myDelegate(500);
        }
    }
}
