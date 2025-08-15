using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    public class MyArrayList<T>
    {
        public static void Reverse(T[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            while (start < end)
            {
                T temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
