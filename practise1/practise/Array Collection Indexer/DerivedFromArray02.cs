using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Array_Collection_Indexer
{
    class DerivedFromArray02
    { 
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 30, 20, 7, 1 };
            Console.WriteLine("Type of array  : {0}", array.GetType());

            Console.WriteLine("Base Type of array : {0}", array.GetType().BaseType);
        }
    }
}
