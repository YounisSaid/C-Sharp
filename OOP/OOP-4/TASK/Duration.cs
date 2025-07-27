using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        // Constructor to initialize the duration
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            // Convert total seconds to hours, minutes, and seconds
            Hours = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = seconds % 60;
        }
        // Overloading the + operator to add two Duration objects
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        // Overloading the + operator to add Duration and seconds
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }
        // Overloading the + operator to add seconds and Duration
        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }
        // Overloading the ++ operator to increase the duration by one minute
        public static Duration operator ++(Duration d)
        {
            d.Minutes++;
            if (d.Minutes >= 60)
            {
                d.Minutes = 0;
                d.Hours++;
            }
            return d;
        }
        // Overloading the -- operator to decrease the duration by one minute
        public static Duration operator --(Duration d)
        {
            d.Minutes--;
            if (d.Minutes < 0)
            {
                d.Minutes = 59;
                d.Hours--;
            }
            return d;
        }
        // Overloading the - operator to subtract two Duration objects
        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(totalSeconds1 - totalSeconds2);
        }
        // Overloading the > operator to compare two Duration objects
        public static bool operator >(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 > totalSeconds2;
        }
        // Overloading the < operator to compare two Duration objects
        public static bool operator <(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 < totalSeconds2;
        }
  
        public override string ToString()
        {
            return $"Hours:{Hours},Minutes : {Minutes},Seconds:{Seconds}";
        }
    }
}
