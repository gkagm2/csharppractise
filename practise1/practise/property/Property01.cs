//property practise. you can use ctrl + . (in visual studio)
using System;

namespace practise1
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    
    class Property01
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "HyeonMyeong";
            birth.Birthday = new DateTime(1993, 12, 30);

            Console.WriteLine("Name :  {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}", birth.Age);
            
        }
    }
}
