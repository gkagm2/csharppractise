using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Lambda
{

    class Lambda01
    {
        //익명 메소드를 만들려면 델리게이트가 필요하다. C# 컴파일러는 형식 유추(Type Inference)라는 기능을 제공하여 생략해도 됨.
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            //매개_변수_목록 => 식
            Calculate calc = (a, b) => a + b; //두 개의 int 형식 매개 변수 a, b를 받아 이 둘을 더해 반환하는 익명 메소드를 람다식으로 만들었다.

            Console.WriteLine("{0} + {1} : {2}", 3, 4, calc(3, 4));
        }

    }
}
