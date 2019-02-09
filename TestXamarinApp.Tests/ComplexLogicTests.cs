using NUnit.Framework;
using TestXamarinApp;

namespace Tests
{
    public class ComplexLogicTests
    {
        private ComplexLogic cl;

        [SetUp]
        public void Setup()
        {
            cl = new ComplexLogic();
        }

        [Test]
        public void Test1()
        {
            var result = cl.MyVeryComplexCalculation();
            Assert.IsTrue(result);
        }
    }
}