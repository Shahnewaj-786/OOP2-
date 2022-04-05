using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssociationHasARelation;
namespace Property
{
    class Student
    {
        //Fields 
        private string name, id;
        private float cgpa;
        private Address address; //one to one association 

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

        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        //AutoImplemented Property 

        public string University
        {
            set;
            get;
        }
        public void PrintStudent()
        {
            Console.WriteLine("Name:{0}\nID:{1}\nCGPA:{2}\nUniversity:{3}", this.name, this.id, this.cgpa,this.University);
            Console.WriteLine(this.address.GetAddress());
        }

    }
}
