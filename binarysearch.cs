using System;
namespace searching
{
    class bs1
{
    public static void MainDemo(String[]args)
    {
        int[] element={20,30,34,45,63,75,87,88};
        int item=63;
        int noe=element.Length;
        int lowidx=0;
        int highidx=noe-1;
        int mididx=(lowidx+highidx)/2;
        bool flag = false;
        for(int i=0;i<noe;i++)
        {
            if(element[mididx]==item)
            {
            Console.WriteLine("Item found at position " + (mididx+1));
            flag=true;
            break;
            }
            else
            if (item> element[mididx])
            lowidx=mididx;
            if (item < element[mididx])
            highidx=mididx;
        }
                if (flag == false)
                Console.WriteLine("Item is NOT found.");
    }

}
}
