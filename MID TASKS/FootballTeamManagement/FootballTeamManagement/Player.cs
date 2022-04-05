using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FootballTeamManagement
{
    class Player : Employee
    {
        private double rating;
        static int wagwPerMatch = 1000;
        private int noOfMatches;

        public Player(double rating, int noOfMatches)

        {
            this.rating = rating;
            this.noOfMatches = noOfMatches;
        }

        public void PrintInfo()
        {
            Console.WriteLine("********************Player*******************");
            Console.WriteLine("Rating:{0}\n", this.rating);
            Console.WriteLine("Number of Matches:{1}\n",this.noOfMatches);
            Console.WriteLine("************************************************");
        }
    }
}
