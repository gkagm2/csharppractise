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
    class GroupBy04
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name="정우성", Height=186 },
                new Profile() { Name="김태희", Height=158 },
                new Profile() { Name="고현정", Height=172 },
                new Profile() { Name="이문세", Height=178 },
                new Profile() { Name="하하", Height=171 }
            };

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g //2개의 그룹으로 나눔
                              select new { GroupKey = g.Key, Profiles = g };
            foreach(var Group in listProfile)
            {
                Console.WriteLine("- 175cm 미만? :  {0}", Group.GroupKey);
                foreach(var profile in Group.Profiles)
                {
                    Console.WriteLine("   {0}, {1}", profile.Name, profile.Height);
                }
            }
            
        }
    }
}
