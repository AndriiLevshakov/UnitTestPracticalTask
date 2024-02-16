using System;
using System.Linq;
using Task;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {       
        [Test]
        public void TestMaxConsecutiveUnequalCharacters()
        {
            TestProgram program = new TestProgram();
            string input = "aabcccde";

            int result = program.GetMaxConsecutiveUnequalCharacters(input);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestMaxConsecutiveIdenticalLatinLetters()
        {
            TestProgram program = new TestProgram();
            string input = "AabbcDDDwe";

            int result = program.MaxConsecutiveIdenticalLatinLetters(input);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void TestMaxConsecutiveIdenticalDigits()
        {
            TestProgram program = new TestProgram();
            string input = "Aabb32555578cDDDwe";

            int result = program.MaxConsecutiveIdenticalDigits(input);

            Assert.That(result, Is.EqualTo(4));
        }
    }
}