using System;
using System.Collections.Generic;
using System.Linq;
using ExpectedObjects;
using LinqLab;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqLabTests
{
    [TestClass()]
    public class SkipAndTakeTests
    {
        [TestMethod()]
        public void Use_Skip_to_skip_5_data()
        {
            var expected =
                new List<Sample>
                {
                    new Sample
                    {
                        Id = 6, UserName = "joey", CreateTime = new DateTime(2016, 5, 20), Price = 8990,
                        Item = new List<int> { 99, 86, 90, 94 }
                    },
                    new Sample
                    {
                        Id = 7, UserName = "joey", CreateTime = new DateTime(2016, 6, 20), Price = 2000,
                        Item = new List<int> { 93, 92, 80, 87 }
                    },
                    new Sample
                    {
                        Id = 8, UserName = "dino", CreateTime = new DateTime(2016, 7, 20), Price = 200,
                        Item = new List<int> { 92, 90, 83, 78 }
                    },
                    new Sample
                    {
                        Id = 9, UserName = "bill", CreateTime = new DateTime(2016, 8, 20), Price = 2000,
                        Item = new List<int> { 68, 79, 88, 92 }
                    },
                    new Sample
                    {
                        Id = 10, UserName = "maduka", CreateTime = new DateTime(2016, 1, 20), Price = 9572,
                        Item = new List<int> { 99, 82, 81, 79 }
                    },
                }.ToExpectedObject();

            var actual = new SkipAndTakeLab().Skip5Data();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void Use_Take_to_get_5_data()
        {
            var expected =
                new List<Sample>
                {
                    new Sample
                    {
                        Id = 1, UserName = "demo", CreateTime = new DateTime(2016, 1, 20), Price = 800,
                        Item = new List<int> { 97, 92, 81, 60 }
                    },
                    new Sample
                    {
                        Id = 2, UserName = "demo", CreateTime = new DateTime(2016, 2, 20), Price = 1800,
                        Item = new List<int> { 75, 84, 91, 39 }
                    },
                    new Sample
                    {
                        Id = 3, UserName = "demo", CreateTime = new DateTime(2016, 3, 20), Price = 2000,
                        Item = new List<int> { 88, 94, 65, 91 }
                    },
                    new Sample
                    {
                        Id = 4, UserName = "demo", CreateTime = new DateTime(2016, 3, 20), Price = 600,
                        Item = new List<int> { 97, 89, 85, 82 }
                    },
                    new Sample
                    {
                        Id = 5, UserName = "joey", CreateTime = new DateTime(2016, 4, 20), Price = 100,
                        Item = new List<int> { 35, 72, 91, 70 }
                    },
                }.ToExpectedObject();

            var actual = new SkipAndTakeLab().Take5Data();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void Use_Skip_to_skip_5_data_and_use_take_to_get_2_data()
        {
            var expected =
                new List<Sample>
                {
                    new Sample
                    {
                        Id = 6, UserName = "joey", CreateTime = new DateTime(2016, 5, 20), Price = 8990,
                        Item = new List<int> { 99, 86, 90, 94 }
                    },
                    new Sample
                    {
                        Id = 7, UserName = "joey", CreateTime = new DateTime(2016, 6, 20), Price = 2000,
                        Item = new List<int> { 93, 92, 80, 87 }
                    },
                }.ToExpectedObject();

            var actual = new SkipAndTakeLab().Skip5DataAndTake2Data();

            expected.ShouldEqual(actual.ToList());
        }
    }
}