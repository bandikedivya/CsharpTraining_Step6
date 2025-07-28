using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdWithPredictDelegate
{
    class Program
    {

        // Predict Syntax: 
        // Predict<T>
        // Predict delegate: Takes one input parameter of tyoe T and returns a boolean value.
        static void Main()
        {


            //Predicate<string> checkorder = (string ordername) =>
            //{
            //    return true;
            //};
            //bool checkfoodorder = checkorder("Dosa");
            //Console.WriteLine(checkfoodorder);



            //Predicate<string> checkavailable = (string FoodName) =>
            //{
            //    string[] fooditems = { "Rice", "Curry", "Dal", "Idly", "Vada", "Dosa" };
            //    for (int i = 0; i < fooditems.Length; i++)
            //    {
            //        if (fooditems[i] == FoodName)
            //        {
            //            Console.WriteLine("Food Is Available");
            //            Console.WriteLine($"Preparing Your Food: {FoodName}");
            //    return true;
            //        }
            //    }
            //    Console.WriteLine("Sorry!! The Item You are searching for is Not Available Right now!!");
            //    return false;
            //};



            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine($"Please Select From Menu");
            //Console.WriteLine($"1.🍚Rice\n2.🍛Curry\n3.🍜Noodles\n4.🥯Vada\n6.🍲Soup");
            //string Foodname  = Console.ReadLine();
            //bool IsAvailable = checkavailable(Foodname);
            //if (IsAvailable)
            //{

            //    Console.WriteLine($"Serving Food: {Foodname}");

            //}
            //else
            //{
            //    string Isfoodavailable = $"Sorry!! Food is Not Available";

            //}


            //Console.WriteLine("Hope You Like The Service. Thank You!! Visit Again...");










            //Check name exists in the list


            Predicate<string> Name = (string empname) =>
            {
                string[] listname = { "Adam", "Steven", "Laural", "Taylor" };

                for (int i = 0; i < listname.Length; i++)
                {
                    if (listname[i] == empname)
                    {
                        Console.WriteLine("Name exists in the list");
                        return true;
                    }
                }
                Console.WriteLine("Sorry!! Name does not exists in the list");
                return false;
            };
            //bool name = Name("Taylor");
            //Console.WriteLine(name);


            Console.WriteLine("Please Enter Name to check in the list");
            string name = Console.ReadLine();
            bool checkname = Name(name);
           

            //bool name = Console.ReadLine() != null;

            //Predicate<string> isStaffAvailablePredicate = (string staffName) =>
            //{
            //    string[] availableStaff = { "John", "Doe", "Smith" };
            //    for (int i = 0; i < availableStaff.Length; i++)
            //    {
            //        if (availableStaff[i] == staffName)
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //};
            //bool isAvailable = isStaffAvailablePredicate("John");
            //Console.WriteLine(isAvailable);
        }
    }
}
