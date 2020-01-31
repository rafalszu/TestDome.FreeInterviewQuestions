using System;
using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class MergeNamesTests
    {
        [Fact]
        public void ReturnsDeduplicatedArray()
        {
            string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
            string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};

            var actual = MergeNames.UniqueNames(names1, names2);
            var expected = new string[] { "Ava", "Emma", "Olivia", "Sophia" };

            Assert.Equal(expected, actual);
        }
    }
}