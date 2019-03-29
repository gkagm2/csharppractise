using System;
using System.Collections.Generic;
using System.Text;
//make Anonymous type
namespace practise1
{
    class Main9_2
    {
        static void Main(string[] args)
        {
            //(Anonymous Type)무명 형식을 이용해서 완성
            var nameCard = new { Name = "홍길동", Age = 20 };
            Console.WriteLine("name : {0}, age : {1}", nameCard.Name, nameCard.Age);

            //(Anonymous Type)무명 형식을 이용해서 완성 // don't need class 
            var complex = new { Real = 3, Imaginary = -12 };
            Console.WriteLine("Real : {0}, Imaginary : {1}", complex.Real, complex.Imaginary);
            
        }
    }
}
