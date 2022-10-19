using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
namespace Celsius_to_Fahrenheit_consversion {  
    class Program {  
        static void MainDemo(string[] args) {  
            double f, c;  
            Console.WriteLine("Enter the value of Celsius:");  
            c = Convert.ToDouble(Console.ReadLine());  
            f = c * 9 / 5 + 32;  
            Console.WriteLine(c + "°C in Fahrenheit is: " + f + "°F");  
            Console.WriteLine("Enter the value of Fahrenheit:");  
            f = Convert.ToDouble(Console.ReadLine());  
            c = (f - 32) * 5 / 9;  
            Console.WriteLine(f + "°F in Celsius is: " + c + "°C");  
            Console.ReadLine();  
        }  
    }  
    
}  
