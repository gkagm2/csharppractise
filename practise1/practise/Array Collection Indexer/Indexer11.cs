//인덱서는 인덱스를 이용해서 객체 내의 데이터에 접근하게 해 주는 프로퍼티.
//객체를 배열처럼 사용할 수 있게 해준다.
using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.Array_Collection_Indexer
{
    class MyList
    {
        private int[] array;
        public MyList()
        {
            array = new int[3];
        }
        //indexer
        public int this[int index]
        {
            get { return array[index]; }
            set {
                if(index >= array.Length)
                { 
                    Console.WriteLine("index : {0}",index);
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resize : {0}", array.Length);
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
    }
    class Indexer11
    {
        static void Main(string [] args)
        {
            MyList list = new MyList();
            for(int i=0;i< 5; i++)
            {
                list[i] = i;
            }
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
