using System;
using System.Collections.Generic;
using Xunit;

namespace Day2.Tests
{
    public class Tests
    {
        private readonly string[] input = new[]
        {
            "1-3 a: abcde",
            "1-3 b: cdefg",
            "2-9 c: ccccccccc"
        };

        [Fact]
        public void TestOne()
        {
            var parsedInput = Day2.Program.ParseInput(input);
            Day2.PasswordPhilosophy.One(parsedInput).Equals(2);
        }

        [Fact]
        public void TestTwo()
        {
            var parsedInput = Day2.Program.ParseInput(input);
            Day2.PasswordPhilosophy.Two(parsedInput).Equals(1);
        }
    }
}
