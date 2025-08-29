using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_02
{
    class MyQueue
    {
        private Queue<object> queue = new Queue<object>();

        public void Enqueue(object item)
        {
            queue.Enqueue(item);
        }

        public object Dequeue()
        {
            return queue.Dequeue();
        }

        public void PrintAll()
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

    }
}
