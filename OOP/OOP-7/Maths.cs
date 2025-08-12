using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{
    public static class Maths
    {
        private static int operationCount = 0;

        public static int Add(int a, int b)
        {
            operationCount++;
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            operationCount++;
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            operationCount++;
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            operationCount++;
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return 0;
            }
            return a / b;
        }

        public static double Power(double a, double b)
        {
            operationCount++;
            return Math.Pow(a, b);
        }

        public static double Average(double[] numbers)
        {
            operationCount++;
            if (numbers.Length == 0) return 0;
            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        public static void ShowOperationCount()
        {
            Console.WriteLine($"Total operations : {operationCount}");
        }
    }

}
