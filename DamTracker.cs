using System;
namespace DamTracker
{
    class Tracker
    {
        public static void MainDemo(string[] args)
        {
           
            {
                // declare variables
                
                double reference=1000; //conversion from ml to L
                double capacity = 1000000; // damn capacity
                double released; //amount water released in ml
                double amtreleased; //amount water released in L
                double remaining; //capacity - amtreleased
                double premain; // % remaining

                
                Console.WriteLine(">>>");
                Console.Write("How many millilitres of water where released?:");      
                released= Convert.ToDouble(Console.ReadLine());
                //released= int.Parse(Console.ReadLine());
                amtreleased=released / reference;
                remaining=capacity - amtreleased;
                premain=(remaining / capacity)*100;
                Console.WriteLine("=================REPORT===================");
                Console.WriteLine($"Amount of water released: {Math.Round(amtreleased,1)} L");
                Console.WriteLine($"Amount of water left: {Math.Round(remaining,1)} L");
                Console.WriteLine($"Percentage: {Math.Round(premain,1)} %");

                //Console.WriteLine($"Amount of water released: "+(amtreleased=Math.Round(((double)released / reference),2))+"L");
                //Console.WriteLine("Amount of water left: "+(remaining=Math.Round(((double)capacity - amtreleased),2))+ "L");
               // Console.WriteLine("Percentage: "+ (premain=Math.Round(((double)(remaining / capacity)*100),2))+"%");
                Console.WriteLine("=================REPORT===================");
                Console.WriteLine(">>>");
            }
        }
    }
}