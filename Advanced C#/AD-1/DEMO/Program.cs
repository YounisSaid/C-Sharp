namespace DEMO
{
    internal class Program
    {
        static void Print(object input)
        {
            Console.WriteLine(input);
        }
        static void Main(string[] args)
        {
            //int Num1 = 10;
            //int Num2 = 10;
            //Print("Before Swap:");
            //Print($"Num1: {Num1}, Num2: {Num2}");
            //Helper.Swap(ref Num1, ref Num2);
            //Print("After Swap:");
            //Print($"Num1: {Num1}, Num2: {Num2}");

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int valueToFind = 3;
            //int index = Helper.LinearSearch(numbers, valueToFind);
            //if (index != -1)
            //{
            //    Print($"Value {valueToFind} found at index {index}.");
            //}
            //else
            //{
            //    Print($"Value {valueToFind} not found in the array.");
            //}

            Employee[] employees = 
            {
                new Employee("Alice", 1, 50000),
                new Employee("Bob", 2, 60000),
                new Employee("Charlie", 3, 70000)
            };
            Employee emp1 = employees[0];
            //int index = Helper.LinearSearch(employees, emp1);
            //if (index != -1)
            //{
            //    Print($"Employee {emp1.Name} found at index {index}.");
            //}
            //else
            //{
            //    Print($"Employee {emp1.Name} not found in the array.");
            //}

            //if (emp1.Equals(employees[1]))
            //    Console.WriteLine("Employee is Equal");
            //else
            //    Console.WriteLine("Not Equal");// This will call the Equals method of Employee class
            int index = Helper.LinearSearch(employees, emp1, new EquailtyComparer());
            if (index != -1)
            {
                Print($"Employee {emp1.Name} found at index {index}.");
            }
            else
            {
                Print($"Employee {emp1.Name} not found in the array.");
            }

            int[] numbers = { 1, 5, 3, 4, 5 };
            Helper.BubbleSort(numbers);
            Print("Sorted numbers:");
            foreach (var number in numbers)
            {
                Print(number);
            }



        }
    }
}
