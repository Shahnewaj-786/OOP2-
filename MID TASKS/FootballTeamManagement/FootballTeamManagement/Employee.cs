using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssociationHasARelation;

namespace FootballTeamManagement
{
    class Employee
    {
        public string id, name;
        public Address address;


        public Employee(string name, string address)
        {
            this.name = name;
        }

        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public void PrintInfo()
        {
            Console.WriteLine("********************Employee*******************");
            Console.WriteLine("Name:{0}\n", this.name);
            Console.WriteLine(this.address.GetAddress());
            Console.WriteLine("************************************************");
        }
    }
}
