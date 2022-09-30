using System;
using System.Collections.Generic;

class FactorialExamples  
   {  
     public static void MainDemo(string[] args)  
      {  
       int i,fact=1,number;      
       Console.Write("Enter any Number: ");      
       number= Convert.ToInt32(Console.ReadLine());     
       for(i=1;i<=number;i++){      
        fact=fact*i;      
       }      
       Console.Write("Factorial of " +number+" is: "+fact);    
     }  
  }