using System;

class Movies
{
        public static void MainDemo(string[] args)
            {
            string? age="";
            int charge;
            do
            {
            Console.WriteLine("enter age");
            age =Console.ReadLine();
            if (age =="q")
             break;
            int a = Convert.ToInt32(age);
            if (a < 3)
            charge= 0;
            else if (a>=3 & a<=12)
            {
            charge=10;
            }
            else
            {
                charge=15;
            }
            Console.WriteLine("The Ticket is "+charge);
            }
            while (age !="q");








            }


}