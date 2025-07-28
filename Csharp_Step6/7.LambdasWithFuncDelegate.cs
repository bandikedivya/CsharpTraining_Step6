using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaWithFuncDelegate
{
    // Syntax:
    // Func<T1,T2,T3,T4.........T16,TResult>

    // Func - takes up to 16 input parameters and always returns a value of type TResult. [Used for methods that return a value]

    class Program
    {
        static void Main()
        {
            // Lambda Expression with string parameter and string return type
            Func<string, string> StudName = (string Studname) =>
            {
                return $"Student Name is : {Studname}";
            };
            string name = StudName("Isabel");


            // Lambda Expression with string, int parameters and string return type

            Func<string, int, string> StudNameAge = (string Studname, int Age) =>
            {
                return $"Student Name:{Studname} and Age is: {Age}";
            };
            string namendage = StudNameAge("Isabel", 22);


            // Lambda Expression with sting parameter and int return type
            Func<string,int, int> StudNameRollNo = (string Studname, int age) =>
            {
                Console.WriteLine($"Student1 Name:{Studname} \t Age:  {age}");
                int rollno = 10023;
                return rollno;
            };
            
            int nameageroll = StudNameRollNo("Conrad", 25 );
            Console.WriteLine($"Stud RollNo1: {nameageroll}");


            // Lambda Expression with sting,int,int parameters and double return type
            Func<string, int, int, double> StudDetails = (string Name, int age, int rollno) =>
            {
                Console.WriteLine($"Student2 Name:{Name}\t Age: {age}\t RollNo: {rollno}");
                double phnno = 9876546589d;
                return phnno;
            };

            double details = StudDetails("Jermiad", 19, 10023);
            Console.WriteLine($"Phone Number: {details}");


            // Lambda Expression with sting,int,int, double parameters and float return type
            Func<string, int, int, double, float> StudDetails1 = (string Name, int age, int rollno, double phnno) =>
            {
                Console.WriteLine($"Student3 Name: 1.{Name} \t 2.Age: {age} \t 3.RollNo: {rollno} \t 4.PhoneNumber: {phnno}");
                float lapprice = 100000.54f;
                return lapprice;
            };

            double details1 = StudDetails1("Adam", 27, 10053, 9878794654d);
            Console.WriteLine($"Adam Purchased a Laptop and the cose is: {details1}");


            // Lambda Expression with no parameters and sting return type
            Func<string> LocationDetails = () =>
            {
                return "Location is Banglore";
            };

        }

    }
}
