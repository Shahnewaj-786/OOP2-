using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Extend
    {
        public string accName;
        public string acid;
        public int balance;

        public string AccName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter acc name:");
                    Console.ReadKey();
                }
                else
                {
                    this.accName = value;
                }
            }
            get
            {
                return this.accName;
            }
        }

        public string accId
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine(" Enter ac id: ");
                    Console.ReadKey();
                }
                else
                {
                    this.acid = value;
                }
            }
            get
            {
                return this.accId;
            }

        }

        public int Balance

        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid balance ");
                    Console.ReadKey();
                }
                else
                {
                    this.balance = value;
                }
            }
            get
            {
                return this.balance;
            }
        }
        public Account()
        {
            Console.WriteLine(" -------- Account Details -------- ");
        }
        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;

        }
        public void Deposit(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Deposit amount is invalid");
                Console.ReadKey();

            }
            else
            {
                balance = balance + amount;
                Console.WriteLine("Deposite : " + balance);


            }

        }
        public void Withdraw(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid Withdrawal amount");
                Console.ReadKey();

            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient fund");
                Console.ReadKey();

            }
            else
            {
                balance = balance - amount;
                Console.WriteLine(" Withdraw : " + balance);


            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account name :" + accName + "\n account id : " + acid + "\n account balance" + balance);
            Console.ReadKey();
        }
        public int getbalance()
        {
            return balance;
        }


        public void Transfer(int amount, Account reciver)
        {
            Console.WriteLine("Enter amount to transfer: ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Enter The reciever Account id: ");
            reciver.accId = Console.ReadLine();
            Console.ReadKey();

            if (balance > amount)
            {
                balance -= amount;
                Console.WriteLine("Amount" + amount + "Transfered to" + reciver);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Invalid Transaction");
                Console.ReadKey();

            }
        }


        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.accName = "Md Abu Sufian";
            a1.acid = "1941749";
            a1.balance = 1545661;

            a1.ShowInfo();
            a1.Deposit(45678);
            a1.Withdraw(15980);

            a1.Transfer(8750, a1);


        }
    }
}
