using NUnit.Framework;

namespace PadawansTask4.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase("abracadabra", ExpectedResult = 5)]
        [TestCase("ab rac adabra", ExpectedResult = 5)]
        [TestCase("sprppr", ExpectedResult = 0)]
        [TestCase("aaa", ExpectedResult = 3)]
        [TestCase("aaAa", ExpectedResult = 4)]
        public int GetVowelCountTests(string source) => StringHelper.GetVowelCount(source);
    }
}