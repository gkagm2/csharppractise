//Collection - ArrayList 
using System;
using System.Text;
using System.Collections; //need to use for ArrayList

namespace practise1.practise.Array_Collection_Indexer
{
    class UsingArrayList07
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for(int i = 0; i < 5; i++)
            {
                //추가
                list.Add(i);
            }

            //Collections에서 ArrayList는 object 타입
            foreach(object obj in list)
            {

                Console.Write("{0} ", obj);
            }
            Console.WriteLine();

            //remove (2번 인덱스의 요소값 삭제)
            list.RemoveAt(2);

            foreach(object obj in list)
            {
                Console.Write("{0} ", obj);
            }
            Console.WriteLine();

            //insert (2번 인덱스에 11을 삽입) (사이에 삽입)
            list.Insert(2, 11);
            
            foreach(object obj in list)
            {
                Console.Write("{0} ", obj);
            }
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            //이런식으로도 접근 가능
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }
            Console.WriteLine();
        }
        
    }
}
