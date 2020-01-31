using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class AccountTestTests
    {
        private double epsilon = 1e-6;

        // testdome answer
        // [Test]
        // public void AccountCannotHaveNegativeOverdraftLimit()
        // {
        //     Account account = new Account(-20);
            
        //     Assert.AreEqual(0, account.OverdraftLimit, epsilon);
        // }

        // xunit test
        [Fact]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            AccountTest account = new AccountTest(-20);
            
            Assert.Equal(0, account.OverdraftLimit);
        }

        // testdome answer
        // [Test]
        // public void DepositDoesntAcceptNegativeNumber()
        // {
        //     Account account = new Account(10);
        //     var actual = account.Deposit(-1);
        //     Assert.AreEqual(false, actual);
        // }

        // xunit test
        [Fact]
        public void DepositDoesntAcceptNegativeNumber()
        {
            AccountTest account = new AccountTest(10);
            var actual = account.Deposit(-1);
            Assert.Equal(false, actual);
        }

        // testdome answer
        // [Test]
        // public void WithdrawDoesntAcceptNegativeNumber()
        // {
        //     Account account = new Account(10);
        //     var actual = account.Withdraw(-5);
        //     Assert.AreEqual(false, actual);
        // }

        // xunit test
        [Fact]
        public void WithdrawDoesntAcceptNegativeNumber()
        {
            AccountTest account = new AccountTest(10);
            var actual = account.Withdraw(-5);
            Assert.Equal(false, actual);
        }

        // testdome asnwer
        // [Test]
        // public void AccountCantOverstepOverdraftLimit()
        // {
        //     Account account = new Account(10);
        //     account.Deposit(20);

        //     var actual = account.Withdraw(120);

        //     Assert.AreEqual(false, actual);
        // }

        // xunit test
        [Fact]
        public void AccountCantOverstepOverdraftLimit()
        {
            AccountTest account = new AccountTest(10);
            account.Deposit(20);

            var actual = account.Withdraw(120);

            Assert.Equal(false, actual);
        }

        // testdome answer
        // [Test]
        // public void DepositsAndWithdrawsCorrectAmount()
        // {
        //     Account account = new Account(10); // balance 0
        //     account.Deposit(20);
        //     Assert.AreEqual(20D, account.Balance);

        //     account.Withdraw(10);
        //     Assert.AreEqual(10D, account.Balance);
        // }

        // xunit test
        [Fact]
        public void DepositsAndWithdrawsCorrectAmount()
        {
            AccountTest account = new AccountTest(10); // balance 0
            account.Deposit(20);
            Assert.Equal(20D, account.Balance);

            account.Withdraw(10);
            Assert.Equal(10D, account.Balance);
        }

        // testdome answer
        // [Test]
        // public void WithdrawsCorrectAmount()
        // {
        //     Account account = new Account(10); // balance 0
        //     account.Deposit(20);
        //     account.Withdraw(10);

        //     Assert.AreEqual(10D, account.Balance);
        // }

        // xunit test
        [Fact]
        public void WithdrawsCorrectAmount()
        {
            AccountTest account = new AccountTest(10); // balance 0
            account.Deposit(20);
            account.Withdraw(10);

            Assert.Equal(10D, account.Balance);
        }

        // testdome answer
        // [Test]
        // public void WithdrawReturnsTrueWhenSuccessful()
        // {
        //     Account account = new Account(10);

        //     account.Deposit(20);

        //     var actual = account.Withdraw(5);
        //     Assert.AreEqual(true, actual);
        // }

        // xunit test
        [Fact]
        public void WithdrawReturnsTrueWhenSuccessful()
        {
            AccountTest account = new AccountTest(10);

            account.Deposit(20);

            var actual = account.Withdraw(5);
            Assert.Equal(true, actual);
        }

        // testdome answer
        // [Test]
        // public void DepositReturnsTrueWhenSuccessful()
        // {
        //     Account account = new Account(10);

        //     var actual = account.Deposit(10);
        //     Assert.AreEqual(true, actual);
        // }

        // xunit test
        [Fact]
        public void DepositReturnsTrueWhenSuccessful()
        {
            AccountTest account = new AccountTest(10);

            var actual = account.Deposit(10);
            Assert.Equal(true, actual);
        }

    }
}