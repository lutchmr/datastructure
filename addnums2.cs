using System;

namespace add_subtact
{

    class Functions
    {
            public int add(int a, int b)
            {
                return(a+b);
            }

            public int subtract(int a, int b)
            {
                return(a-b);
            }
    }

    class Program
    {
        public static void MainDemo(string[] args)
        {
            Functions res= new Functions();
            int result1=res.add(2,4);
            int result2= res.subtract(result1,3);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(">>>");
                Console.WriteLine($"The first number is  2");
                Console.WriteLine($"The second number is 4");
                Console.WriteLine($"2 + 4 =  {result1}");
                Console.WriteLine($"6 - 3 =  {result2}");
                Console.WriteLine(">>>");



        }
    }
}

