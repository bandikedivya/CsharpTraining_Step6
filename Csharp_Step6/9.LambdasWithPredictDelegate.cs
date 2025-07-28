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


            Predicate<string> checkorder = (string ordername) =>
            {
                return true;
            };
            bool checkfoodorder = checkorder("Dosa");
            Console.WriteLine(checkfoodorder);



            Predicate<string> checkavailable = (string FoodName) =>
            {
                string[] fooditems = { "Rice", "Curry", "Dal", "Idly", "Vada", "Dosa" };
                for (int i = 0; i < fooditems.Length; i++)
                {
                    if (fooditems[i] == FoodName)
                    {
                        Console.WriteLine("Food Is Available");
                        Console.WriteLine($"Preparing Your Food: {FoodName}");
                        return true;
                    }
                }
                Console.WriteLine("Sorry!! The Item You are searching for is Not Available Right now!!");
                return false;
            };



            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Please Select From Menu");
            Console.WriteLine($"1.🍚Rice\n2.🍛Curry\n3.🍜Noodles\n4.🥯Vada\n6.🍲Soup");
            string Foodname = Console.ReadLine();
            bool IsAvailable = checkavailable(Foodname);
            if (IsAvailable)
            {

                Console.WriteLine($"Serving Food: {Foodname}");

            }
            else
            {
                string Isfoodavailable = $"Sorry!! Food is Not Available";

            }


            Console.WriteLine("Hope You Like The Service. Thank You!! Visit Again...");






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

            Console.WriteLine();
            Console.WriteLine("Please Enter Name to check in the list");
            string name = Console.ReadLine();
            bool checkname = Name(name);


            Predicate<string> checkroomavailability = (string roomtype) =>
            {
                List<string> roomtypes = new List<string> { "StudioRoom", "BalconyRoom", "OceanviewRoom" };
                for (int i = 0; i < roomtypes.Count; i++)
                {
                    if (roomtypes[i] == roomtype)
                    {
                        Console.WriteLine("Room is Available");
                        return true;
                    }
                }
                Console.WriteLine("Sorry!!, Room is Not Available");
                return false;
            };



            Console.WriteLine("Please Enter the Room Type to Check Availability");
            string roomnamecheck = Console.ReadLine();
            bool roomcheck = checkroomavailability(roomnamecheck);




            Predicate<string> checkroomavailability1 = (string roomtype) =>
            {
                Dictionary<int, string> FiveStarHotel = new Dictionary<int, string>
                {
                    {101, "Room 101" },
                    {102, "Room 102"},
                    {103, "Room 103" }
                };


                if (int.TryParse(roomtype, out int roomKey))
                {
                    if (FiveStarHotel.TryGetValue(roomKey, out string roomName))
                    {
                        //Console.WriteLine("Room is Available");
                        return true;
                    }

                }
                //Console.WriteLine("Sorry! Room is filled or key is invalid.");
                return false;
            };
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Please enter the room number to check availability:");
            string input = Console.ReadLine();

            bool isAvailable = checkroomavailability1(input);

            if (isAvailable)
            {
                Console.WriteLine("🎉 Room is available.");
                // Optional: int roomNum = Convert.ToInt32(isAvailable); // yields 1
            }
            else
            {
                Console.WriteLine("⛔ Room is not available or invalid input.");
                // Optional: int roomNum = Convert.ToInt32(isAvailable); // yields 0
            }


            //Console.WriteLine("Please Enter the Room Number to Check the Availability");
            //bool roomcheck1 = checkroomavailability(roomtype);
            //int roomnum = int.Parse(roomcheck1);

            //if (int.TryParse(roomtype), out int roomKey));
            //{
            //    if (FiveStarHotel.ContainsKey(roomKey))
            //    {
            //        Console.WriteLine("Room is Available");
            //    }
            //}



            //for (int i = 0; i < FiveStarHotel.Count; i++)
            //{
            //    if (FiveStarHotel.ContainsKey(i))
            //    {
            //        Console.WriteLine("Room You are Searching is Available");
            //        return true;
            //    }
            //}
            //Console.WriteLine("Sorry!! Room is Filled! Room is Not Available");
            //return false;














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


            Predicate<string> seatcheck = (string seattype) =>
            {
                Dictionary<int, string> Redbus = new Dictionary<int, string>
                {
                    {1, "Seater" },
                    {2, "Seater" },
                    {3, "Sleeper" },
                    {4, "Sleeper" }
                };
                if(int.TryParse(seattype, out int seatkey))
                {
                    if(Redbus.TryGetValue(seatkey, out string seatname)) 
                    { 
                        return true; 
                    }

                }
                return false;
            };

            Console.WriteLine("Please Enter the SeatNumber to check Availability");
            string input1 = Console.ReadLine();
            bool isAvailable1 = seatcheck(input1);
            if (isAvailable1)
            {
                Console.WriteLine("🎉💺 Seater/Sleeper is available");
            }
            else
            {
                Console.WriteLine("⛔ Seater/Sleeper is not Available");
            }

        }
    }
}
