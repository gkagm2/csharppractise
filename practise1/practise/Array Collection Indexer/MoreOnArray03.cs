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

            //Sort Array
            Array.Sort(scores);

            //Array.ForEach : accomplish same working for all elements of array.
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            //.Rank : Returns the dimension of the Array
            Console.WriteLine("Number of dimensions : {0}", scores.Rank);

            //.BinarySearch :  Do bineary search.
            Console.WriteLine("Binary Search : 81 is at {0}", Array.BinarySearch<int>(scores, 81));

            //.IndexOf : Returns the index of the specific data to find in the array.
            Console.WriteLine("Linear Search: 90 is at {0}", Array.IndexOf(scores, 90));

            //Array.TrueForAll<T>() : 배열의 모든 요소가 지정한 조건에 부합하는지 그 여부를 반환합니다.
            Console.WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            //Array.FindIndex : 배열에서 지정한 조건에 부합하는 첫 번째 요소의 인덱스를 반환합니다. IndexOf()메소드가 특정 값을 찾는 데 비해, FindIndex<T>()메소드는 지정한 조건에 바탕하여 값을 찾는다.
            int index = Array.FindIndex<int>(scores,
                delegate (int score)
                {
                    if (score < 60)
                        return true;
                    else
                        return false;
                });
            scores[index] = 61;
            Console.WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            Console.WriteLine("Old length of scores : {0}", scores.GetLength(0));

            //배열의 크기를 재조정한다.
            Array.Resize<int>(ref scores, 10);

            Console.WriteLine("New Length of scores : {0}", scores.Length);

            //배열의 모든 요소에 대해 동일한 작업을 수행하게 한다.
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
            
            //모든 배열의 요소를 초기화한다. 배열이 숫자 형식 기반이면 0으로, 논리 형식 기반이면 false로, 참조 형식 기반이면 null로 초기화한다. 
            Array.Clear(scores, 3, 7);

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

        }
    }
}
