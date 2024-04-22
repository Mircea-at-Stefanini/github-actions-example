using SomeClassLibrary;

namespace TestCalculate
{
    public class Tests
    {
        Calculate calculate;
        
        [SetUp]
        public void Setup()
        {
            calculate = new Calculate();
        }

        [Test]
        public void Test1()
        {
            var x = 10;
            var y = 5;
            var result = calculate.Add(x, y);
            var expected = 15;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}