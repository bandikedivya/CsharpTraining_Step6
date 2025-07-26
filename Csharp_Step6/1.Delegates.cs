using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Delegate are pointers to methods, allowing methods to be passed as parameters.
// This is Void Delegate Example
// Delegate --- Type -Safety
// Calling method signature must be same with the delegate signature [return type, parameters..]
//  Object creation [instance] is not required fir delegates.


namespace ArchitectureDelegateExample
{
    // Delegate

    public delegate void Architeture(string customer);
    public class HousePlannning
    {
        
        public void House1(string customer1name)
        {
            Console.WriteLine($"{customer1name} want to Construct a House, has planning to build a 3BHK with Car Parking and Bike Parking.");
        }


        public void House2(string customer2name)
        {
            Console.WriteLine($"{customer2name} want to Renovate a house, has planning to renovate a 1bhk to Duplex House with 4 BHK with Swimming Pool.");
        }

        public void Mall(string customer3name)
        {
            Console.WriteLine($"{customer3name} want to Construct a Mall, has planning to have 20 shops and with Huge Car parking and Bike Area ");
        }

    }


    class HouseConstruction //Execution Planning
    {
        static void Main()
        {
            HousePlannning housePlannning = new HousePlannning();  //As the HousePlanning is non-static Class


            // Here "architect" acts as the delegate that routes houses planning 
            Architeture architect;  //Creation of delegate doesnot require object(instance) 


            Console.WriteLine("********************House1 Construction*********************");
            
            architect = housePlannning.House1;


            architect("Laural");  // Calling the delegate
                                  // Here the delegate call backs the House1 method and passes the parameter.
                                  // The House1 method is then executes
                                  // Here architect is a delegate that points to the House1 method.


            Console.WriteLine("********************House2 Construction*********************");

            architect = housePlannning.House2;

            architect("Chris");   // Calling the delegate
                                  // Here the delegate call backs the House2 method and passes the parameter.
                                  // The House2 method is then executes
                                  // Here architect is a delegate that points to the House2 method.



            Console.WriteLine("********************Mall Construction*********************");

            architect = housePlannning.Mall;

            architect("Georgia1");  // Calling the delegate
                                                   // Here the delegate call backs the Mall method and passes the parameter.
                                                   // The Mall method is then executes
                                                   // Here architect is a delegate that points to the Mall method.


        }
    }
}



//using AnonymousMethods;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RestaurantDelegate_Void_Example
//{

//    public delegate void KitchenSection(string order);

//    public class Restaurant
//    {
//        public void MainCourseSection(string order)
//        {
//            Console.WriteLine($"Main Course Chef is preparing: {order}"); // Main course section
//        }

//        public void DessertSection(string order)
//        {
//            Console.WriteLine($"Dessert Chef is preparing: {order}"); // Dessert section
//        }

//        public void DrinksSection(string order)
//        {
//            Console.WriteLine($"Drinks Section is preparing: {order}");// Drinks section
//        }

//    }


//}

//    class ExecuteRestaurant
//    {
//        static void Main(string[] args)
//        {
//            Restaurant restaurant = new Restaurant();
//            //restaurant.MainCourseSection("Pasta");


//            // "Waiter" acts as the delegate that routes orders
//            KitchenSection waiter;// Create delegate object not assigned to any method

//            Console.WriteLine("Customer places order for Pasta...");
//            waiter = restaurant.MainCourseSection;


//            //RestaurantTask taskOrder = delegate (string orderName)
//            //{
//            //    Console.WriteLine("Waiter: Taking order for " + orderName);
//            //};



//            waiter("Pasta"); // Call the delegate
//                             // Here the delegate calls the MainCourseSection method and passes the order as parameter
//                             // The MainCourseSection method is then executed
//                             // Here waiter is a delegate that points to the MainCourseSection method

//            Console.WriteLine("\nCustomer places order for Ice Cream...");
//            waiter = restaurant.DessertSection;
//            waiter("IceCream");
//            // Call the delegate
//            // Here the delegate calls the DessertSection method and passes the order as parameter
//            // The DessertSection method is then executed
//            // Here waiter is a delegate that points to the DessertSection method


//            Console.WriteLine("\nCustomer places order for a Mojito...");
//            waiter = restaurant.DrinksSection;  // Route to drinks section
//            waiter("Mojito");   // Call the delegate
//                                // Here the delegate calls the DrinksSection method and passes the order as parameter
//                                // The DrinksSection method is then executed
//                                // Here waiter is a delegate that points to the DrinksSection method





//        }
//    }

//}