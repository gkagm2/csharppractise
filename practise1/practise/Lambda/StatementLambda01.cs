using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Lambda
{
    //문 형식의 람다식
    class StatementLambda01
    {
        delegate string Concatenate(string[] args);

        static void Main(string[] args)
        {
            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                {
                    result += s;
                }
                return result;
            };
            Console.WriteLine(concat(args));
        }
    }
}
