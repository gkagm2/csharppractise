using System;
using System.Collections.Generic;
using System.Collections; // need
using System.Text;

namespace practise1.practise.Array_Collection_Indexer
{
    class UsingStack09
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
