using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Exception
{
    class Throw03
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine("arg : {0}", arg);
            else
                throw new System.Exception("arg is bigger than 10");
        }
        static void Main(string[] args)
        {
            try
            {
                DoSomething(1);
                DoSomething(2);
                DoSomething(3);
                DoSomething(4);
                DoSomething(11);
                DoSomething(13);
            }catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
