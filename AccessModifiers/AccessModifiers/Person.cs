using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public  class Person
    {
        public string name = "Shahnewaj";
        private int voterID = 100;
        protected string email = "shsb@gmail.com";
        internal string address = "Dhaka";
        protected internal string bloodGroup = "O+";

        public Person()
        {
            //this.name = "";
            //this.voterID = 0;
            //this.email = "";
            //this.address = "";
            //this.bloodGroup = "";
        }

    }
}
