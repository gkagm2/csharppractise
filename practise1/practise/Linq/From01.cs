using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace practise1.practise.Linq
{
    class From01
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach (int n in result)
            {
                Console.WriteLine("짝수 : {0}", n);
            }
        }
    }
}
