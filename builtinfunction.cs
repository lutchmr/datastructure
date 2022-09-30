using System;
namespace FunctionDemo
{
    class builtinfunctions
    {
        static void Maindemo(string[] args)
        {
            int number = 25;
            double squareRoot = Math.Sqrt(number);
            //Console.WriteLine($"Square Root of {number} is {squareRoot}");
            Console.WriteLine("Square Root of " + number + " is " + squareRoot);
            Console.ReadKey();
        }
    }
}
