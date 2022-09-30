class Search
{
    public static void MainDemo()
   {
    int [] mydata= {20,50,60,90,70,99};
    int searchdata = 100;
    int totalcount=mydata.Count();
    for (int i=0;i<totalcount;i++)
    {
    if (mydata[i] == searchdata)
   {
        Console.WriteLine("We Found Data:"+searchdata +" Found data in position:" + (i+1));
     break;
   }
     else 
     if (mydata[i] != searchdata)
     {
     Console.WriteLine("data not found in position:"+(i+1) );
     }
    } 
  
    
    }
}