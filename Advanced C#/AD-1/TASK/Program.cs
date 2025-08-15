namespace TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Range<int> range = new Range<int>(1, 10);
            //Console.WriteLine($"Length of the range: {range.Length()}");
            //Console.WriteLine($"Is 5 in range? {range.IsInRange(5)}");

            //MyArrayList<int> myArrayList = new MyArrayList<int>();
            // int[] array = { 1, 2, 3, 4, 5 };
            // MyArrayList<int>.Reverse(array);
            // Console.WriteLine("Reversed array: " + string.Join(", ", array));

          List<int> ints =ListHelpers.GetEvenNumbers(new List<int> { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine("Even numbers: " + string.Join(", ", ints));
            


        }
    }
}
