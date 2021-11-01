using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview2021
{
    [TestClass]
    public class ChallengesShould
    {
        [TestMethod]
        public void return_mode()
        {
            var results = Challenges.GetMode(1, 2, 3, 3, 4, 4, 5);

            results.Length.Should().Be(2);

            results[0].Should().Be(3);
            results[1].Should().Be(4);
        }

        [TestMethod]
        public void return_encoded_string()
        {
            var result = Challenges.GetEncodedString("aaaabbbcca");

            result.Should().Be("4a3b2c1a");
        }
    }

    public static class Challenges
    {
        public static string GetEncodedString(string input)
        {
            throw new NotImplementedException();
        }

        public static int[] GetMode(params int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}