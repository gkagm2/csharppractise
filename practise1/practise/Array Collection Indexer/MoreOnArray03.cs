using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Array_Collection_Indexer
{
    class MoreOnArray03
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60)
                return true;
            else
                return false;
        }
        private static void Print(int value)
        {
            Console.Write("{0}", value);
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach(int score in scores)
            {
                Console.Write("{0} ", score);
            }
            Console.WriteLine();

            //배열을 정렬한다.
            Array.Sort(scores);

            //배열의 모든 요소에 대해 동일한 작업을 수행하게 한다.
            //TODO
            //Array.ForEach<int>(scores, new Action<int>)
        }
    }
}
