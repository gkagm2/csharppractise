using System;
using System.Collections.Generic;
using System.Collections; // need
using System.Text;

namespace practise1.practise.Array_Collection_Indexer
{
    class UsingQueue08
    {
        static void Main(string [] args)
        {
            //queue
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0){
                Console.WriteLine(queue.Dequeue());
            }
            
        }
    }
}
