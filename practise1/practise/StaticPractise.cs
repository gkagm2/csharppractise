using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise
{
    public class TestClass{
        static int count = 0;
        public TestClass()
        {
            count++;
            Console.WriteLine("count : " + count);
        }
    }
    class StaticPractise
    {
        static void Main(string[] argv)
        {
            TestClass testClass = new TestClass();
            TestClass testClass2 = new TestClass();
        }
    }
}
