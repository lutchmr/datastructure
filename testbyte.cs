using System;
namespace DataTypesDemo
{
    class testbyte
    {
        static void MainDemo(string[] args)
        {
            byte b = 66; //Byte Representation 1000010
            Console.WriteLine($"Decimal: {b}");
            Console.WriteLine($"Equivalent Character: {(char)b}");
            Console.WriteLine($"byte Min Value:{byte.MinValue} and Max Value:{byte.MaxValue}");
            Console.WriteLine($"byte Size:{sizeof(byte)} Byte");
            
            Console.ReadKey();
        }
    }
}
