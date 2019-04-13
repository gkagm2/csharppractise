using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace practise1.practise.Linq
{
    class MClass
    {
        public string Name { get; set; }
        public int [] Score { get; set; }
    }
    class FromFrom03
    {
        static void Main(string[] args)
        {
            MClass[] arraClass = {
                new MClass() {Name ="강아지", Score = new int [] {99,80,70,24}},
                new MClass() {Name ="똥개", Score = new int [] {60,45,87,72}},
                new MClass() {Name ="개똥", Score = new int [] {92,30,85,94}},
                new MClass() {Name = "개나리", Score = new int [] {90,88,0,17}}
            };

            var classes = from c in arraClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };

            foreach(var c in classes)
            {
                Console.WriteLine("낙제 : {0} ({1})", c.Name, c.Lowest);
            }
                          
        }
    }
}
