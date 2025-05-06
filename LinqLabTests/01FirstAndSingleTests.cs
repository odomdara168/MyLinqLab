using System;
using System.Collections.Generic;
using ExpectedObjects;
using LinqLab;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqLabTests
{
    [TestClass()]
    public class FirstAndSingleTests
    {
        [TestMethod()]
        public void Use_FirstTest_search_userName_Equal_demo()
        {
            var expected =
                new Sample
                {
                    Id = 1,
                    UserName = "demo",
                    CreateTime = new DateTime(2016, 1, 20),
                    Price = 800,
                    Item = new List<int> { 97, 92, 81, 60 }
                }.ToExpectedObject();

            var actual = new FirstAndSingleLab().FirstToGetUserNameEqualToDemo();

            expected.ShouldEqual(actual);
        }

        [TestMethod()]
        public void Use_FirstOrDefaultTest_to_search_userName_equal_skilltree()
        {
            Sample expected = null;
            var actual = new FirstAndSingleLab().FirstOrDefaultToGetUserNameEuqalToSkilltree();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Use_First_to_search_UserName_equal_skilltree()
        {
            var actual = new FirstAndSingleLab().FirstToGetUserNameEuqalToSkilltree();
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Use_Single_to_search_UserName_equal_demo()
        {
            var actual = new FirstAndSingleLab().SingleToGetUserNameEuqalToDemo();
        }

        [TestMethod()]
        public void Use_Single_to_search_UserName_equal_bill()
        {
            var expected =
                new Sample
                {
                    Id = 9,
                    UserName = "bill",
                    CreateTime = new DateTime(2016, 8, 20),
                    Price = 2000,
                    Item = new List<int> { 68, 79, 88, 92 }
                }.ToExpectedObject();

            var actual = new FirstAndSingleLab().SingleToGetUserNameEuqalToBill();

            expected.ShouldEqual(actual);
        }

        [TestMethod()]
        public void Use_SingleOrDefault_to_search_UserName_equal_bill()
        {
            var expected =
                new Sample
                {
                    Id = 9,
                    UserName = "bill",
                    CreateTime = new DateTime(2016, 8, 20),
                    Price = 2000,
                    Item = new List<int> { 68, 79, 88, 92 }
                }.ToExpectedObject();

            var actual = new FirstAndSingleLab().SingleOrDefaultToGetUserNameEuqalToBill();

            expected.ShouldEqual(actual);
        }

        [TestMethod()]
        public void Use_SingleOrDefault_to_search_UserName_equal_skillTree()
        {
            Sample expected = null;

            var actual = new FirstAndSingleLab().SingleOrDefaultToGetUserNameEuqalToSkillTree();

            Assert.AreEqual(expected, actual);
        }
    }
}