using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    public static class ListHelpers
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            if (numbers == null) throw new ArgumentNullException(nameof(numbers));
            var evens = new List<int>();
            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                    evens.Add(n);
            }
            return evens;
        }
    }
}
