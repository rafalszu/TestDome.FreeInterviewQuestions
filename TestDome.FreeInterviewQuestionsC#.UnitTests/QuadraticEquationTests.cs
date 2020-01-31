using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class QuadraticEquationTests
    {
        [Fact]
        public void ReturnsCorrectRoots()
        {
            var actual = QuadraticEquation.FindRoots(2, 10, 8);

            Assert.Equal<double>(-1D, actual.Item1);
            Assert.Equal<double>(-4D, actual.Item2);
        }
    }
}