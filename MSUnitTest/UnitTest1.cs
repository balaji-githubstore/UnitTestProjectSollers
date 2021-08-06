using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sollers.Calculator;

namespace MSUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calc obj = new Calc();
            double actualResult = obj.Add(-1, -1);

            Assert.AreEqual(2, actualResult); //hard assertion
            System.Console.WriteLine("ss");  
        }
    }
}
