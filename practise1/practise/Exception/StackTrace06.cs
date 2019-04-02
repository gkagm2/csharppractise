using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Exception
{
    class StackTrace06
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                Console.WriteLine(3 / --a);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
