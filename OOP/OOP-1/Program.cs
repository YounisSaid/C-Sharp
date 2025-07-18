using System.ComponentModel;
using System.Drawing;
using System.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_1
{
    internal class Program
    {
        
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        [Flags]
        public enum Permissions
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        public enum Colors
        {
            Red,
            Green,
            Blue
        }
        static void Main(string[] args)
        {
            //1 - Create an enum called "WeekDays" with the days of the week
            //(Monday to Sunday) as its members.Then, write a C# program that
            //prints out all the days of the week using this enum.
            //Console.WriteLine("Days of the Week:");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            //2.Create an enum called "Season" with the four seasons(Spring,
            // Summer, Autumn, Winter) as its members.Write a C# program that
            // takes a season name as input from the user and displays the
            // corresponding month range for that season. Note range for seasons (
            //spring march to may , summer june to august, autumn September to
            //November, winter December to February)
            //Console.WriteLine("\nEnter a season (Spring, Summer, Autumn, Winter):");
            //string inputSeason = Console.ReadLine();
            //Season season;
            //if (Enum.TryParse(inputSeason, true, out season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season.");
            //}

            //4 - Assign the following Permissions(Read, write, Delete, Execute) in a
            // form of Enum.
            //  ● Create Variable from previous Enum to Add multible
            //  Permission
            //Console.WriteLine("\nPermissions:");
            //Permissions userPermissions = Permissions.Read | Permissions.Write | Permissions.Execute;
            //Console.WriteLine($"User Permissions: {userPermissions}");
            //userPermissions = userPermissions | Permissions.Delete; // Adding Delete permission
            //Console.WriteLine($" User Permissions: {userPermissions}");
            //userPermissions = userPermissions ^ Permissions.Write;  // Removing Write permission
            //Console.WriteLine($"User Permissions after removing Write: {userPermissions}");

            //5.Create an enum called "Colors" with the basic colors(Red, Green, Blue)
            // as its members.Write a C# program that takes a color name as input from
            // the user and displays a message indicating whether the input color is a
            // primary color or not.
            //Console.WriteLine("\nEnter a color (Red, Green, Blue):");
            //string inputColor = Console.ReadLine();
            //Colors color;
            //if (Enum.TryParse(inputColor, true, out color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{inputColor} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{inputColor} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid color.");
            //}



        }
    }
}
