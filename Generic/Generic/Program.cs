using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{ 
    class Person
    {
        public string name;
    }
    
    class MyGenericClass<T,U> where T:class
    {
        public T myField;
        public void MyMethod(U x)
        {
            Console.WriteLine(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyGenericClass<int> myGenericClass = new MyGenericClass<int>();
            //myGenericClass.myField = 10;
            ////Console.WriteLine(myGenericClass.myField);
            //myGenericClass.MyMethod(500);


            //MyGenericClass<string> myGenericClass1 = new MyGenericClass<string>();
            //myGenericClass1.myField = "Hola";
            //Console.WriteLine(myGenericClass1.myField);


            //MyGenericClass<int,float> myGenericClass = new MyGenericClass<int,float>();
            MyGenericClass<Person, float> myGenericClass = new MyGenericClass<Person, float>();
            myGenericClass.myField = new Person();
            myGenericClass.myField.name = "Shahnewaj";
            //Console.WriteLine(myGenericClass.myField);
            myGenericClass.MyMethod(500.4f);
            myGenericClass.MyMethod(400.4f);
        }
    }
}
