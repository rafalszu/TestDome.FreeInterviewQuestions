using System.IO;
using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class DecoratorStreamTests
    {
        [Theory]
        [InlineData("First: ")]
        [InlineData("Second: ")]
        public void PrefixIsPrepended(string prefix)
        {
            byte[] message = new byte[]{0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x2c, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21};
            using (MemoryStream stream = new MemoryStream())
            {
                using (DecoratorStream decoratorStream = new DecoratorStream(stream, prefix))
                {
                    decoratorStream.Write(message, 0, message.Length);
                    stream.Position = 0;

                    var actual = new StreamReader(stream).ReadLine();
                    
                    Assert.Equal(actual, $"{prefix}Hello, world!");
                }
            }
        }

        [Theory]
        [InlineData("First Line: ")]
        [InlineData("Good job: ")]
        public void PrefixIsPrependedOnlyOnce(string prefix)
        {
            byte[] message = new byte[]{0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x2c, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21};
            using (MemoryStream stream = new MemoryStream())
            {
                using (DecoratorStream decoratorStream = new DecoratorStream(stream, prefix))
                {
                    decoratorStream.Write(message, 0, message.Length);

                    // second write
                    decoratorStream.Write(message, 0, message.Length);

                    stream.Position = 0;

                    var actual = new StreamReader(stream).ReadLine();
                    
                    Assert.Equal(actual, $"{prefix}Hello, world!Hello, world!");
                }
            }
        }
    }
}