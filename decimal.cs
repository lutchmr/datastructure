using System;
namespace NumericDemo
{
    class numericdemo01
    {
        static void MainDemo(string[] args)
        {
           /* float a = 1.123f;      //Single a = 1.123f;
            double b = 1.456;      //Double b = 1.456;
            decimal c = 1.789m;    //Decimal c = 1.789M;*/
            
            Console.WriteLine($"float Size:{sizeof(float)} Byte");
            Console.WriteLine($"float Min Value:{float.MinValue} and Max Value:{float.MaxValue}");
            Console.WriteLine($"double Size:{sizeof(double)} Byte");
            Console.WriteLine($"double Min Value:{double.MinValue} and Max Value:{double.MaxValue}");
            Console.WriteLine($"decimal Size:{sizeof(decimal)} Byte");
            Console.WriteLine($"decimal Min Value:{decimal.MinValue} and Max Value:{decimal.MaxValue}");
            Console.ReadKey();
        }
    }
}

