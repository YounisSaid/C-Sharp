using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - .Write a program that prints an identity matrix using for loop, in other
            //  words takes a value n from the user and shows the identity table of size n *
            //  n.
            //Console.WriteLine("Please,Enter a Number");
            //int n = int.Parse(Console.ReadLine());
            //for(int i =0;i<n;i++)
            //{
            //    for(int j =0;j<n;j++)
            //    {
            //      Console.Write(i == j ? "1 " : "0 ");
            //    }
            //    Console.WriteLine();
            //}

            //2 - Write a program in C# Sharp to find the sum of all elements of the array.
            //int [] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //Console.WriteLine($"The Sum Of The Array is : {arr.Sum()}");
            //int Sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{

            //    Sum += arr[i];
            //}
            //Console.WriteLine($"The Sum Of The Array is : {Sum}");

            //3 - Write a program in C# Sharp to merge two arrays of the same size sorted in
            // ascending order.
            //int[] arr1 = { 5, 2, 1, 4, 3 };
            //int[] arr2 = { 6, 20, 8, 9, 10 };
            //int[] Merged = new int[10];
            //for (int i = 0; i < Merged.Length; i++)
            //{
            //    if (i < Merged.Length / 2)
            //        Merged[i] = arr1[i];
            //    else
            //        Merged[i] = arr2[i - (Merged.Length / 2)];
            //}
            //Array.Sort(Merged);
            //for (int i = 0; i < Merged.Length; i++)
            //{
            //    Console.WriteLine(Merged[i] + " ");
            //}

            //4 - Write a program in C# Sharp to find maximum and minimum element in an
            // array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };
            //int[] arr = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };
            //int min = arr[0];       
            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];  
            //    }
            //}
            //Console.WriteLine($"Min Number is : {min}");
            //Console.WriteLine($"Min Number is : {max}");

            //5 - Write a program in C# Sharp to find the second largest element in an
            // array.
            //int[] numbers = { 5, 3, 5, 10, 50, 22 };
            //int max = int.MinValue;
            //int secondMax = int.MinValue;

            //foreach (int num in numbers)
            //{
            //    if (num > max)
            //    {
            //        secondMax = max;
            //        max = num;
            //    }
            //    else if (num > secondMax && num < max)
            //    {
            //        secondMax = num;
            //    }
            //}
            //if (secondMax == int.MinValue)
            //    Console.WriteLine("There is no second largest element.");
            //else
            //    Console.WriteLine("Second largest element is: " + secondMax);

            //6 in this Example
            //7 0 0 0 0 5 6 7 5 0 7 5 3
            //write a program find the longest distance between Two equal cells.In this example.The distance
            //is measured by the number Of cells- for example, the distance between the first and the fourth
            //cell is 2(cell 2 and cell 3).
            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.
            //Note:
            //-Array values will be taken from the user
            //-If you have input like 1111111 then the distance is the number of  
            //Cells between the first and the last cell.
            //Console.WriteLine("Please Enter Values Separated by Space:");
            //string[] Sinput = Console.ReadLine().Split();
            //int[] ints = new int[Sinput.Length];

            //for (int i = 0; i < Sinput.Length; i++)
            //{
            //    ints[i] = int.Parse(Sinput[i]);
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    for (int j = ints.Length - 1; j > i; j--)
            //    {
            //        if (ints[j] == ints[i])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //            break; 
            //        }
            //    }
            //}
            //Console.WriteLine("Longest Distance Is: " + maxDistance);

            //7 - Given a list of space separated words, reverse the order of the words.
            //  Input: this is a test Output: test a is this
            //  Input: all your base Output: base your all
            //  Input: Word Output: Word
            //  Note :
            //  Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine
            //  Statement
            //Console.WriteLine("Please Enter Words Separated by Space:");
            //string[] input = Console.ReadLine().Split();
            //Array.Reverse(input);
            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.Write(input[i] + " ");
            //}
            ////////OR
            //for(int i = input.Length -1; i >=0; i--)
            //{
            //    Console.Write(input[i] + " ");
            //}

            //8 - Write a program to create two multidimensional arrays of same size. Accept
            // value from user and store them in first array. Now copy all the elements of
            // first array on second array and print second array.
            //Console.WriteLine("Enter Values For 3 * 3 Array");
            //int [,] arr = new int [3,3];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0;j< arr.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter Values of[{i}][{j}] : ");
            //        arr[i,j] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}
            //int[,] arr2 = new int [3,3];
            //Array.Copy(arr, arr2, arr.Length);
            //for(int i = 0;i < arr2.GetLength(0);i++)
            //{
            //    for(int j = 0; j<arr2.GetLength(1);j++)
            //    {
            //        Console.Write((arr2[i,j] + " "));
            //    }
            //    Console.WriteLine();
            //}

            //9 - Write a Program to Print One Dimensional Array in Reverse Order
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //arr.Reverse();
            //// OR
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}








        }
    }
}
