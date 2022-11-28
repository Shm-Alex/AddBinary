using NArrayPairSum;


namespace ArrayPairSummer.Test
{
    [TestFixture]
    public class ArrayPairSummerTests
    {
        private NArrayPairSum.ArrayPairSummer sut;

        [SetUp]
        public void Setup()
        {
            sut = new NArrayPairSum.ArrayPairSummer();
        }
        [TestCase(new int[] { }, ExpectedResult = 0, Description = "boundary test")]
        [TestCase(new int[] { 1, 4, 3, 2 }, ExpectedResult = 4, Description = "positive test")]
        [TestCase(new int[] { 6, 2, 6, 5, 1, 2 }, ExpectedResult = 9, Description = "positive test")]
        
        public int ArrayPairSum(int[] nums) => sut.ArrayPairSum(nums);
        [Test]
        public void ArrayPairSumException() {
            NArrayPairSum.ArrayPairSummerException  ex = Assert.Throws<NArrayPairSum.ArrayPairSummerException>(() => sut.ArrayPairSum(new int[] { 0, 1, 2, 3, 4, 5, 6 }));
            Assert.That(ex.Message == ArrayPairSummerException.ArrayLengthMustBeEven().Message);
            //NArrayPairSum.ArrayPairSummerException
        }

    }
}