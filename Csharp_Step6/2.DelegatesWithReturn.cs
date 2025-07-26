using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegatesWithReturn.MallPlan;

namespace DelegatesWithReturn
{
    public class MallPlan
    {

        // Delegate returns a string (for construction message)
        public delegate string ArchitectrueMall(string custname, string mallname);


        // Delegate returns a bool (checks a store in mall)
        public delegate bool CheckStoreAvalability(string checkstore);


        // Delegate returns a void (adds a new store in mall)
        public delegate void AddNewStalls(string storename);


        // Delegate returns a void (to give mall construction success message)
        public delegate string MallConstSuccess(string mallname);



        public string Mall(string custname, string mallname)
        {
            return $"{custname} want to Construct a Mall Named {mallname}, has planning to have 20 shops and with Huge Car and Bike Parking Area ";
        }

        public bool CheckAvailabilty(string checkstore)
        {
            string[] mallcolelction = { "Stores", "Restuarant", "Theater", "Play Zone" };
            foreach (string mall in mallcolelction)
            {
                if (mall.Equals(checkstore,StringComparison.OrdinalIgnoreCase))  //Equal[prebuild method] accepts few parameters, but contains[prebuild method] accepts only one parameter.
                {
                    return true;
                }
            }
            return false;
        }


        public void AddStore(string storename)
        {
            Console.WriteLine($"Adding {storename} Stall to the Plan");
        }

        public string MallContructSuccess(string mallname)
        {
            return $"{mallname} Constructed Successfully, Having 20 shops and with a Huge Car and Bike Parking Area. And Added Stalls as well.";
        }


    }

    class MallConstruction
    {
        static void Main()
        {
            MallPlan mallPlan = new MallPlan();  //As the class is non-static, creating instance for Houseplan class



            //Registering methods with delegate

            ArchitectrueMall architectdelegate = mallPlan.Mall;
          

            CheckStoreAvalability checkstoredelegate = mallPlan.CheckAvailabilty;

            AddNewStalls addnewstalldelegate = mallPlan.AddStore;

            MallConstSuccess mallConstSuccessdelegate = mallPlan.MallContructSuccess;

            string custname = "Laural";
            string mallname = "Pheonix Marketcity Mall";

            string customer = architectdelegate(custname, mallname);
            Console.WriteLine(customer);

            // string checkstore = "Restuarant";
            //string checkstore = "Zudio";
            Console.WriteLine();
            Console.WriteLine("Please Enter The Store Name to Check Store is Available in Mall:");
            string checkstore = Console.ReadLine();

            

            bool IsAvailable = checkstoredelegate(checkstore);

         
            if(IsAvailable)
            {
                Console.WriteLine();
                Console.WriteLine("Store is Available in Mall");
            }
            else
            {
                Console.WriteLine("Sorry!! The Store You are Looking For is Not Avaliable in Mall");
            }



            Console.WriteLine();

            Console.WriteLine("========================Adding New Store=======================");
            Console.WriteLine();
            Console.WriteLine("Please Enter The Store Name to Add in the Mall:");
            string storename = Console.ReadLine();

            addnewstalldelegate(storename);

            Console.WriteLine("Please Enter The Store Name to Check Store is Available in Mall:");
            string checkstore1 = Console.ReadLine();


            if (IsAvailable)
            {
                Console.WriteLine();
                Console.WriteLine("Store is Available in Mall");
            }
            else if (storename.Contains("KFC")) //Equal[prebuild method] accepts few parameters, but contains[prebuild method] accepts only one parameter.
            {
                Console.WriteLine();
                Console.WriteLine("KFC Food Stall is Now Available in Mall");
            }
            else if (storename.Contains("Zudio")) //Equal[prebuild method] accepts few parameters, but contains[prebuild method] accepts only one parameter.
            {
                Console.WriteLine();
                Console.WriteLine("Zudio is Now Available in Mall");
            }
            else
            {
                Console.WriteLine("Sorry!, The Store You are Looking For is Not Avaliable in Mall");
            }

        }
    }
}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DelegatesWithReturns
//{

//    // Delegate that returns a string (for order preparation messages)
//    public delegate string OrderPreparation(string order);

//    // Delegate that returns void (for order confirmation)
//    public delegate void OrderConfirmation(string order);

//    // Delegate that returns bool (to check availability)
//    public delegate bool OrderAvailability(string order);

//    //Script imp 
//    public class Restaurant
//    {

//        /// <summary>
//        /// // Returns preparation message as a string
//        /// </summary>
//        /// <param name="order"></param>
//        /// <returns></returns>
//        public string PrepareMainCourse(string order)
//        {
//            return $"Main Course Chef is preparing: {order}";
//        }

//        /// <summary>
//        /// Confirms the order (void delegate)
//        /// </summary>
//        /// <param name="order"></param>
//        public void ConfirmOrder(string order)
//        {
//            Console.WriteLine($"Order confirmed: {order}");
//        }

//        /// <summary>
//        /// // Checks if the order is available using a foreach loop
//        /// </summary>
//        /// <param name="order"></param>
//        /// <returns></returns>
//        public bool CheckOrderAvailability(string order)
//        {
//            string[] availableItems = { "Pasta", "Ice Cream", "Mojito" }; //Restaturemet having 3 itesm
//            foreach (string item in availableItems)
//            {
//                if (item.Equals(order))
//                {
//                    return true;
//                }
//            }
//            return false;
//        }


//    }

//    class ExecuteRestaurant
//    {
//        static void Main(string[] args)
//        {

//            Restaurant restaurant = new Restaurant();  // Create a Restaurant object

//            //Registration method along with delegate....
//            OrderPreparation preparationDelegate = restaurant.PrepareMainCourse;
//            OrderConfirmation confirmationDelegate = restaurant.ConfirmOrder;
//            OrderAvailability availabilityDelegate = restaurant.CheckOrderAvailability;

//            // Customer places an order for "Pasta"
//            string order = "Pasta";
//            Console.WriteLine("Checking order availability...");

//            //Main Goal - Lets Delegate handle  -> Delegate speaks the methods
//            bool isAvailable = availabilityDelegate(order);
//            if (isAvailable)
//            {
//                string status = preparationDelegate(order);
//                Console.WriteLine(status);

//                confirmationDelegate(order);
//            }
//            else
//            {
//                Console.WriteLine($"Sorry, {order} is not available.");
//            }


//            Console.WriteLine("--------------------------------------------------");

//            string order1 = "Chicken Biryani";
//            Console.WriteLine("\nCustomer places an order for Chicken Biryani...");
//            bool isAvailable1 = availabilityDelegate(order1);
//            if (isAvailable1)
//            {
//                string status = preparationDelegate(order1);
//                Console.WriteLine(status);

//                confirmationDelegate(order1);
//            }
//            else
//            {
//                Console.WriteLine($"Sorry, {order1} is not available.");
//            }


//            //Order -> check order ---> Prepare ---> confirmation


//        }
//    }
//}


//smart work if you know everything .... Lazy