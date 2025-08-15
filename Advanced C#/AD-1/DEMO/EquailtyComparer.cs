using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class EquailtyComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Id == y?.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
           return obj.Id.GetHashCode();
        }
    }
}
