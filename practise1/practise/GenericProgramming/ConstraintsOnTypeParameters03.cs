using System;
using System.Collections.Generic;
using System.Text;

namespace practise1.practise.GenericProgramming
{
    class StructArray<T> where T : struct //T는 값 형식이여야 한다.
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }
    class RefArray<T> where T : class //T는 참조 형식이여야 한다.
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }
    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }
        public void CopyArray<T>(T[] Source) where T : U //T는 또 다른 형식 매개 변수 U로부터 상속받은 클래스여야 한다.
        {
            Source.CopyTo(Array, 0); //현재 1차원 배열의 모든 요소를 지정된 1차원 배열에 복사합니다.
        }

    }




    class ConstraintsOnTypeParameters03
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        static void Main(string [] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1001);

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();
            //Base  형식은 여기에 할당 할 수 없다.
            //d.Array[4] = new Base();
            //d.Array[5] = CreateInstance<Base>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);x
            e.CopyArray<Derived>(d.Array);

        }
    }
}
