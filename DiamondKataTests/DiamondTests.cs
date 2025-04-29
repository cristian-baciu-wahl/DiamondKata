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

        [Fact]
        public void Generate_WithB_ReturnsExpectedDiamond()
        {
            var expected =
                " A \n" +
                "B B\n" +
                " A \n";

            var result = Diamond.Generate('B');
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Generate_WithD_ReturnsDiamondWithDefaultSpacing()
        {
            var expected =
                "   A   \n" +
                "  B B  \n" +
                " C   C \n" +
                "D     D\n" +
                " C   C \n" +
                "  B B  \n" +
                "   A   \n";

            var result = Diamond.Generate('D');
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Generate_WithDAndCustomSpacer_ReturnsDiamondWithCustomSpacer()
        {
            var expected =
                "___A___\n" +
                "__B_B__\n" +
                "_C___C_\n" +
                "D_____D\n" +
                "_C___C_\n" +
                "__B_B__\n" +
                "___A___\n";

            var result = Diamond.Generate('D', '_');
            Assert.Equal(expected, result);
        }
    }
}
