using System;

namespace Conversion2
{
    class Program
    {
        static void MainDemo(string[] args)
        {
            decimal litres; // input
            decimal bottleCap=500; // bottle capacity = 500ml
            decimal reference = 1000;//convert litres to ml
            decimal bottles; // result in number of bottles
            decimal mlWater;//convert Litres to ml
            decimal mlUsed;
            decimal litreUsed;
            decimal remainder;//refers to after decimal
            decimal bottlesWhole;
           Console.WriteLine(">>>");

            Console.WriteLine("Enter number of litres: ");
            litres = Convert.ToDecimal(Console.ReadLine());
            

            mlWater = litres * reference;
            bottles = mlWater / bottleCap;


            
           bottlesWhole = Decimal.Truncate(bottles);//obtain a whole number for bottles


            mlUsed = bottlesWhole * bottleCap;//converting whole bottles to ml
            litreUsed = mlUsed / 1000; // converting ml to whole litres used
            remainder = litres - litreUsed;

            Console.WriteLine("{0}L water fill {1} bottles ({2}L remain)", Math.Round(litres,2), bottlesWhole, Math.Round(remainder, 2));
            Console.WriteLine(">>>");
            
        }
    }
}
