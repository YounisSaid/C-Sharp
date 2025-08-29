using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_02
{
    //5. Given an array, implement a function to remove duplicate elements
    // from an array.
    public class Q5
    {
         public static int[] RemoveDuplicate(int[] arr)
        {
            SortedSet<int> uniqueSorted = new SortedSet<int>(arr);
            return uniqueSorted.ToArray();
        }

    }
}
