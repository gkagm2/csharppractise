using System;
using System.Collections.Generic;
using System.Text;


namespace practise1.practise.Delegate
{
    //델리게이트의 선언
    delegate int MyDelegate(int a, int b); 
    class Calculator
    {
        //delegate source는 인스턴스 메소드도 참조할 수 있고
        public int Plus(int a, int b)
        {
            return a + b;
        }
        //delegate는 정적 메소드도 참조할 수 있다.
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Delegate01
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));
        }
    }
}
