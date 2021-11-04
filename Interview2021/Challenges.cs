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
        public void return_letter_count()
        {
            var resultOne = Challenges.GetLetterCount("aaaabbbcca");
            resultOne.Should().Be("4a3b2c1a");

            var resultTwo = Challenges.GetLetterCount("ddddddddddd");
            resultTwo.Should().Be("11d");
        }

        /// <summary>
        /// Write unit test for the object that is returned.
        /// </summary>
        [TestMethod]
        public void CallApi()
        {
            var result = Challenges.CallApi("apple");
        }
    }

    public static class Challenges
    {
        /// <summary>
        /// Count the number of times a letter occurs. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Letter Count.</returns>
        public static string GetLetterCount(string input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The number which appears most often in a set of numbers.
        /// Example: in { 6, 3, 9, 6, 6, 5, 9, 3} the Mode is 6(it occurs most often).
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>The mode.</returns>
        public static int[] GetMode(params int[] numbers)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// for json https://dictionaryapi.dev/
        /// for xml http://api.nbp.pl/api/cenyzlota/last/{topCount}
        /// call one of the two APIs and cast the response to a strongly typed object 
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Strongly typed object from api response.</returns>
        public static object CallApi(string word)
        {
            return null;
        }
    }
}