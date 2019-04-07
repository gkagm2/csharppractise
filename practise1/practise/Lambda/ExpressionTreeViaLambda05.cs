using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace practise1.practise.Lambda
{
    class ExpressionTreeViaLambda05
    {
        static void Main()
        {
            //동적으로 식 트리를 만들기는 불가
            Expression<Func<int, int, int>> expression = (a, b) => 1 * 2 + (a - b);
            Func<int, int, int> func = expression.Compile();

            //x = 7, y = 8
            Console.WriteLine("1*2+({0}-{1}) = {2}", 7, 8, func(7, 8));

        }
    }
}
