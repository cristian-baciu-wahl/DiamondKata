using DiamondKata;

namespace DiamondKataTests
{
    public class DiamondTests
    {
        [Fact]
        public void Generate_ReturnsSingleLineA()
        {
            var result = Diamond.Generate();

            Assert.Equal("A\n", result);
        }

        [Fact]
        public void Generate_WithA_ReturnsSingleLineA()
        {
            var result = Diamond.Generate('A');

            Assert.Equal("A\n", result);
        }

        [Theory]
        [InlineData('1')]
        [InlineData('a')]
        [InlineData('*')]
        [InlineData(' ')]
        public void Generate_WithInvalidChar_ThrowsArgumentException(char input)
        {
            Assert.Throws<ArgumentException>(() => Diamond.Generate(input));
        }
    }
}
