using System;

namespace TestDome.FreeInterviewQuestionsC
{
    /*
    User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.

    Implement the class TextInput that contains:

    Public method void Add(char c) - adds the given character to the current value
    Public method string GetValue() - returns the current value
    Implement the class NumericInput that:

    Inherits TextInput
    Overrides the Add method so that each non-numeric character is ignored
    */

    public class TextInput 
    {
        private string value;

        public virtual void Add(char c)
        {
            value += c;
        }

        public string GetValue()
        {
            return value;
        }
    }

    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if(char.IsNumber(c))
                base.Add(c);
        }
    }

    public class UserInput
    {
        public static void Execute(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }
    }
}