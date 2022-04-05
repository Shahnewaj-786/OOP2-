using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamManagement
{
    class Manager
    {
        private int yearsOfEcperience;

        public Manager(int yearsOfExperience)
        {
            this.yearsOfEcperience = yearsOfExperience;
        }

        public void EmployeeStatus (Manager manager)
        {
            if (yearsOfEcperience > 4)
            {
              bool =  true;
            }
            else
            {
                return false; 
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("*********Manager**********");
            Console.WriteLine("Years of Experience: \n",this.yearsOfEcperience);

        }
    }
}
