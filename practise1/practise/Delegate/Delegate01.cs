using System;
using System.Collections.Generic;
using System.Text;


namespace practise1.practise.Delegate
{
    delegate int MyDelegate(int a, int b);
    class Delegate01
    {
        //델리게잍트 소스는 인스턴테 메소드도 참조할 수 이있구ㅗ
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b) {
            return a - b;
        }
        //TODO

    }
}
