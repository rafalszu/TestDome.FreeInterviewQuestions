using Xunit;
using static TestDome.FreeInterviewQuestionsC.Account;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class AccountTests
    {
        [Fact]
        public void WriterDoesntHaveFlagDelete()
        {
            Assert.Equal(false, Access.Writer.HasFlag(Access.Delete));
        }

        [Fact]
        public void OwnerHasWriterFlag()
        {
            Assert.Equal(true, Access.Owner.HasFlag(Access.Writer));
        }

        [Fact]
        public void EditorDoesntHaveFlagSubmit()
        {
            Assert.Equal(false, Access.Editor.HasFlag(Access.Submit));
        }
    }
}