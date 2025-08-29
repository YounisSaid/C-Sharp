using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_02
{
    public static class Q9
    {
        public static List<int> Intersection(int[] arr1 , int[] arr2)
        {
            List<int> list = new List<int>();
            Dictionary<int,int> map1 = new Dictionary<int,int>();
            Dictionary<int,int> map2 = new Dictionary<int, int>();
            int Counter = 0;
            foreach (var i in arr1)
            {
                if (map1.ContainsKey(i))
                    map1[i]++;
                else map1[i] = 1;
            }

            foreach (var i in arr2)
            {
                if (map2.ContainsKey(i))
                    map2[i]++;
                else map2[i] = 1;
            }

            foreach(var i in map1)
            {
                if(map2.ContainsKey(i.Key))
                {
                    int times = Math.Min(i.Value,map2.GetValueOrDefault(i.Key));
                    for (int j = 0; j < times; j++)
                    {
                        list.Add(i.Key);
                    }
                }
            }

            return list;
        }
    }
}
