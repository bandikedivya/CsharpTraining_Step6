using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace AnonymousMethodsWithReturn
{
    //Anonymous Method will not have  name and is defined using delegate keyword.

    //Anonymous Method with return.
    class Program
    {

        public delegate bool Checkfood(string OrderName);

        public delegate void Takeorderfood(string custName, string OrderName);

        public delegate string Prepareorderfood(string custName, string OrderName);
       
        public delegate int Quantity(string custName, string OrderName);

        public delegate double CustomerBill(string custName, string OrderName);

        public delegate void RestVisit(string message);


        static void Main(string[] args)
        {
            //Here anonymous func is assigned to a local variable, where RestuarantProcess is the degelate.

            //bool return type
            Checkfood checkfood = delegate (string orderName)
            {
                string[] fooditems = { "Veg Biriyani", "Non Veg Biriyani", "Veg Curry", "Non Veg Curry" };
                foreach (var item in fooditems)
                {
                    if (item.Equals(orderName))
                    {
                        return true;
                    }
                }
                return false;
            };

            //void method
            Takeorderfood takeorderfood = delegate (string custName, string orderName)
            {
                Console.WriteLine($"Taking Food Order From {custName} \nCustomer Ordered: {orderName}");

            };


            //string return type method
            Prepareorderfood prepareorderfood = delegate (string custName, string orderName)
            {
                return $"Master is Preparing {custName}'s Order";
            };


            //int method type
            Quantity foodquantity = delegate (string custName, string Ordername) 
            {
                int quantity = 2;
                return quantity;
            };


            CustomerBill custbill = delegate (string custName, string orderName)
            {
                double price = 1500;
                return price;
            };


            //void method type
            RestVisit visitmgs = delegate (string messgae)
            {
                Console.WriteLine(messgae);
            };



            //Calling Lambda Methods

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("****************** Welcome To Empire Restuarant *****************");
            //string cust = "Swapna Narupalle";
            Console.WriteLine("Please Enter Your Name:");
            string cust = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("***********🍽️🍴 Menu **********");
            Console.WriteLine($"1.🥦 Veg Biriyani  \n" + "2. 🍗 Non Veg Biriyani \n" + "3. 🍛🥦 Veg Curry \n" + "4. 🍛🍗 Non Veg Curry \n");
            string OrderName = Console.ReadLine();
            //string OrderName = "Biriyani";
            Console.WriteLine();

            //string Isfoodavailable = $"Sorry!! Food is Not Available";
            //bool Isfoodavailable1 = checkfood("Dosa");
            //Console.WriteLine(Isfoodavailable);
            bool IsAvailable = checkfood(OrderName);

            if (IsAvailable)
            {
                takeorderfood(cust, OrderName);
                Console.WriteLine();

                prepareorderfood(cust, OrderName);
                Console.WriteLine();

                int custquantity = foodquantity(cust, OrderName);
                Console.WriteLine($"The {cust} ordered {OrderName} and Total Quantity: {custquantity}");

                double totalbillprice = custbill(cust, OrderName);
                Console.WriteLine($"The {cust} Ordered {OrderName} and Total Bill of {cust} is: {totalbillprice}");
            }
            else
            {
                string Isfoodavailable = $"Sorry!! Food is Not Available";
                Console.WriteLine(Isfoodavailable);
            }

            Console.WriteLine();
            visitmgs("Hope You Like The Service. Thank You!! Visit Again...");



        }
    }
}



//using AnonymousMethods;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AnonymousMethodsWithReturntypes
//{


//    //AnonymousMethodsWithReturntypes by using the delegates
//    //AnonymousMethods       To    LambdaExpressions(Arrow Expressin) for better method signature

//    delegate void TakeOrderTask(string taskDetail);
//    delegate string PrepartionFoodTask(string taskDetail);
//    delegate bool ServeFoodTask(string taskDetail);


//    //Keep in mind Block is same
//    class Program
//    {
//        static void Main()
//        {
//            // Anonymous method for taking orders
//            //TakeOrderTask takeOrder = delegate (string orderName)
//            //{
//            //    Console.WriteLine("Waiter: Taking order for " + orderName);
//            //};

//            TakeOrderTask takeOrder = (string orderName) =>
//            {
//                Console.WriteLine("Waiter: Taking order for " + orderName);
//            };
//            takeOrder("Pista");



//            //PrepartionFoodTask prepareFood = delegate (string orderName)
//            //{
//            //    return $"{orderName} Prepare food Completed";
//            //};
//            PrepartionFoodTask prepareFood = (string orderName) =>
//            {
//                return $"{orderName} Prepare food Completed";
//            };
//            string status = prepareFood("Pista");

//            //ServeFoodTask serveFoodDel = delegate (string orderName)
//            //{
//            //    return false;
//            //};

//            ServeFoodTask serveFoodDel = (string orderName) =>
//            {
//                return false;
//            };
//            bool IsCompleted = serveFoodDel("Dosa");
//            Console.WriteLine(IsCompleted);
//        }
//    }
//}