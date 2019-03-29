using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Array_Collection_Indexer
{
    class InitializingArray01
    {
        static void Main(string[] args)
        {
            //array
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };
            Console.WriteLine("array1...");
            foreach(string ary in array1)
            {
                Console.WriteLine("{0} ", ary);
            }

            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray2...");

            foreach (string ary in array1)
            {
                Console.WriteLine("{0} ", ary);
            }

            string[] array3 = { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray3...");

            foreach (string ary in array3)
            {
                Console.WriteLine("{0}", ary);
            }
        }
    }
}
