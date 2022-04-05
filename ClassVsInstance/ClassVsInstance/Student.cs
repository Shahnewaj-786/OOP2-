using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Student
    {
        //Instance or non static members
        //Fields 
        private string name, id;
        private float cgpa;


        //Const keyword 

        public const int constFild = 10;

        //readonly keyword 

        public readonly int readonlyField = 50;

        public Student()
        {
            // error we can not change class lvl const -->  constFild = 100;
            readonlyField = 500;
        }

        ////set, get methods
        //public void  SetName (string name)
        //{
        //    this.name = name;
        //}
        //public string GetName ()
        //{
        //    return this.name;
        //}

        //Property
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public float Cgpa
        {
            set
            {
                this.cgpa = value;
            }
            get
            {
                return this.cgpa;
            }
        }
        //AutoImplemented Property 

        public static string University
        {
            set;
            get;
        }
        public void PrintStudent()
        {
            Console.WriteLine("Name:{0}\nID:{1}\nCGPA:{2}\nUniversity:{3}", this.name, this.id, this.cgpa,Student.University);
        }

        public void NonStaticMethod()
        {
            this.id = "";
            Student.University = "";
        }


        public static void StaticMethod()
        {
            Student.University = "";
            Student student = new Student();
            student.Id = "";
        }

    }
}
