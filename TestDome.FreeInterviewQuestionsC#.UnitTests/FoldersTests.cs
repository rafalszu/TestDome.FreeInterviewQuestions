using System.Collections.Generic;
using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class FoldersTests
    {
        [Fact]
        public void ReturnsTwoFoldersStartingWithU()
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                    "<folder name=\"program files\">" +
                        "<folder name=\"uninstall information\" />" +
                    "</folder>" +
                    "<folder name=\"users\" />" +
                "</folder>";

            var actual = Folders.FolderNames(xml, 'u');
            
            IEnumerable<string> expected = new List<string> {
                "uninstall information",
                "users"
            };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsEmptyCollectionsWhenSearchingForFoldersStartingWithA()
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                    "<folder name=\"program files\">" +
                        "<folder name=\"uninstall information\" />" +
                    "</folder>" +
                    "<folder name=\"users\" />" +
                "</folder>";

            var actual = Folders.FolderNames(xml, 'a');

            Assert.Empty(actual);
        }
    }
}