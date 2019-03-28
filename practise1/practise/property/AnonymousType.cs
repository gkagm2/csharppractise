using System;

namespace practise1
{
    class AnonymousType
    {
        static void Main(string [] args)
        {
            //using var type
            var a = new { Name = "JangHyeonMyeong", Age = 123 };
            // can't change vaules after allocated 
            Console.WriteLine("Name: {0}, Age: {1}", a.Name, a.Age);

            var b = new { Subject = "Math", Scores = new int[] { 90, 80, 70, 60 } };

            Console.Write("Subject:{0}, Scores: ", b.Subject);
            foreach(var score in b.Scores)
            {
                Console.Write("{0} ", score);
                
            }
            Console.WriteLine();

        }
    }
}
