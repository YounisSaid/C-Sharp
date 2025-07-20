namespace OOP_2
{
    internal class Program
    {
        // Structs are value types
        // They are used to represent a single value that has multiple properties
        // They are similar to classes, but they are more lightweight and have some limitations
        // Structs cannot inherit from other structs or classes, but they can implement interfaces
        // Structs are stored on the stack, while classes are stored on the heap
        // Structs are copied by value, while classes are copied by reference

        // public readonly struct 
        public struct Point
        {
            //By default, struct members are private
           public int x;
            public int y;
            //Constructor => Special function
            //same name as struct
            //No return type
            // default constructor
            // not avilable in .net 5 or 6 avilable in .net 7 or later, you can use the following syntax
            public Point()         
            {
               
            }
            // in .net 6 , you can use the following syntax
            //public Point()
            //{
            //    x = 0;
            //    y = 0;
            //}

            public Point(int x, int y) {
                this.x = x;
                this.y = y;
            }

        }

        public class Animal
        {
            public string name { get; set; }
            public virtual void  Eat()
            {
                Console.WriteLine($"eating.");
            }
            public void Sleep()
            {
                Console.WriteLine($"sleeping.");
            }
        }

        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"Barking.");
            }
        }
        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine($"Meowing.");
            }
            // If you want to hide the Eat method from the Animal class, you can use the new keyword
            //public new void Eat()
            //{
            //    Console.WriteLine($"Cat is eating.");
            //}
            // Override the Eat method from the Animal class
            public override void Eat()
            {
                Console.WriteLine($"Cat is eating.");
            }
        }

        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public double Add(double a, double b)
            {
                return a + b;
            }
        }


        public class BankAccount
        {
            private decimal _balance;
            public decimal GetBalance()
            {
                return _balance;
            }
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    _balance += amount;
                }
            }
        }

        public abstract class Shape
        {
            public abstract double Area(); // Abstract method, must be implemented by derived classes
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }
            public Circle(double radius)
            {
                Radius = radius;
            }
            // Override the abstract method from the Shape class
            public override double Area()
            {
                return Math.PI * Radius * Radius; // Area of a circle: πr²
            }
        }

        public class Employee
        {
            //private int _id;
            //private string _name;

            //// getter and setter Methods
            //public int Id
            //{
            //    get { return _id; }
            //    set { _id = value; }
            //}

            //public string GetName()
            //{
            //    return _name;
            //}
            //public void SetName(string name)
            //{
            //    if (!string.IsNullOrEmpty(name))
            //    {
            //        _name = name;
            //    }
            //    else
            //    {
            //        throw new ArgumentException("Name cannot be null or empty");
            //    }
            //}

            //private int id;
            //public int Id
            //{
            //    get { return id; }
            //    set
            //    {
            //        if (value > 0)
            //        {
            //            id = value;
            //        }
            //        else
            //        {
            //            throw new ArgumentException("ID must be greater than 0");
            //        }
            //    }
            //}

            // full property with getter and setter
            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }
            // Auto-implemented property
            public int Id { get; set; }
            public string Name { get; set; }
            


        }
        static void Main(string[] args)
        {
            //Point p01 = new Point();
            //// Console.WriteLine(p01.x);

            //Point p02 = new Point(10, 20);
            //Point p03 = new Point(30, 40);

            //p02 = p03; // Copying the value of p03 to p02
            //Console.WriteLine($"p02.x = {p02.x}, p02.y = {p02.y}");
            //Console.WriteLine($"p03.x = {p03.x}, p03.y = {p03.y}");

            //p02.x = 100; // Changing the value of p02.x
            //p02.y = 200; // Changing the value of p02.y
            //Console.WriteLine($"p02.x = {p02.x}, p02.y = {p02.y}");
            //Console.WriteLine($"p03.x = {p03.x}, p03.y = {p03.y}");

            //// Boxing and Unboxing
            //object obj = p02; // Boxing: converting a value type to an object type

            // 1.Encapsulation
            //BankAccount account = new BankAccount();
            //account.Deposit(1000);
            //Console.WriteLine($"Balance: {account.GetBalance()}");

            //2. Inheritance
            Dog dog = new Dog();
            dog.name = "Buddy";
            dog.Eat(); // Inherited method from Animal class
            dog.Bark(); // Method from Dog class
            Console.WriteLine($"Dog's name: {dog.name}");
            // 3. Polymorphism
            Calculator calculator = new Calculator();
            int intResult = calculator.Add(5, 10); // Calls the int version
            double doubleResult = calculator.Add(5.5, 10.5); // Calls the double version
            Console.WriteLine($"Integer addition result: {intResult}");
            Console.WriteLine($"Double addition result: {doubleResult}");

            // 4. Abstract Classes
            Circle circle = new Circle(5);
            double area = circle.Area(); // Calls the Area method from Circle class

            //Employee employee = new Employee();
            //employee.Id = 1; // Using the setter
            //employee.SetName("John Doe"); // Using the setter
            //Console.WriteLine($"Employee ID: {employee.Id}");
            Employee employee = new Employee();
            //employee.Id = 1; // Using the setter
            //employee.SetName("John Doe"); // Using the setter




        }
    }
}
