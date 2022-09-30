class ls2
{


public static void Maindemo(String[]args)
{
    int[]element={45,87,30,20,97,63,75,34,88};
    int item=100;
    int noe=element.Length;
    bool flag = false;
    for (int i=0;i<noe;i++)
    {
        if (element[i]==item)
        {
            Console.WriteLine("The item "+ item +" is found in position "+(i+1));
            flag=false;
            break;
        }
        else
        flag=true;
        }
        if (flag==true)
        Console.WriteLine("The item "+ item +" is NOT Found.");
    }
}