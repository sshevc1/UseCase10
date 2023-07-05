using Xunit;
using System.Text.RegularExpressions;
using UseCase10;

namespace UseCase10Tests
{

    public class TestClass
    {
        [Theory]
        [InlineData("abcABC123!@#", 20, true)]
        [InlineData("abcabc123!@#", 20, false)]
        [InlineData("abcABCabc!@#", 20, false)]
        [InlineData("abcABC123abc", 20, false)]
        [InlineData("abcABC123!@#", 10, false)]
        [InlineData(" ", 20, false)]
        [InlineData("abcABC123!@#", 14, true)]
        [InlineData("abcABC 123!@#", 20, false)]
        [InlineData("aA1!", 4, true)]
        [InlineData("a", 1, false)]
        public void TestValidateString(string input, int maxLength, bool expectedResult)
        {
            // Arrange
            var stringEvaluator = new StringEvaluator();

            // Act
            bool result = stringEvaluator.ValidateString(input, maxLength);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }

}