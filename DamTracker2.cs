using System;

namespace Dam
{
  class Track
  {
    static void MainDemo
    (string[] args)
    {
          
            decimal released; //amount water released in ml
            decimal amtreleased;//amount water released in L
            decimal remaining; //capacity - amtreleased
            decimal capacity=1000000;//capacity - amtreleased
            decimal premain; // % remaining
            decimal reference=1000; //conversion from ml to L
          
           Console.WriteLine(">>>");

           Console.WriteLine("How many millilitres of water were released?: ");
           released= Convert.ToDecimal(Console.ReadLine());
         
            
            
            amtreleased = released/reference;
            remaining =  capacity - amtreleased;
            premain = (remaining / capacity)*100;

          
            Console.WriteLine("=================REPORT===================");
            Console.WriteLine($"Amount of water released: {Math.Round (amtreleased,1)}L") ;
            Console.WriteLine($"Amount of water left: {Math.Round(remaining,1)}L") ;
            Console.WriteLine($"Percentage: {Math.Round (premain, 1)}%") ;
            Console.WriteLine("=================REPORT===================");
            Console.WriteLine(">>>");

            

    }
  }
}
