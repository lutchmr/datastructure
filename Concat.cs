using System;
namespace addnums
{
    class Concat
    {
        public static void MainDemo(string[] args)
        {
           
            {
                // declare variables
                int num = 2;
                int num2 = 4;
                int num3 = 3;
                int tot1=num+num2;
                int tot2=tot1-num3;
                Console.WriteLine(">>>");
                Console.WriteLine($"The first number is {num}");
                Console.WriteLine($"The second number is {num2}");
                Console.WriteLine($"2 + 4 = {(tot1)}");
                Console.WriteLine($"6 - 3 = {(tot2)}");
                int Concatenating = Convert.ToInt32(string.Format("{0}{1}", tot1, tot2));
                Console.WriteLine($"The Concatenated Result is:\"{Concatenating}\"");
                //Console.WriteLine($"The Concatenated Result is:\"{tot1.ToString() + tot2.ToString()}\"");Alternative to line 22
                Console.WriteLine(">>>");
                
                
            }
        }
    }
} 