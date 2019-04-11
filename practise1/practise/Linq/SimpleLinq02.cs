using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace practise1.practise.Linq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class SimpleLinq02
    {
        static void Main(string [] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name="Jang", Height=180},
                new Profile() { Name="Hyeon", Height=172},
                new Profile() { Name="Myeong", Height=181},
                new Profile() { Name="Hong", Height=167},
                new Profile() { Name="Fak", Height=178}
            };

            var profiles = from profile in arrProfile
                           where profile.Height < 175
                           orderby profile.Height
                           select new
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };
            foreach(var profile in profiles)
            {
                Console.WriteLine("{0}, {1}", profile.Name, profile.InchHeight);
            }
        }
    }
}
