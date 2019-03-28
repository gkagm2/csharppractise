using System;
using System.Collections.Generic;
using System.Text;

namespace practise1
{
    class BirthdayInfo
    {
        //auto implemented property
        public string Name
        {
            get;
            set;
        }
        //auto implemented property
        public DateTime Birthday
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
            return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class AutoImplementedProperty01
    {
        static void Main(string [] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "HyeonMyeong";
            birth.Birthday = new DateTime(1993, 12, 30);

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}", birth.Age);
        }
    }
}
