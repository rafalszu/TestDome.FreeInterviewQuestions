using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class UserInputTests
    {
        [Fact]
        public void NumericInputContainsOnlyDigits()
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');

            Assert.Equal("10", input.GetValue());
        }

        [Fact]
        public void TextInputContainsDigitsAndLetters()
        {
            TextInput input = new TextInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');

            Assert.Equal("1a0", input.GetValue());
        }
    }
}