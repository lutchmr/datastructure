using System;
namespace PointerData
{
    class demopointer
    {
        public static void MainDemo(string[] args)
        {
            unsafe
            {
                // declare a variable
                int number = 10;
                // store variable number address location in pointer variable ptr
                int* ptr = &number;
                Console.WriteLine($"Value :{number}");
                Console.WriteLine($"Address :{(int)ptr}");
                
            }
        }
    }
}
