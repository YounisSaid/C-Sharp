using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_02
{
    internal class Program
    {
       

        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public double DistanceTo(Point P01,Point P02)
            {
                return Math.Sqrt(Math.Pow(P01.X - P02.X, 2) + Math.Pow(P01.Y - P02.Y, 2));
            }
        }

        public struct person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            //1.Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data.Then,
            //write a C# program to display the details of all the persons in the array.
            person[] persons = new person[3];
            persons[0] = new person("Younis", 30);
            persons[1] = new person("Said", 25);
            persons[2] = new person("Lotfy", 35);
            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            //2Create a struct called "Point" to represent a 2D point with properties
            //"X" and "Y". Write a C# program that
            //takes two points as input from the user and calculates the distance between them.
            Console.WriteLine("Enter the coordinates of the first point (X Y):");
            string[] input1 = Console.ReadLine().Split(' ');
            Point point1 = new Point(int.Parse(input1[0]), int.Parse(input1[1]));
            Console.WriteLine("Enter the coordinates of the second point (X Y):");
            string[] input2 = Console.ReadLine().Split(' ');
            Point point2 = new Point(int.Parse(input2[0]), int.Parse(input2[1]));
            double distance = point1.DistanceTo(point1, point2);
            Console.WriteLine($"The distance between the points ({point1.X}, {point1.Y}) and ({point2.X}, {point2.Y}) is: {distance}");


            //3.Create a struct called "Person" with properties "Name" and "Age". Write a C# program
            //that takes details of 3 persons as
            //input from the user and displays the name and age of the oldest person.
            person[] people = new person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                people[i] = new person(name, age);
            }
            person oldestPerson = people[0];
            foreach (var person in people)
            {
                if (person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }
            Console.WriteLine($"The oldest person is: {oldestPerson.Name}, Age: {oldestPerson.Age}");





        }
    }
}
