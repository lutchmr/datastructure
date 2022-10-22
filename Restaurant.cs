using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Declaring_Method
{
    class Program
        {
            string? name, city;
            int age;

            public void acceptdetails()
                {
                  Console.WriteLine("\n Enter your name: \t");
                  name = Console.ReadLine();

                  Console.WriteLine("\n Enter your city:\t");
                  city = Console.ReadLine();

                  Console.WriteLine("\n Enter your age: \t\t");
                  age = Convert.ToInt32(Console.ReadLine());
                }
            
            public void  printdetails()
                {
                    Console.Write("\n\n=========================");
                    Console.Write("\nName:\t" +name);
                    Console.Write("\nCity:\t" +city);
                    Console.Write("\nAge:\t" +age);
                    Console.Write("\n\n=========================");
                }

            static void MainDemo(string[] args)
                {
                    // create object of class Program
                    Program p = new Program();
                    p.acceptdetails(); // calling acceptdetails method
                    p.printdetails(); // calling printdetails method
                   

                }
        }

}