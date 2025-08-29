using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_02
{
    //3. Given a Queue, implement a function to reverse the elements of a
    // queue using a stack.
    public static class Q3
    {
        static public void  Reverse<T>(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            int CountQ = queue.Count;
            for(int i = 0; i < CountQ; i++)
            {
                if (queue.Count != 0)
                    stack.Push(queue.Dequeue());
            }
            int StackCount = stack.Count;
            for(int i = 0;i < StackCount; i++)
            {
                if(stack.Count != 0)
                {
                    queue.Enqueue(stack.Pop());
                }
            }
           
        }
    }
}
