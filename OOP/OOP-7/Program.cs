using System.Collections.Generic;
using System.Reflection.Metadata;

namespace OOP_7
{
    internal class Program
    {
        //Define a class Maths that has six methods:
        //  1. Add – takes two parameters and returns their sum.
        //  2. Subtract – takes two parameters and returns their difference.
        //  3. Multiply – takes two parameters and returns their product.
        //  4. Divide – takes two parameters and returns their quotient(handle
        //  division by zero).
        //  5. Power – takes two parameters and returns the first number raised
        //  to the power of the second.
        //  6. Average – takes an array of numbers and returns their average.
        //  Additional Requirements:
        //   Modify the program so that you do not have to create an instance
        //  of the class to call any of the methods(make them static).
        //   Add a static field operationCount that keeps track of how many
        //  times any method is called.
        //   Add a static method ShowOperationCount() that prints how many
        //  total operations have been performed.
        //  In Main():
        //  1. Call each method with example values and print the results.
        //  2. Call ShowOperationCount() at the end to display how many
        //  operations were performed.
        static void Main(string[] args)
        {
            Console.WriteLine($"Add: {Maths.Add(10, 5)}");
            Console.WriteLine($"Subtract: {Maths.Subtract(10, 5)}");
            Console.WriteLine($"Multiply: {Maths.Multiply(10, 5)}");
            Console.WriteLine($"Divide: {Maths.Divide(10, 0)}");
            Console.WriteLine($"Power: {Maths.Power(2, 3)}");
            Console.WriteLine($"Average: {Maths.Average(new double[] { 10, 20, 30 })}");

            Maths.ShowOperationCount();
        }
    }
}
