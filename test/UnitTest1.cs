using NUnit.Framework;

namespace test
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
            //Assert.Pass();

            var calculator = new Calculator();

            int result = calculator.Add(4, 4);
            //achraf
            Assert.AreEqual(8, result);
        }


        [Test]
        public void Test2()
        {
            //Assert.Pass();

            var calculator = new Calculator();

            int result = calculator.Add(4, 3);
            //achraf
            Assert.AreEqual(7, result);
        }




    }
}