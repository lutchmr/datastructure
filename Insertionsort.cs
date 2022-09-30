using System;
namespace insertionsort
{
    class MyInsertionSort
    {
        public static void MainDemo(String[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13, 39, 98, 200, 700, 1 };
            int j,i,temp;
            int noe = arr.Length;
            for (i = 1; i < noe; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
            for (i = 0; i < noe; i++)
                Console.Write(arr[i] + " ");
        }
    }
}   

