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
        //[TestCase(5, 4, ExpectedResult =new int[] { 0 , 3 }, Description = "boundary test")]
        //[TestCase(5, 6, ExpectedResult = new int[]  { 1, 0 }, Description = "boundary test")]
        //public new int[] SplitIndex(int maxIndex, int index)
        //{var ret= sut.SplitIndex(maxIndex, index);
        //    return new int[] { ret.x, ret.y };
        //}
        [TestCase(new int[] { 1, 2, 3, 3, 4 },1, ExpectedResult = 0, Description = "positive test")]
        [TestCase(new int[] { 1, 2, 3, 3, 4 }, 4, ExpectedResult = 4, Description = "positive test")]
        [TestCase(new int[] { 1, 2, 3, 3, 4 }, 3, ExpectedResult =2, Description = "positive test")]
        [TestCase(new int[] { 1, 2, 3, 3, 4 }, 6, ExpectedResult = -1, Description = "negativeive test")]
        [TestCase(new int[] { 2, 2, 3, 3, 4 }, 1, ExpectedResult = -1, Description = "negativeive test")]
        [TestCase(new int[] { 1, 1, 3, 3, 4 }, 2, ExpectedResult = -1, Description = "negativeive test")]
        public int targetIndex(int[] nums, int target)=>sut.targetIndex(nums,0, nums.Length-1, target);
 
        [TestCase(new int[] { 2, 7, 11, 15 },9, ExpectedResult = new int[] { 1, 2 }, Description = "positive test")]
        [TestCase(new int[] { 2, 3, 4 }, 6, ExpectedResult = new int[] { 1, 3 }, Description = "positive test")]
        [TestCase(new int[] { -1, 0 }, -1, ExpectedResult = new int[] { 1, 2 }, Description = "positive test")]
        [TestCase(new int[] { 0, 0, 3, 4 }, 0, ExpectedResult = new int[] { 1, 2 }, Description = "positive test")]
        public int[] TwoSum(int[] nums, int target)
        {
            return sut.TwoSum(nums, target);
        }
    }
    
}