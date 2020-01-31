using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void SelectedNodeContainsChildWithGivenValue()
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Assert.Equal(true, BinarySearchTree.Contains(n2, 3));

            Assert.Equal(true, BinarySearchTree.Contains(n3, 3));

            Assert.Equal(false, BinarySearchTree.Contains(n1, 3));
        }

        [Fact]
        public void CanTraverseAllTheWayDown()
        {
            Node n0 = new Node(0, null,  null);
            Node n1 = new Node(1, n0, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            var actual = BinarySearchTree.Contains(n2, 0);
            Assert.Equal(true, actual);
        }
    }
}