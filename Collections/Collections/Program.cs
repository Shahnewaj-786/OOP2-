using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> cities = new List<string>();
            //cities.Add("Dhaka");
            //cities.Add("Khulna");
            //cities.Add("Sylet");
            //cities.Add("Barlin");
            //cities.Add("Tokeyo");
            //cities.Add("Dhaka");
            //cities.Add("Khulna");
            //cities.Add("Sylet");
            //cities.Add("Barlin");
            //cities.Add("Tokeyo");
            //cities.Add("Dhaka");
            //cities.Add("Khulna");
            //cities.Add("Sylet");
            //cities.Add("Barlin");
            //cities.Add("Dhaka");
            //cities.Add("Khulna");
            //cities.Add("Sylet");
            //cities.Add("Barlin");
            //cities.Add("Dhaka");
            //cities.Add("Khulna");
            //cities.Add("Sylet");
            //cities.Add("Barlin");


            //cities.TrimExcess();

            //Console.WriteLine("Count:"+cities.Count);
            //Console.WriteLine("Capacity: "+cities.Capacity);

            ////Console.WriteLine(cities[1]);
            //Console.WriteLine("****************************************");

            ////cities.Reverse(); //for just reverse list
            ////cities.Sort();   //for sort list 
            //foreach(string item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            List<Student> students = new List<Student>();
            Student student1 = new Student() { id = 1, name = "Xian" };
            students.Add(student1);

            students.Add(new Student() { id = 2, name = "Yan" });

            foreach(Student student in students)
            {
                Console.Write(student.id +" " );
                Console.WriteLine(student.name);
            }
        }
    }
}
