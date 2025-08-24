using System;

namespace SplitTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var EmployeeDetails = GetEmployeeDetails(1001);

            var Name = EmployeeDetails.Item1;
            var Salary = EmployeeDetails.Item2;
            var Gender = EmployeeDetails.Item3;
            var Department = EmployeeDetails.Item4;

            Console.WriteLine($"{Name} {Salary} {Gender} {Department}");
            Console.WriteLine($"Press any key to exit!");

            // Method 1: De-constructing the tuples
            (string name, double salary, string gender, string department) = GetEmployeeDetails(10001);
            // or
            var (name1, salary1, gender1, department1) = GetEmployeeDetails(1001);


            
            Console.ReadKey();
        }
        public static (string, double, string, string) GetEmployeeDetails(long EmployeeID)
        {
            string EmployeeName = "Nitin";
            double Salary = 2000;
            string Gender = "Male";
            string Department = "IT";
            return (EmployeeName, Salary, Gender, Department);
        }
    }
}
