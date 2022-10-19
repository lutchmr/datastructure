using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempratureProject
{
    class Program
    {
        static void MainDemo(string[] args)
        {   
            //Ask for the Temperature that the user wants to convert
            Console.WriteLine("What is the Temperature you wish to convert?");
            var RInput = Console.ReadLine();
            double dInput = Convert.ToDouble(RInput);
            //Ask for what type of conversion
            Console.WriteLine("If you wish to convert Fahrenheit to Celsius, Press 1");
            Console.WriteLine("If you wish to convert Celsius to Fahrenheit, Press 2");
            //Set YInput equal to the choice made
            var YInput = Console.ReadLine();
              int iInput = Convert.ToInt32(YInput);
            //Use of a a series of If statements to call the methods
              if (iInput == 1)
              {
                  var aAnswer = FtoCelsius(dInput);

                  Console.WriteLine("The value of {0} °F is equal to {1} °C", dInput, aAnswer);
              }
              
              else if (iInput == 2)
              {
                  var cAnswer = CtoFahenreit(dInput);

                  Console.WriteLine("The value of {0} °C is equal to {1} °F", dInput, cAnswer);
              }
              


        }
        //The various methods
        
        static double FtoCelsius(double CTempIn)
        {
             Double fCels =(CTempIn-32)*5/9;
            return fCels;
        }
         static double CtoFahenreit(double CtempIn)
        {
             double dFahr =(CtempIn*9/5)+32;
            return dFahr;
        }
         
        
    }
} 