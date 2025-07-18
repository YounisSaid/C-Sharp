using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Reflection.Metadata;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        //class Point
        //{
        //    public int X { get; set; }
        //    public int Y { get; set; }
        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //}

        static void Main(string[] args)
        {
            //1.Write a program that takes a number from the user then print yes if that
            //number can be divided by 3 and 4 otherwise print no.
            //Example(1)
            //Input: 12
            //Output: Yes
            //Example(2)
            //Input: 9
            //Output: No
            //        }
            //Console.WriteLine("Enter The number to check ?");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Number % 3 == 0 && Number % 4 == 0 ? "Yes" : "No");

            // 2 - Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.
            //Example(1)
            //Input: -5
            //Output: negative
            //Example(2)
            //Input: 10
            //Output: positive
            //Console.WriteLine("Enter The number to check ?");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Number == 0 ? "Zero":Number > 0 ? "Postive" : "Negative");

            //3 - Write a program that takes 3 integers from the user then prints the max
            //element and the min element.
            //Example(1)
            //Input: 7,8,5
            //Output:
            //            max element = 8
            //min element = 5
            //Example(2)
            //Input: 3 6 9
            //Outputs:
            //            Max element = 9
            //Min element = 3
            //int[] arr = new int[3]; 
            //Console.Write("Please Enter Num 1 : ");
            // arr[0] = int.Parse(Console.ReadLine());
            //Console.Write("Please Enter Num 2 : ");
            // arr[1] = int.Parse(Console.ReadLine());
            //Console.Write("Please Enter Num 3 : ");
            // arr[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Max Num is " +arr.Max());

            //4 - Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.
            //Console.WriteLine("Enter The number to check ?");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Number % 2 == 0 ? "EVEN" : "ODD");

            //5 - Write a program that takes character from the user then if it is a vowel
            // chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            // Example(1)
            // Input: O           
            // Output: vowel
            // Example(2)
            // Input: b
            // Output: Consonant
            //Console.Write("Please Enter Char : ");
            //char input = Convert.ToChar(Console.ReadLine().ToLower());
            //Console.WriteLine("aeiou".Contains(input) ? "Vowel" : "consonant");

            //6 - Write a program that allows the user to insert an integer then print all
            // numbers between 1 to that number.
            // Example
            // Input: 5
            //Console.Write("Enter The number : ");
            //int n = int.Parse(Console.ReadLine());
            //for(int i =1;i<=n;i++)
            //{
            //    Console.Write(i + " ");
            //}

            //7 - Write a program that allows the user to insert an integer then
            // print a multiplication table up to 12.
            // Example
            // Input: 5
            // Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            //Console.Write("Enter The number : ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write( n*i + " ");
            //}

            //8 - Write a program that allows to user to insert number then print all even
            // numbers between 1 to this number
            // Example:
            // Input: 15
            // Output: 2 4 6 8 10 12 14
            //Console.Write("Enter The number : ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 1) continue;
            //    Console.Write(i + " ");
            //}

            //9 - Write a program that takes two integers then prints the power.
            // Example:
            //         Input: 4 3
            // Output: 64
            // Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64
            //Console.Write("Enter The number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("\nEnter The Power : ");
            //int Power = int.Parse(Console.ReadLine());
            //int Result =1;
            ////Console.WriteLine(Math.Pow(num, Power)); //or We can
            //for(int i=1;i<= Power; i++)
            //{
            //    Result *= num ;
            //}
            //Console.WriteLine(Result);

            //10 - Write a program to enter marks of five subjects and calculate total,
            // average and percentage.
            // Example
            // Input: -Enter Marks of five subjects: 95 76 58 90 89
            // Output: Total marks = 408
            // Average Marks = 81
            // Percentage = 81
            //Console.Write("Enter Five numbers with space between evrey number : ");
            //string[] inputs = Console.ReadLine().Split();

            //int a = int.Parse(inputs[0]);
            //int b = int.Parse(inputs[1]);
            //int c = int.Parse(inputs[2]);
            //int d = int.Parse(inputs[3]);
            //int e = int.Parse(inputs[4]);
            //int sum = a + b + c + d + e;
            //int avg = sum / 5;
            //Console.WriteLine("Sum : " + sum);
            //Console.WriteLine("Avg : " + avg);
            //Console.WriteLine("Perc : " + avg + "%");

            //11 - Write a program to input the month number and print the number of days in
            // that month.
            // Example
            // Input: Month Number: 1
            // Output: Days in Month: 31

            // the Question is misleading Cause feb depends on the year if it is leap or not we can solve this in two ways
            //Console.Write("Enter month number : ");
            //int month = int.Parse(Console.ReadLine());
            //int year = DateTime.Now.Year; 
            //int days = DateTime.DaysInMonth(year, month);
            //Console.WriteLine($"Number of days in month {month} of year {year} is  {days}");
            ////////////////////OR/////////////
            //Console.Write("Enter month number : ");
            //int month = int.Parse(Console.ReadLine());
            //int days = 0;
            //if (month >= 1 && month <= 12)
            //{
            //    if (month == 2)
            //    {
            //        Console.WriteLine($"Number of days in month {month} is 28 or 29 depending on leap year.");
            //    }
            //    else if (month == 4 || month == 6 || month == 9 || month == 11)
            //    {
            //        days = 30;
            //        Console.WriteLine($"Number of days in month {month} is {days}");
            //    }
            //    else
            //    {
            //        days = 31;
            //        Console.WriteLine($"Number of days in month {month} is {days}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Undefined Month");
            //}

            //12 - Write a program to create a Simple Calculator.
            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = Convert.ToChar(Console.ReadLine()); 
            //Console.WriteLine();
            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());
            //double result;
            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //        break;

            //    case '/':
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Error: Cannot divide by zero.");
            //        }
            //        else
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        break;
            //}

            //13 - Write a program to allow the user to enter a string and print the REVERSE
            // of it.
            //Console.Write("Please Enter String to Reverse : ");
            //string input = Console.ReadLine();
            //int n = input.Length;
            //string Result = "";
            //for(int i =n-1;i>=0;i--)
            //{
            //    Result += input[i];
            //}
            //Console.WriteLine(Result);

            //14 - Write a program to allow the user to enter int and print the REVERSED of
            //it.
            //Console.Write("Please Enter Num to Reverse : ");
            //string input = Console.ReadLine();
            //int n = input.Length;
            //string Result = "";
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Result += input[i];
            //}
            //Console.WriteLine(Result);

            //15 - Write a program in C# Sharp to find prime numbers within a range of
            // numbers.
            // Test Data :
            // Input starting number of range: 1
            // Input ending number of range: 50            
            // Expected Output :
            // The prime number between 1 and 50 are:
            //2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            //Console.Write("Enter  number : ");
            //int Num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The prime numbers between 1 and {Num} are:");
            //for (int i = 2; i <= Num; i++) 
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //bool IsPrime(int n)
            //{
            //    if (n < 2) return false;

            //    for (int i = 2; i <= Math.Sqrt(n); i++)
            //    {
            //        if (n % i == 0)
            //            return false;
            //    }

            //    return true;
            //}


            //16 - Create a program that asks the user to input three points(x1, y1), (x2,
            //   y2), and(x3, y3), and determines whether these points lie on a single
            //   straight line.
            //Console.Write("Enter Two numbers with space between evrey number (Point 1) : ");
            //string[] inputs = Console.ReadLine().Split();
            //Point P1 = new Point(int.Parse(inputs[0]), int.Parse(inputs[1]));

            //Console.Write("Enter Two numbers with space between evrey number (Point 2) : ");
            // inputs = Console.ReadLine().Split();
            //Point P2 = new Point(int.Parse(inputs[0]), int.Parse(inputs[1]));

            //Console.Write("Enter Two numbers with space between evrey number (Point 3) : ");
            //inputs = Console.ReadLine().Split();
            //Point P3 = new Point(int.Parse(inputs[0]), int.Parse(inputs[1]));

            //if((P2.X -P1.X)*(P3.Y-P2.Y)== (P2.Y - P1.Y)*(P3.X - P2.X))
            //{
            //    Console.WriteLine("these points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("these points are not on a single straight line.");

            //}

            //17 - Within a company, the efficiency of workers is evaluated based on the
            //     duration required to complete a specific task.A worker's efficiency level is
            //     determined as follows:
            //     -If the worker completes the job within 2 to 3 hours, they are considered
            //     highly efficient.
            //     - If the worker takes 3 to 4 hours, they are instructed to increase their
            //     speed.
            //     - If the worker takes 4 to 5 hours, they are provided with training to
            //     enhance their speed.
            //     - If the worker takes more than 5 hours, they are required to leave the
            //     company.
            //     To calculate the efficiency of a worker, the time taken for the task is
            //     obtained via user input from the keyboard.
            //Console.Write("Please Enter Num Of Hours To Finish The Task : ");
            //double Choice = double.Parse(Console.ReadLine());
            //string Message;
            //Message = Choice switch
            //{
            //    >= 2 and <= 3 => "Highly efficient",
            //    > 3 and <= 4 => "Increase your speed",
            //    > 4 and <= 5 => "Training required to enhance speed",
            //    > 5 => "Leave the company",
            //    _ => "Invalid input"
            //};
            //Console.WriteLine(Message);












        }
    }
}
