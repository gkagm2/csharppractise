using System;
using System.Collections.Generic;
using System.Text;
//make property
namespace practise1.practise.Example
{
    class NameCard
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

    class Main9_1
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();
            MyCard.Age = 24;
            MyCard.Name = "길동";

            Console.WriteLine("age : {0}", MyCard.Age);
            Console.WriteLine("name : {0}", MyCard.Name);
        }
    }
}
