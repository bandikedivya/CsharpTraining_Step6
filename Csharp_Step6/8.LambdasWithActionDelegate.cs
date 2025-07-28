using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdWithActionDelegate
{
    class Program
    {

        // Action Syntax:
        // Action<T1,T2....T16>  : No Return Value.
        // Action -- delegate takes one or more input parameters of type T and does not return value [used methods with no return value.]
        static void Main()
        {
            // Using Action delegate in method with one parameter.
            Action<string> EmployeeName1 = (string empname) =>
            {
                Console.WriteLine($"Employee Name: {empname}");
            };
            EmployeeName1("Marcus");



            // Using Action delegate in method with string,int parameters.

            Action<string, int> EmployeeNameAge = (string name, int age) =>
            {
                Console.WriteLine($"Employee Name: {name} and Age: {age}");
            };
            EmployeeNameAge("Conrad", 25);




            // Using Action delegate in method with string,int, string parameters.

            Action<string, int, string> Employeedetails = (string name, int age, string company) =>
            {
                Console.WriteLine($"Employee Name: {name} and Age: {age} and working in Company Name: {company}");
            };
            Employeedetails("Jermiah", 20, "InfoTech");



            // Using Action delegate in method with string,int, string parameters.

            Action<string, int, string, double> Employee1details = (string name, int age, string company, double salary) =>
            {
                Console.WriteLine($"Employee Name: {name} and Age: {age} and working in Company Name: {company}, and salary is: {salary}");
            };
            Employee1details("Isabel", 22, "TCS", 25000);

            






















        }
    }
}
