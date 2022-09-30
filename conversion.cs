using System;
namespace Conversion
{
    class Convert
    {
        public static void Maindemo(string[] args)
        {
           
            {
                // declare variables
                
                decimal bottles;
                decimal number;
                Console.Write("Enter Number of Litres: ");      
                number= decimal.Parse(Console.ReadLine());
                bottles = (number / 5*10); 
                Console.Write(number +"L water will fill "+ decimal.Truncate(bottles)+" bottles " +"("+ Math.Round((number-Math.Truncate(number)),2) +"L remaining)");
            }
        }
    }
}