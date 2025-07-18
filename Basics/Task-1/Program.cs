using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    //Data Types
    public struct BirthDate
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
    }
    public class Person
    {
        public int ID { get; set; }
        public BirthDate birthDate { get; set; }
    }
    public enum WeeKDays
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7
    }
    //Reference Type
    class Point
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point() { } // Default constructor

        public int x { get; set; }
        public int y { get; set; }
        //inheritaed methods
        public override string ToString()
        {
            return $"{x} ,{y}";
        }
        //public override bool Equals(object obj)
        //{
        //    Point other = obj as Point;
        //    return this.x == other.x && this.y == other.y;


        //}
    }
    class Program
    {
        static void Main()
        {
            //comments
            //int x = 10;
            /*   */
            print();

            //Variables Declartion
            int x;//Declare
            x = 10;//initailaize
            //Data Types
            Person person = new Person();
            //Value Type
            int Y = 20; // Value Type
            Y++; // Y = 21

            //Reference Type
            Point P1 = new Point();
            P1.x = 10;
            P1.y = 20;

            Point P2 = new Point(30, 40);
            P2 = new Point(50, 60); // different Refrence

            //inheritaed methods
            #region Object
            Point P3 = new Point(10, 20);
            Console.WriteLine(P3.ToString()); // Prints the type Fullname by default

            Point P4 = new Point(10, 20);
            Point P5 = new Point(10, 20);
            Console.WriteLine(P4.Equals(P5)); //default compares the references not the values

            String Name1 = "Ali";
            String Name2 = "Ali";
            Console.WriteLine(Name1.Equals(Name2));//he found the same value so he put them in the same reference in heap
            Console.WriteLine(Name1.GetHashCode());
            Console.WriteLine(Name2.GetHashCode()); //same value same hashcode


            Point P6 = new Point(10, 20);
            Console.WriteLine(P6.GetType().FullName);

            //Object
            object obj = new Point(10, 20);
            obj = 5;
            obj = "Hello World";
            obj = 10.5;
            obj = true;

            #endregion

            Console.WriteLine(P1.x);
            Console.WriteLine(P1.y);




            Console.ReadKey();
        }
        //comments//
        /// <summary>
        /// Print
        /// </summary>
        static void print()
        {

        }
    }
}
