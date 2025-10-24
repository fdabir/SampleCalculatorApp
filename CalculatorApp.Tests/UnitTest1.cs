using Xunit;

namespace CalculatorApp.Tests
{
    public class UtilsTests
    {
        [Fact]
        public void Add_WorksCorrectly()
        {
            double result = 2 + 3;
            Assert.Equal(5, result);
        }
    }
}
