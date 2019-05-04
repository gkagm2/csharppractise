using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise
{
    class Test
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);


            foreach(int number in stack)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(stack.Count); // Stack에 총 items의 수
            Console.WriteLine(stack.Contains(3)); //3이 포함되어있는지 ?  true or false 반환
            Console.WriteLine(stack.Peek()); // 맨 위에 개체를 제거하지 않고 반환한다.
        }
    }
}
