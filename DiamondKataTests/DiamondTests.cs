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
    }
}
