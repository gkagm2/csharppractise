using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace practise1.practise.Array_Collection_Indexer
{
    class UsingHashtable10
    {
        // Hashtable ( key, value)
        static void Main(string [] args)
        {
            Hashtable hash = new Hashtable();

            hash["one"] = "first";
            hash["two"] = "second";
            hash["three"] = "3";
            hash["four"] = "4";
            hash["five"] = "5";

            Console.WriteLine(hash["one"]);
            Console.WriteLine(hash["two"]);
            Console.WriteLine(hash["three"]);
            Console.WriteLine(hash["four"]);
            Console.WriteLine(hash["five"]);

        }
    }
}
