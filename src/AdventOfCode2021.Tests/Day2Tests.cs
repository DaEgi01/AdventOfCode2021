using FluentAssertions;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day2Tests
    {
        [Fact]
        public void Part1Test1()
        {
            var input = new[] { "forward 5", "down 5", "forward 8", "up 3", "down 8", "forward 2" };
            var expected = 150;

            var actual = new Day2().Part1(input);

            actual.Should().Be(expected);
        }

        [Fact]
        public void Part2Test1()
        {
            var input = new[] { "forward 5", "down 5", "forward 8", "up 3", "down 8", "forward 2" };
            var expected = 900;

            var actual = new Day2().Part2(input);

            actual.Should().Be(expected);
        }
    }
}
