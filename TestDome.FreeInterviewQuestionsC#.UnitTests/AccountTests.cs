using Xunit;
using static TestDome.FreeInterviewQuestionsC.Account;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class AccountTests
    {
        [Fact]
        public void WriterDoesntHaveFlagDelete()
        {
            Assert.False(Access.Writer.HasFlag(Access.Delete));
        }

        [Fact]
        public void OwnerHasWriterFlag()
        {
            Assert.True(Access.Owner.HasFlag(Access.Writer));
        }

        [Fact]
        public void EditorDoesntHaveFlagSubmit()
        {
            Assert.True(Access.Editor.HasFlag(Access.Submit));
        }
    }
}