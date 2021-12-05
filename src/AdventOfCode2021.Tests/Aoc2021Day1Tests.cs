using FluentAssertions;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Aoc2021Day1Tests
    {
        [Fact]
        public void Part1Test1()
        {
            var sut = new Aoc2021Day1();
            var input = new[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            var expected = 7;

            var actual = sut.Part1(input);

            actual.Should().Be(expected);
        }

        [Fact]
        public void Part2Test1()
        {
            var sut = new Aoc2021Day1();
            var input = new[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            var expected = 5;

            var actual = sut.Part2(input, 3);

            actual.Should().Be(expected);
        }
    }
}