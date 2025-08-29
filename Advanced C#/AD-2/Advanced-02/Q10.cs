using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_02
{
    public static class Q10
    {
        public static List<int> Contiguous(ArrayList list, int Value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int sum = 0;
                List<int> result = new List<int>();

                for (int j = i; j < list.Count; j++)
                {
                    sum += (int)list[j];
                    result.Add((int)list[j]);

                    if (sum == Value)
                        return result;
                    else if (sum > Value)
                        break;
                }
            }
            return null;
        }

    }
}
