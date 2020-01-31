using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class AlertDAOTests
    {
        [Fact]
        public void AlertDaoImplementsIAlertDAO()
        {
            AlertDAO dao = new AlertDAO();
            Assert.IsAssignableFrom<IAlertDAO>(dao);
        }
    }
}