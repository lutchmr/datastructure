using System;

namespace Declaring_Method
{
   public class Restaurant
    {
   
         string? restaurant_name;
         string? cuisine_type;
     //This is a default constructor
     //If you put nothing in it both restaurant_name and cuisine_type will be null
        public void describe_restaurant()
        {}
        //This Constructor instantiates an object and will set restaurant_name and cuisine_type 
        // with strings you provide
            public void describe_restaurant(string r_name,string c_type)
                {
                 restaurant_name=r_name;
                 cuisine_type=c_type;
                  Console.Write("\nThe name of the Restaurant is "+r_name +" and it makes "+c_type);  
                }
    
            public void open_restaurant()
            {
                Console.WriteLine("The Restaurant is Open!");

            }

            class Program
            {
            static void MainDemo(string[] args)
                {
                    // create object of class Program
                    Restaurant restaurant= new Restaurant();
                    restaurant.open_restaurant(); //calling open_restaurant method
                    restaurant.describe_restaurant("Spur","Steak"); // calling describe_restaurant method
                    
                   

                }
            }     
    }
}
 

