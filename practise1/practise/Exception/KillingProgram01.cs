using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Exception
{
    class KillingProgram01
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("exit");
        }
    }
}
