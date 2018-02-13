using System;
using NUnit.Framework;
using TestingAssignment2;

namespace MyTestProject
{
    [TestFixture]
    public class Class1
    {
        static Premium p;
        [SetUp]
        public static void Init()
        {
            p = new Premium();
        }

        [Test]
        public static void Test1()
        {
            double expectedResult = 5;

            double actualResult = p.CalcPremium(25, "female");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test2()
        {
            double expectedResult = 6;

            double actualResult = p.CalcPremium(25, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test3()
        {
            double expectedResult = 0;

            double actualResult = p.CalcPremium(17, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test4()
        {
            double expectedResult = 0;

            double actualResult = p.CalcPremium(17, "female");

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public static void Test5()
        {
            double expectedResult = 6;

            double actualResult = p.CalcPremium(31, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test6()
        {
            double expectedResult = 2.5;

            double actualResult = p.CalcPremium(31, "female");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test7()
        {
            double expectedResult = 0.75;

            double actualResult = p.CalcPremium(50, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test8()
        {
            double expectedResult = 5;

            double actualResult = p.CalcPremium(40, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
