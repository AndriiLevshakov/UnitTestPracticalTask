using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Linq;
using Task;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {       
        private TestProgram program;

        [SetUp]
        public void Setup()
        {
            program = new TestProgram();
        }

        [Test]
        public void TestMaxConsecutiveUnequalCharacters()
        {
            string input = "aabcccde";

            int result = program.GetMaxConsecutiveUnequalCharacters(input);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void TestMaxConsecutiveIdenticalLatinLetters()
        {
            string input = "AabbcDDDwe";

            int result = program.MaxConsecutiveIdenticalLatinLetters(input);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void TestMaxConsecutiveIdenticalDigits()
        {
            string input = "Aabb32555578cDDDwe";

            int result = program.MaxConsecutiveIdenticalDigits(input);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void TestMaxConsecutiveUnequalCharacters_WithEmptyString_ReturnsZero()
        {
            string input = "";
            int result = program.GetMaxConsecutiveUnequalCharacters(input);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void TestMaxConsecutiveIdenticalLatinLetters_WithEmptyString_ReturnsZero()
        {
            string input = "";
            int result = program.MaxConsecutiveIdenticalLatinLetters(input);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void TestMaxConsecutiveIdenticalDigits_WithEmptyString_ReturnsZero()
        {
            string input = "";
            int result = program.MaxConsecutiveIdenticalDigits(input);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}