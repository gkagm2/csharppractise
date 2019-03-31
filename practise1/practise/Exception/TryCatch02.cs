using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Exception
{
    class TryCatch02
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("occur exception : {0}", e.Message);
            }
            Console.WriteLine("exit");
        }
            
    }
}
