using System;
using System.Collections.Generic;
using System.Collections.Specialized;
/*
============ Tuples ==============
Why do we need tuples?
Ans -> If you want to return more than one value from a method then you need to use tuples c#. It is common  thing to return multiple values from a method.
    Tuples in c# 7 provide a better machenicsem to return multiple values from a method.

What are the differencet ways to return more than one value from a method?
Ans -> 
a) Using Custom Data Type: you can return multiple value from the method by using a custom data type as the return type of the method. 
    but sometimes we don't need want to use classes and objects because that's just too much for the given purpose.

b) Using Ref and Out Variable: you can also return the more than one value from the method either by using the out and ref parameters.
c) Using dynamic keyword: you can retrun more tha one value from a method by using the dynamic keyword as the return type. The dynamic keyword was introducted in c# 4.




Explaines of Tuples Before c# 7?

Understanding the problems with the tuples before c# 7?

How do we use Tuples from c# 7?

Tuples in c# with named parameters?

Guidlines to use Tuples?

*/
namespace C__7_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var values1 = new List<double>() { 10, 20, 30, 40, 50 };
            var values2 = new List<double>() { 10, 20, 30, 40, 50, 60 };
            var values3 = new List<double>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 ,100};
            // store the result of calculate method in a variable of tuple type 
            Tuple<int, double> result  = Calculate1(values1);
            var results2 = Calculate2(values2);
            var (countResult, sumResult) = Calulate3(values3);
            // access the first value using item1 and second value using item2 properties
            Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}");
            Console.WriteLine($"There are {results2.Item1} values and their sum is {results2.Item2}");
            Console.WriteLine($"There are {countResult} values and their sum is {sumResult}");

            Console.ReadKey();

        }
        public static Tuple<int, double> Calculate1(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach(var value in values)
            {
                count++;
                sum += value;
            }
            Tuple<int, double> t = Tuple.Create(count, sum);

            return t;
        }

        public static (int , double ) Calculate2(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0; 
            foreach(var value in values)
            {
                count++;
                sum += value;
            }
            return (count, sum);
        }

        private static (int count, double sum) Calulate3(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach(var value in values)
            {
                count++;
                sum += value;
            }
            return (count, sum);
        }

        // Splitting the tuples in c# 7
        
    }
}
