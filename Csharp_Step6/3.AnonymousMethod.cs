using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AnonymousMethods
{
    class Program
    {

        //Anonymous func will not have  name and is defined using delegate keyword.


        public delegate void RestuarantProcess(string custName, string OrderName);

        public delegate void RestVisit(string message);
      
        static void Main(string[] args)
        {
            //Here anonymous func is assigned to a variable, where RestuarantProcess is the degelate.

            RestuarantProcess takeorderfood = delegate (string custName, string orderName)
            {
                Console.WriteLine($"Taking Food Order From {custName} \n Customer Ordered: {orderName}");

            };


            RestuarantProcess prepareorderfood = delegate (string custName, string orderName)
            {
                Console.WriteLine($"Master is Preparing {custName}'s Order");
            };

            RestuarantProcess servingFood = delegate (string custName, string Ordername)
            {
                Console.WriteLine($"Server Serving {Ordername} to the {custName}");
            };

            RestVisit visitmgs = delegate (string messgae)
            {
                Console.WriteLine(messgae);
            };




            //Calling Anonymous Methods
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("*****************Welcome To Empire Restuarant****************");
            //string cust = "Swapna Narupalle";
            Console.WriteLine("Please Enter Your Name:");
            string cust = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("******🍽️🍴 Menu *******");
            Console.WriteLine($"1.🥦 Veg Biriyani  \n" + "2. 🍗 Non Veg Biriyani \n" + "3. 🍛🥦 Veg Curry \n" + "4. 🍛🍗 Non Veg Curry \n");
            string OrderName = Console.ReadLine();
            //string OrderName = "Biriyani";
            Console.WriteLine();

            takeorderfood(cust, OrderName);
            Console.WriteLine();

            prepareorderfood(cust, OrderName);
            Console.WriteLine();
            servingFood(cust, OrderName);
            Console.WriteLine();
            visitmgs("Hope You Like The Service. Thank You!! Visit Again...");






        }

    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AnonymousMethods
//{

//    delegate void RestaurantTask(string taskDetail);
//    //Method doesnot have the name is  Anonymous
//    //Use delegages to develope the Anonymous methods
//    class Program
//    {
//        static void Main()
//        {

//            // Anonymous method for taking orders
//            RestaurantTask takeOrder = delegate (string orderName)
//            {
//                Console.WriteLine("Waiter: Taking order for " + orderName);
//            };


//            // Anonymous method for preparing food
//            RestaurantTask prepareFood = delegate (string orderName)
//            {
//                Console.WriteLine("Kitchen: Preparing " + orderName);
//            };


//            // Anonymous method for serving food
//            RestaurantTask serveFood = delegate (string orderName)
//            {
//                Console.WriteLine("Waiter: Serving " + orderName);
//            };



//            string order = "Pista";
//            takeOrder(order);
//            prepareFood(order);
//            serveFood(order);



//        }
//    }
//}
