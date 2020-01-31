using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class SortedSearchTests
    {
        [Fact]
        public void ReturnsTwoItemsWhenSearchedValueIsNotPresent()
        {
            var actual = SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4);

            Assert.Equal(2, actual);
        }

        [Fact]
        public void ReturnsTwoItemsWhenSearchedValueIsPresent()
        {
            var actual = SortedSearch.CountNumbers(new int[] { 1, 3, 4, 5, 7 }, 4);

            Assert.Equal(2, actual);
        }

        [Fact]
        public void ReturnsAllItemsWhenSearchedValueIsHigherThanLastArrayItem()
        {
            var actual = SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 14);

            Assert.Equal(4, actual);
        }
    }
}