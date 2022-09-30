using System;
namespace RecursionDemo
{
     class Program
     {
          static void MainDemo(string[] args)
           {
                int x = 3;
                fun2(x);
                Console.ReadKey();
            }
            
            static void fun2(int n)
            {
                if (n > 0)
                {
                    fun2(n - 1);
                    Console.Write($"{n} ");
                }
            }
     }
}
