using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Account
    {
        private string accName;
        private int accNo;
        private double balance;

        public Account(string accName, int accNo, double balance)
        {
            this.accName = accName;
            this.accNo = accNo;
            this.balance = balance;
        }

        public void Set(string accName, int accNo, double balance)
        {
            this.accName = accName;
            this.accNo = accNo;
            this.balance = balance;
        }

        public string GetName()
        {
            return this.accName;
        }

        public int GetNo()
        {
            return this.accNo;
        }

        public double Getbalance()
        {
            return this.balance;
        }

        public void Deposite(double amount)
        {
            if (amount != 0)
            {
                this.balance = balance + amount;
                Console.WriteLine("Deposited: {0}\nNew balance: {1}", amount, this.balance);
            }
            else
            {
                Console.WriteLine("Emptm");
            }

        }

        public void Withdraw(double amount)
        {
            if (amount >= balance)
            {
                Console.WriteLine("Not enough balance");
            }
            else if (amount <= balance)
            {
                this.balance = balance - amount;
                Console.WriteLine("Withdrawn: {0}\nNew balance: {1}", amount, this.balance);
            }
            else
            {
                Console.WriteLine("Check Balance ");
            }
        }

        public void Transfer(double amount, string reciever)
        {
            if (amount != 0)
            {
                this.balance = balance - amount;
                Console.WriteLine("{0} recieved {1}\nYour new balance: {2}", reciever, amount, balance);
            }
            else
            {
                Console.WriteLine("Please sent proper amount");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account name: {0}\nAccount no: {1}\nAccount balance: {2}", accName, accNo, balance);
        }
    }
}
