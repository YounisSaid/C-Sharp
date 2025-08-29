using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_02
{
    //1. Given an array consists of numbers with size N and number of
    // queries, in each query you will be given an integer X, and you should
    // print how many numbers in array that is greater than X.
    // Ex:
    // Input
    // 3 3 //Size of array , number of queries
    // 11 5 3 //Array
    // 1 //Query1
    // 5 //Query2
    // 13 //Query 3
    // Output
    // 3 //11,5,3
    // 1 //11
    // 0
    public static class Q1
    {
        public static void GreaterThanX()
        {
            int Size = 0;
            int NumOfQuery = 0;
            GetInfo(ref Size,ref NumOfQuery);
            int[] arr = GetArray(Size,NumOfQuery);
            int X = GetX();
            int NumOfGreaterElements = GreaterElements(arr,X);
            Console.WriteLine($"Num of Greater Nums than {X} is {NumOfGreaterElements}");

        }
        private static void GetInfo(ref int Size,ref int NumOfQuery)
        {
            Console.WriteLine("Please Enter Size");
            Size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter NumOfQuery");
            NumOfQuery = Convert.ToInt32(Console.ReadLine());

        }
        private static int[] GetArray(int Size, int NumOfQuery)
        {
            int[] array = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine($"please Enter element number {i +1 }");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            return array;
        }
        private static int GetX()
        {
            Console.WriteLine("Please Enter Number You want to compare");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static int GreaterElements(int[] arr,int X)
        {
            int Counter = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                if (arr[i]>X) 
                    Counter++;
            }
            return Counter;
        }
    }
}
