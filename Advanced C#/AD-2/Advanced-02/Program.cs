using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_02
{
    internal class Program
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

        static void Main(string[] args)
        {
            //Q1.GreaterThanX();
            //if(Q2.Ispalindrome())
            //{
            //    Console.WriteLine("Array is palindrome ");
            //}
            //else
            //{
            //    Console.WriteLine("Array is not palindrome ");
            //}
            //Queue<int> queue = new Queue<int>([ 1,2,3,4,5,6]);
            //Q3.Reverse<int>(queue);
            //int QCount = queue.Count;
            //for(int i = 0; i < QCount; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //int[] arr = { 1, 1, 1, 1, 3, 2, 5, 6, 5, 2, 6, 5 };
            //arr = Q5.RemoveDuplicate(arr);
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //static void RemoveOddNumbers(List<int> numbers)
            //{

            //    numbers.RemoveAll(n => n % 2 != 0);
            //}

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //RemoveOddNumbers(numbers);

            //Console.WriteLine(string.Join(", ", numbers));

            //MyQueue queue = new MyQueue();

            //queue.Enqueue(1);         
            //queue.Enqueue("Apple");   
            //queue.Enqueue(5.28);      

            //queue.PrintAll();

            //List<int> list = Q9.Intersection([1, 2, 3, 4, 4, 6, 8], [1, 5, 3, 6, 4, 9, 4, 5]);
            //list.ForEach(x => Console.WriteLine(x));

            List<int> list = Q10.Contiguous([1, 2, 3, 7, 8, 9], 12);
            if (list != null)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
