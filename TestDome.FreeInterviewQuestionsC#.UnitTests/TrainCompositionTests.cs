using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class TrainCompositionTests
    {
        [Fact]
        public void ReturnsLastDetachedWagonFromRight()
        {
            TrainComposition tree = new TrainComposition();
            tree.AttachWagonFromLeft(7);
            tree.AttachWagonFromLeft(13);
            var actual = tree.DetachWagonFromRight();

            Assert.Equal(7, actual);
        }

        [Fact]
        public void ReturnsLastDetachedWagonFromLeftInCorrectOrder()
        {
            TrainComposition tree = new TrainComposition();
            tree.AttachWagonFromLeft(7);
            tree.AttachWagonFromLeft(13);

            tree.DetachWagonFromRight();
            var actual = tree.DetachWagonFromLeft();

            Assert.Equal(13, actual);
        }
    }
}