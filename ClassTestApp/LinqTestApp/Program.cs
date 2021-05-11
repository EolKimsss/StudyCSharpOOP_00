using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestApp
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Profile> profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "전지현", Height = 171 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "하하", Height = 171 });

            var profiles2 = profiles.Where(p => p.Height < 172)
                                    .OrderByDescending(p => p.Height)
                                    .Select(item => new { item.Name,Inch = item.Height*0.393});

            #region
            /*            foreach (var item in profiles)
                        {
                            Console.WriteLine($"{item.Name} : {item.Height}");
                        }*/

            //  List<Profile> newProfiles = new List<Profile>();

            /*foreach (var item in profiles)
            {
                if (item.Height < 172)
                    newProfiles.Add(item);
            }*/
            /*
                        var newProfiles = from item in profiles
                                          where item.Height < 172
                                          orderby item.Height descending
                                          select new { Name = item.Name, Inch = item.Height * 0.393 };*/
            /*
            Console.WriteLine("172이하 프로필");
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height}");
            }*/
            /*            int maxSize = 100;
                        int[] numbers = new int[maxSize];
                        for (int i = 0; i < maxSize; i++)
                        {
                            numbers[i] = i + 1;
                        }

                        var result = from item in numbers
                                     where item % 3 == 0
                                     select item;

                        foreach (var item in result)
                        {
                            Console.Write(item + "\t");
                        }*/
            #endregion

/*
            InstClass[] arrClass = {
                new InstClass() { Name = "연두반", Scores = new int[] { 99, 80, 70, 24 } },
                new InstClass() { Name = "분홍반", Scores = new int[] { 60, 45, 87, 72 } },
                new InstClass() { Name = "파랑반", Scores = new int[] { 92, 30, 85, 94 } },
                new InstClass() { Name = "노랑반", Scores = new int[] { 90, 88, 0, 17 } },
                };

            var rstClasses = from item in arrClass
                             from score in item.Scores
                             where score < 60
                             orderby score ascending
                             select new { item.Name, Lowest = score };

            foreach (var item in rstClasses)
            {
                Console.WriteLine($"{item.Name} : {item.Lowest}");
            }*/

            //groupby

            var listProfiles = from item in profiles
                               group item by item.Height < 172 into g
                               select new { GroupKey = g.Key, profiles = g };

            foreach (var item in listProfiles)
            {
                Console.WriteLine($"-172cm 미만 : {item.GroupKey}");
                foreach (var sub in item.profiles)
                {
                    Console.WriteLine($"{sub.Name} : {sub.Height}");
                }
            }

        }
    }
}
