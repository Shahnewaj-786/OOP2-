using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property;


namespace ArrayCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimen array 

            //int[] numbers = new int[5];
            //numbers[0] = 10;
            //numbers[1] = 7;
            //numbers[2] = 15;
            //numbers[3] = 9;
            //numbers[4] = 5;
            //numbers[5] = 1000000; //exception 

            //aRRAY dECLARATION AND INItialiazon 
            //int[] numbers = new int[5] { 10, 7, 5, 15, 9 }; //Recomended for code 
            //int[] numbers = new int[] { 10, 7, 5, 15 }; 
            //int [] numbers = { 10, 7, 5, 15 };

            //Console.WriteLine(numbers.Rank);
            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers[2]);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach loop 

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}




            //MULTI dimenional array 

            //int[,] numbers = new int[2, 3];
            //numbers[0, 0] = 10;
            //numbers[0, 1] = 20;
            //numbers[0, 2] = 30;

            //numbers[1, 0] = 40;
            //numbers[1, 1] = 50;
            //numbers[1, 2] = 60;

            //int[,] numbers = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } }; //Recomended 

            //int[,] numbers = new int[ , ] { { 10, 20, 30 }, { 40, 50, 60 } };


            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.Rank);
            //Console.WriteLine(numbers[1,0]);

            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}


            //Jagged array 
            //int[][] numbers = new int[2][];
            //numbers [0] = new int [3] { 10,20,30};
            //numbers[1] = new int[2] { 40, 50 };


            //int[][] numbers = new int[2][] { new int[3] { 10, 20, 30 }, new int[2] { 40, 50 } };

            ////Console.WriteLine(numbers[0][1]);


            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write(numbers[i][j]+" ");
            //    }
            //    Console.Write("| ");
            //}

            //array object 

            //Student[] students = new Student[2];
            //Student student1 = new Student() { Name = "Shahnewaj", Id = "18-36146-1", Cgpa = 3.21f, University = "AIUB" };
            //Student student2 = new Student() { Name = "Nafiz", Id = "68-36146-1", Cgpa = 4.21f, University = "IUB" };
            //students[0] = student1;
            //students[1] = student2;

            Student[] students = new Student[2] { new Student() { Name = "Shahnewaj", Id = "18-36146-1", Cgpa = 3.21f, University = "AIUB" },
                                                  new Student() { Name = "Nafiz", Id = "68-36146-1", Cgpa = 4.21f, University = "IUB" }
                                                };
           
           

            for (int i = 0; i < students.Length; i++)
            {
                students[i].PrintStudent();
            }

        }
    }
}
