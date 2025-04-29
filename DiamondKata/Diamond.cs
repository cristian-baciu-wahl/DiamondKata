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

            int size = input - 'A';

            var lines = new List<string>();

            // Build top + middle
            for (int i = 0; i <= size; i++)
                lines.Add(GenerateLine(i, size));

            // Build bottom half 
            for (int i = size - 1; i >= 0; i--)
                lines.Add(GenerateLine(i, size));

            // Append everything
            return string.Join("\n", lines) + "\n";
        }

        private static string GenerateLine(int i, int size)
        {
            char letter = (char)('A' + i);

            int outerSpaces = size - i;
            int innerSpaces = i == 0 ? 0 : i * 2 - 1;

            var outer = new string(' ', outerSpaces);
            var inner = new string(' ', innerSpaces);

            return i == 0
                ? outer + letter + outer
                : outer + letter + inner + letter + outer;
        }
    }
}
