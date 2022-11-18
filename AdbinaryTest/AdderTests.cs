using NAddBinary;
namespace AdbinaryTest
{
    public class AdderTests
    {
        private Adder adder;
        [SetUp]
        public void Setup()
        {
            adder= new Adder();
        }

        [TestCase("1","0",ExpectedResult ="1",Description ="Simple test")]
        [TestCase("1011", "100", ExpectedResult = "1111", Description = "Simple test")]
        [TestCase("1011", "101", ExpectedResult = "10000", Description = "Simple test")]
        [TestCase("1", "1", ExpectedResult = "10", Description = "overflow")]
        [TestCase("0", "01", ExpectedResult = "1", Description = "trim leading zeroes")]
        [TestCase("00", "00", ExpectedResult = "0", Description = "squash zeroes")]
        public string AddBinary( string firstTerm, string secondTerm)=>adder.AddBinary(firstTerm, secondTerm);
        
    }
}