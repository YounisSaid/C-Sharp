using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Explain the difference between passing (Value type parameters)
            //by value and by reference then write a suitable c# example.

            //// Passed by value
            //static void IncreaseNumByValue(int number)
            //{
            //    number += 10;
            //    Console.WriteLine("Inside Increase By Value: " + number); 
            //}

            //// Passed by ref
            //static void IncreaseNumByReference(ref int number)
            //{
            //    number += 10;
            //    Console.WriteLine("Inside Increase By Ref: " + number); 
            //}

            //int value = 5;

            //Console.WriteLine("Original value: " + value);

            //// Pass by value You take a copy of Value not The ref
            //IncreaseNumByValue(value);
            //Console.WriteLine("After Increase By Value: " + value); //  5
            //// Pass by ref You take the Ref not A copy
            //IncreaseNumByReference(ref value);
            //Console.WriteLine("After Increase By Ref: " + value); //  15

            // 2 - Explain the difference between passing(Reference type
            //parameters) by value and by reference then write a suitable c#
            //example.

            //static void ModifyByVal(int[] arr)
            //{
            //    Console.WriteLine("[Value] Before : " + arr.GetHashCode());
            //    arr = new int[] { 1, 2, 3 };
            //    Console.WriteLine("[Value] After : " + arr.GetHashCode());
            //}

            //static void ModifyByRef(ref int[] arr)
            //{
            //    Console.WriteLine("[Ref] Before : " + arr.GetHashCode());
            //    arr = new int[] { 4, 5, 6 };
            //    Console.WriteLine("[Ref] After : " + arr.GetHashCode());
            //}
            //int[] numbers = { 10, 20, 30,40,50 };

            //Console.WriteLine("Original hash code: " + numbers.GetHashCode());

            //ModifyByVal(numbers);
            //Console.WriteLine("After Modify By Value : " + numbers.GetHashCode());

            //ModifyByRef(ref numbers);
            //Console.WriteLine("After Modify By Reference : " + numbers.GetHashCode());

            //3- Write a c# Function that accept 4 parameters from user and
            //    //return result of summation and subtracting of two numbers

            //    static void Calculate(string[] input, out int sum, out int sub)
            //    {

            //        int[] numbers = new int[4];

            //        for (int i = 0; i < 4; i++)
            //        {
            //            numbers[i] = int.Parse(input[i]);
            //        }

            //        sum = numbers[0] + numbers[1];
            //        sub = numbers[2] - numbers[3];
            //    }

            //    Console.WriteLine("Enter 4 numbers separated by space:");
            //    string [] userInput = Console.ReadLine().Split();
            //    int Sum, Subtract;
            //    Calculate(userInput, out Sum, out  Subtract);

            //    Console.WriteLine("Sum = " + Sum);
            //    Console.WriteLine("Subtraction = " + Subtract);

            //4- Write a program in C# Sharp to create a function to calculate the sum of the
            //individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7
            //Console.WriteLine("Enter  numbers To sum Digits:");
            //string userInput = Console.ReadLine();
            //int Result = 0;
            //for (int i = 0; i < userInput.Length; i++)
            //{
            //    Result += (int)userInput[i] - '0';
            //}
            //Console.WriteLine($"Sum of Digits is : {Result}");

            //5 Create a function named "IsPrime", which receives an integer number
            //   and retuns true if it is prime, or false if it is not:
            //static bool IsPrime(int number)
            //{
            //    if (number <= 1)
            //        return false;

            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }

            //    return true;
            //}

            //6 - Create a function named MinMaxArray, to return the minimum and
            //  maximum values stored in an array, using reference parameters
            //static void MinMaxArray(ref int[] arr, out int min, out int max)
            //{
            //    min = arr.Min();   
            //    max = arr.Max();   
            //}
            //int[] numbers = { 10, 3, 25, 7, 1, 19 };

            //int minValue ; 
            //int maxValue;    

            //MinMaxArray(ref numbers, out minValue, out maxValue);

            //Console.WriteLine("Minimum value: " + minValue);
            //Console.WriteLine("Maximum value: " + maxValue);

            //7 - Create function to calculate the factorial of the number specified as
            //    parameter

            //int Factorial(int num)
            //{
            //    if (num < 0) return -1;
            //    if (num == 0) return 1;
            //    int result = 1;
            //    for (int i = 2; i <= num; i++)
            //    {
            //        result *= i;
            //    }
            //    return result;

            //}
            //Console.WriteLine("Please Enter A number : ");
            //int num = int.Parse(Console.ReadLine());
            //int NumFactorial = Factorial(num);
            //if (NumFactorial == -1) Console.WriteLine("Please Enter Valid Num");
            //else Console.WriteLine($"Factorial of num{num} is {NumFactorial}");

            //8- Create a function named "ChangeChar" to modify a letter in a certain
            //position(0 based) of a string, replacing it with a different letter
            //Console.Write("Enter the original string: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter the position : ");
            //int position = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the new character: ");
            //char newChar = Convert.ToChar(Console.ReadLine());

            //string result = ChangeChar(input, position, newChar);
            //Console.WriteLine(result);

            //string ChangeChar(string str, int pos, char newChar)
            //{
            //    return str.Substring(0, pos) + newChar + str.Substring(pos + 1);
            //}

        }
    }
}

