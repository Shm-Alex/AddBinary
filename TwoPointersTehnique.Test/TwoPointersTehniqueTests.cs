using NTwoPointersTehnique;
using NUnit.Framework.Internal.Commands;

namespace TwoPointersTehniqueTest
{
    public class TwoPointersTehniqueTests
    {
        private TwoPointersTehnique sut;

        [SetUp]
        public void Setup()
        {
            sut = new TwoPointersTehnique();
        }
        [TestCase("Hello world", ExpectedResult ="dlrow olleH", Description = "positive test")]
        [TestCase("H", ExpectedResult = "H", Description = "border test")]
        [TestCase("", ExpectedResult = "", Description = "border test")]
        public string StrStr(string stringToReverse) {
            var tst = stringToReverse.ToCharArray();
            sut.ReverseString(tst);
            return new string(tst);
                }
    }
}