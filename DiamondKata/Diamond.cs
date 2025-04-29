namespace DiamondKata
{
    public static class Diamond
    {
        public static string Generate()
        {
            return "A\n";
        }

        public static string Generate(char input)
        {
            if (input < 'A' || input > 'Z')
                throw new ArgumentException("Invalid character");

            if (input == 'A')
                return "A\n";

            return Generate();
        }
    }
}
