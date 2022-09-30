using System;
namespace bubblesort2
{

class bsort
{

     public static void MainDemo(String[] args)
    {
    int[] element= {45,87,30,20,97,63,75,34,88,65,30,27,65,30,27,45,30,48,99};
    int noe = element.Length-1;
    int i,j,temp;

    for (i=0;i< noe;i++)
    for (j=0;j< noe;j++)
     {
        if (element[j]>element[j+1])
        {
        temp=element[j];
        element[j]=element[j+1];
        element[j+1]=temp;
        }
     
    }
     //for (i=0;i<noe;i++)
     //Console.WriteLine(element[i]+ "");
     Console.WriteLine("Sorted:");
           foreach (int p in element)
               Console.Write(p + " ");
           Console.Read();
  }
  
}
}