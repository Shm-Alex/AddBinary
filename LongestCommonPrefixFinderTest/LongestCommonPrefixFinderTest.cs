using NLongestCommonPrefixFinder;
using NUnit.Framework.Internal;

namespace LongestCommonPrefixFinderTest
{
    public class LongestCommonPrefixFinderTest
    {
        private LongestCommonPrefixFinder sut;

        [SetUp]
        public void Setup()
        {
            sut = new LongestCommonPrefixFinder();
        }
        [TestCase(false,new string[] { "flackon", "ffl", "f00" }, ExpectedResult = "f", Description = "positive test")]
        [TestCase(false, new string[] { "", "ffl", "f00" }, ExpectedResult = "", Description = "positive test")]
        [TestCase(false, new string[] { "sdasas", "sdanvbn", "f00" }, ExpectedResult = "", Description = "positive test")]
        [TestCase(false, new string[] { "sdasas"}, ExpectedResult = "sdasas", Description = "positive test")]
        [TestCase(false, new string[] { "ab","a" }, ExpectedResult = "a", Description = "positive test")]
        public string LongestCommonPrefix(bool tst,string     [] strs) => sut.LongestCommonPrefix(strs);
        
    }
}