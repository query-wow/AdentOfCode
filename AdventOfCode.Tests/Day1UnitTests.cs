using AdentOfCode.Day1;

namespace AdventOfCode.Tests
{
    public class Day1UnitTests
    {

        [Fact]
        public void Part1Test()
        {
            string[] lines =
            [
                "1abc2",
                "pqr3stu8vwx",
                "a1b2c3d4e5f",
                "treb7uchet"
            ];

            Assert.True(Trebuchet.Part1.Solver(lines) == 142);
        }

        [Fact]
        public void Part2Test()
        {
            string[] lines =
            [
                "two1nine",
                "eightwothree",
                "abcone2threexyz",
                "xtwone3four",
                "4nineeightseven2",
                "zoneight234",
                "7pqrstsixteen"
            ];

            Assert.True(Trebuchet.Part2.Solver(lines) == 281);
        }
    }
}