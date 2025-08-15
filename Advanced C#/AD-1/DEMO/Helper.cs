using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public static class Helper
    {
        //public static void Swap(ref int Num1, ref int Num2)
        //{
        //    int temp = Num1;
        //    Num1 = Num2;
        //    Num2 = temp;

        //}

        //public static void Swap(ref Point point1, ref Point point2)
        //{
        //    Point temp = point1;
        //    point1 = point2;
        //    point2 = temp;
        //}
        public static int LinearSearch<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i; 
                }
            }
            return -1; 
        }

        public static void BubbleSort<T>(T[] values) where T : IComparable<T>
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = 0; j < values.Length - 1 - i; j++)
                {
                    if (values[j].CompareTo(values[j + 1]) > 0)
                    {
                        Swap(ref values[j], ref values[j + 1]);
                    }
                }
            }
        }

        public static int LinearSearch<T>(T[] array, T value,IEqualityComparer<T> equalityComparer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (equalityComparer.Equals(value, array[i]))
                {
                    return i; 
                }
            }
            return -1; 
        }
        public static void Swap<T>(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }

    }
}
