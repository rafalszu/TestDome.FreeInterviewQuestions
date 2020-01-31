using System.Collections.Generic;
using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class TwoSumTests
    {
        [Fact]
        public void FindsAPair()
        {
            var list = new List<int>() { 3, 1, 5, 7, 5, 9 };
            var sum = 10;

            var actual = TwoSum.FindTwoSum(list, sum);

            Assert.Equal(7, actual.Item1);

            Assert.Equal(3, actual.Item2);
        }

        [Fact]
        public void ReturnsNullIfPairNotFound()
        {
            var list = new List<int>() { 3, 1, 5, 7, 5, 9 };
            var sum = 15;

            var actual = TwoSum.FindTwoSum(list, sum);

            Assert.Null(actual);
        }
    }
}