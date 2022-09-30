using System;
using System.Collections.Generic;

class Factorial
{
    public static void MainDemo()
   {
      { int j ;
      string? val= "";
      Console.WriteLine("enter an integer:"); 
      val = Console.ReadLine();
      int a = Convert.ToInt32(val);
      while (a >0);
      j=(a*(a-1));
      a=a--;
      Console.WriteLine("Factorial of:" + a + "is:" + j);
       }

    }
}
