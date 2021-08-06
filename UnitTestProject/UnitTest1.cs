
using NUnit.Framework;
using Sollers.Calculator;
using System;
using System.Threading;

//designed by balaji
namespace UnitTestProject
{
    public class CalcTests
    {
        [Test,MaxTime(1000),Ignore("not req",Until ="2021-08-04"),Retry(2)]
        public void AddMethodTest()
        {
            Thread.Sleep(1500);
            Calc obj = new Calc();
            double actualResult = obj.Add(-1, -1);

            Assert.AreEqual(-2, actualResult); //verify the output
        }

        [TestCase(2,2,5)]
        [TestCase(2.2, 2, 4.2)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 0, 1)]
        public void AddMethodsTest(double a,double b,double expectedValue)
        {
            Calc obj = new Calc();
            double actualResult = obj.Add(a, b);
            Assert.AreEqual(expectedValue, actualResult); //verify the output
        }


        [Test,Repeat(2)]
        public void SubTest([Random(-100,200,5)]double a, [Random(100, 200, 5)] double b)
        {
            Calc obj = new Calc();
            double actualResult = obj.Sub(a, b);
            Assert.AreEqual(a-b, actualResult); //verify the output
        }

        [Test]
        public void Sub1Test([Values(1, 3, 5)] double a, [Values(11, 13, 15)] double b)
        {
            Calc obj = new Calc();
            double actualResult = obj.Sub(a, b);
            Assert.AreEqual(a - b, actualResult); //verify the output
        }


        [Test]
        public void AreaOfCircleTest([Random(-100, 300, 5)] int radius)
        {
            Calc obj = new Calc();
            Assert.AreEqual(radius * radius * Math.PI, obj.AreaOfCircle(radius));
        }
    }
}