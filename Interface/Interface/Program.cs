using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ISleepable
    {
        void Sleep();
        void Work();
    }

    interface IRunnable
    {
        void Run();
        void Work();
    }

    class Dog : ISleepable,IRunnable
    {
        public void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }

        public void Run()
        {
            Console.WriteLine("Dog is Running");
        }


        //Override any one of them

        //public void Work()
        //{
        //    Console.WriteLine("Dog is Working");
        //}

        //Explicite interface Implementation

        void ISleepable.Work()
        {
            Console.WriteLine("Dog is sleeping --> ISleepable");
        }

        void IRunnable.Work()
        {
            Console.WriteLine("Dog is sleeping --> IRunnable");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //dog.Sleep();
            //dog.Run();

            //ISleepable sleepable = new Dog();
            //sleepable.Sleep();

            //IRunnable runnable = (Dog) sleepable; //Downcasting
            //runnable.Run();

            //Dog dog = (Dog)sleepable; //Downcasting
            //dog.Run();

            ISleepable sleepable = new Dog();
            IRunnable runnable = new Dog();
            sleepable.Work();
            runnable.Work();
            Dog dog = new Dog();
            ((ISleepable)dog).Work();

        }
    }
}
