using NUnit.Framework;
using Calculator;

namespace NUnitTest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestRegularUseCaseWithSmallNumbers()
        {
            //Arrange:
            SimpleCalculator simpleCalculator = new SimpleCalculator();
            //Act:
            int result = simpleCalculator.Add(1, 2);
            //Assert:
            Assert.AreEqual(30, result);
        }



    }
}