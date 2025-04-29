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
            {
                char letter = (char)('A' + i);

                int outerSpaces = size - i;
                int innerSpaces = i == 0 ? 0 : i * 2 - 1;

                var outer = new string(' ', outerSpaces);
                var inner = new string(' ', innerSpaces);

                var line = i == 0
                    ? outer + letter + outer
                    : outer + letter + inner + letter + outer;

                lines.Add(line);
            }

            // Build bottom half 
            for (int i = size - 1; i >= 0; i--)
            {
                char letter = (char)('A' + i);

                int outerSpaces = size - i;
                int innerSpaces = i == 0 ? 0 : i * 2 - 1;

                var outer = new string(' ', outerSpaces);
                var inner = new string(' ', innerSpaces);

                var line = i == 0
                     ? outer + letter + outer
                     : outer + letter + inner + letter + outer;

                lines.Add(line);
            }

            // Append everything
            return string.Join("\n", lines) + "\n";
        }
    }
}
