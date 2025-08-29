using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_02
{
    //2. Given a number N and an array of N numbers.Determine if it's
    // palindrome or not.
    // Ex:
    // Input:
    // 5
    // 1 3 2 3 1
    // Output:
    // YES
    public static class Q2
    {
        public static bool Ispalindrome()
        {
            int[] arr = GetData();
            for (int i = 0;i<arr.Length/2;i++)
            {
                if (arr[i] != arr[arr.Length-1-i]) return false;
                return true;
            }
            return false;
        }

        public static int[] GetData()
        {
            Console.WriteLine("Please Enter Num of elemntes");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please Enter Element {i + 1}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

    }
}
