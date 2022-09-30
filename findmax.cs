class FindMax
{
   
 public static void MainDemo()
{
    int [] marks ={55,75,87,90,45,76};//marks is an array
    int largenum = marks [0];
    for (int i=1;i<6;i++)
    {
        if (marks[i]>largenum) 
        {
            largenum=marks[i];
        }
    }

Console.WriteLine("The largest number is:"+largenum);
} 
}






