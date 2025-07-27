namespace TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Define Class Duration To include Three Attributes Hours,
            //Minutes and Seconds.
            Duration duration = new Duration(2, 30, 45);
            Console.WriteLine($"Duration: {duration}"); // Output: Duration: 02:30:45

            //2.Define All Required Constructors to Produce this output:
            //Duration D1 = new Duration(1, 10, 15);
            //D1.ToString();
            //Output: Hours: 1, Minutes: 10, Seconds: 15
            //Duration D1 = new Duration(3600);
            //D1.ToString();
            //Output: Hours: 1, Minutes: 0, Seconds: 0
            //Duration D2 = new Duration(7800);
            //D2.ToString();
            //Output: Hours: 2, Minutes: 10, Seconds: 0
            //Duration D3 = new Duration(666);
            //D3.ToString();
            //Output: Minutes: 11, Seconds: 6
            //Duration d1 = new Duration(1, 10, 15);
            //Console.WriteLine($"D1: {d1}"); // Output: Hours: 1, Minutes: 10, Seconds: 15
            //Duration d2 = new Duration(3600);
            //Console.WriteLine($"D2: {d2}"); // Output: Hours: 1, Minutes: 0, Seconds: 0
            //Duration d3 = new Duration(7800);
            //Console.WriteLine($"D3: {d3}"); // Output: Hours: 2, Minutes: 10, Seconds: 0
            //Duration d4 = new Duration(666);
            //Console.WriteLine($"D4: {d4}"); // Output: Hours: 0, Minutes: 11, Seconds: 6

        //3. Implement All required Operators overloading to enable this
        //Code:
        //  D3 = D1 + D2
        //  D3 = D1 + 7800
        //  D3 = 666 + D3
        //  D3 = ++D1(Increase One Minute)
        //  D3 = --D2(Decrease One Minute)
        //  D1 = D1 - D2
        //  If(D1 > D2)
        Duration  D1 = new Duration(2, 30, 45);
            Duration D2 = new Duration(1, 10, 15);
            Duration D3 = D1 + D2; 
            Console.WriteLine($"D3: {D3}"); 
            D3 = D1 + 7800; 
            Console.WriteLine($"D3 after adding 7800 seconds: {D3}");
            D3 = 666 + D3;
            Console.WriteLine($"D3 after adding 666 seconds: {D3}"); 
            D3 = ++D1;
            Console.WriteLine($"D3 after incrementing D1: {D3}"); // Output: Duration: 02:31:45
            D3 = --D2; 
            Console.WriteLine($"D3 after decrementing D2: {D3}"); // Output: Duration: 01:09:15
            D1 = D1 - D2; 
            Console.WriteLine($"D1 after subtracting D2 from it: {D1}"); 
            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }

        }
    }
}
