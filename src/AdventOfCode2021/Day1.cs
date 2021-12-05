namespace AdventOfCode2021
{
    public class Day1
    {
        public int Part1(int[] input)
        {
            int result = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] < input[i])
                {
                    result += 1;
                }
            }

            return result;
        }

        public int Part2(int[] input, int windowSize)
        {
            int result = 0;

            for (int i = windowSize; i < input.Length; i++)
            {
                if (GetWindowSum(input, windowSize, i - 1) < GetWindowSum(input, windowSize, i))
                {
                    result += 1;
                }
            }

            return result;
        }

        private int GetWindowSum(int[] input, int windowSize, int index)
        {
            return input[index - windowSize + 1]
                + input[index - windowSize + 2]
                + input[index - windowSize + 3];
        }
    }
}
