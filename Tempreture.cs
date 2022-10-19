using System;

class Temperature
{
        public static void MainDemo(string[] args)
        {
           
           Console.Write("Enter temperature in Celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusFahrenheit(celsius);
            Console.WriteLine("The converted fahrenheit temperature is : " + fahrenheit);
            Console.ReadLine();
        }
        private static double CelsiusFahrenheit(double celsius)
        {
            return ((celsius * 9) / 5) + 32;
        }
        private static double FahrenheitCelcius(double Fahrenheit)
        {
            return ((Fahrenheit-32)*5/9);
        }
    }

