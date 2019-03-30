//foreach가 가능한 객체 만들기.
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace practise1.practise.Array_Collection_Indexer
{
    class MyList
    {
        //IEnumerator로부터 상속받은 Current 프로퍼티는 현재 위치의 요소를 반환한다.
        private int[] array;
        
        //컬렉션의 현재 위치를 다루는 변수. 초기 값은 0이 아닌 -1이다. 0은 배열의 첫 번째 요소를 가리키는 수이기 때문에
        //position이 이 값(0)을 갖고 있다면 foreach문이 첫 번째 반복을 수행하면 MoveNext() 메소드를 실행하고, 이 때 position이
        //1이 되어 두 번째 요소를 가져오게 된다.
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }
        //인덱서
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }
                array[index] = value;
            }
        }
        //IEnumerator member
        public object Current
        {
            get
            {
                return array[position];
            }
        }

        //IEnumerator member
        public bool MoveNext()
        {
            if(position == array.Length - 1)
            {
                Reset();
                return false;
            }
            ++position;
            return (position < array.Length);

        }

        //IEnumerator member
        public void Reset()
        {
            position = -1;
        }

        //IEnumerable  (using System.Collections 필요)
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < array.Length; i++)
            {
                // yield return 문을 만나면 for 문은 중단되고 GetEnumerator()는 array[i]를 반환한다.
                // 하지만  GetEnumerator()가 다시 호출되면 for문은 중단된 그 다음 위치에서 반복을 이어간다.
                // (i가 1일 때 멈췄다면, i가 2인 값으로 반복을 진행한다는 말이다.)
                yield return (array[i]);
            }
        }
    }
    class Enumerable12
    {
        static void Main(string [] args)
        {
            MyList list = new MyList();
            for(int i = 0; i < 5; i++)
            {
                list[i] = i;
            }

            foreach(int e in list)
            {
                Console.WriteLine(e);
            }
        }
    }
}
