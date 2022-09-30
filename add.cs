using System;
namespace PointerData2
{
    class demopointer
    {
        public static void MainDemo(string[] args)
        {
            unsafe
            {
                // declare a variable
                int number = 10;
                int number2 = 20;
                // store variable number address location in pointer variable ptr and ptr2
                int* ptr = &number;
                int* ptr2 = &number2;
                Console.WriteLine($"Pointer Value is :{*ptr+ *ptr2}");
                Console.WriteLine($"Address of "+*ptr +" is:"+(int)ptr);
                 Console.WriteLine($"Address of "+*ptr2 +" is:"+(int)ptr2);
                Console.ReadKey();
            }
        }
    }
}
