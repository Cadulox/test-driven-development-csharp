using System.Collections.Generic;

namespace NumberConverter
{
    public class RomanNumberConverter
    {
        public RomanNumberConverter()
        {
        }

        private static Dictionary<char, int> _table =
            new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

        public int Converts(string romanNumber)
        {
            int accumulator = 0;
            int lastNeighborRight = 0;
            for (int i = romanNumber.Length - 1; i >= 0; i--)
            {
                // Get the integer for the current symbol
                int current = _table[romanNumber[i]];

                // If the one on the right is smaller, we will multiply it
                // by -1 to make it negative
                int multiplicator = 1;
                if(current < lastNeighborRight)
                {
                    multiplicator = -1;
                }

                accumulator += current * multiplicator;

                // Update the Last Neighbor Right
                lastNeighborRight = current;
            }
            return accumulator;
        }
    }
}
