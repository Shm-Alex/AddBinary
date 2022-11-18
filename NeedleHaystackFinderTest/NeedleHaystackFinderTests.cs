using NAddBinary;
using NNeedleHaystackFinder;
namespace NeedleHaystackFinderTest
{
    public class NeedleHaystackFinderTests
    {
        NeedleHaystackFinder sut;
        [SetUp]
        public void Setup()
        {
            sut=new NeedleHaystackFinder();
        }

        [TestCase("haystack", "needle", ExpectedResult = -1, Description = "negative test")]
        [TestCase("sadbutsad", "sad", ExpectedResult = 0, Description = "\"sad\" occurs at index 0 and 6. The first occurrence is at index 0, so we return 0.")]
        [TestCase("leetcode", "leeto", ExpectedResult = -1, Description = "\"leeto\" did not occur in \"leetcode\", so we return -1")]
        [TestCase("leetcode", "code", ExpectedResult = 4, Description = "test neddle at the bottom of the haystack ")]
        public int StrStr(string haystack, string needle) => sut.StrStr(haystack, needle);
    }
}