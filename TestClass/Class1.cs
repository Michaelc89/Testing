using System;
using NUnit.Framework;
using TestingAssignment2;

namespace TestClass
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
            double expectedResult = 5;

            double actualResult = p.CalcPremium(25, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
