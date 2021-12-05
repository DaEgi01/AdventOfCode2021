using FluentAssertions;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day1Tests
    {
        [Fact]
        public void Part1Test1()
        {
            Day1 sut = new();
            int[] input = { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            int expected = 7;

            int actual = sut.Part1(input);

            actual.Should().Be(expected);
        }

        [Fact]
        public void Part2Test1()
        {
            Day1 sut = new();
            int[] input = { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            int expected = 5;

            int actual = sut.Part2(input, 3);

            actual.Should().Be(expected);
        }
    }
}