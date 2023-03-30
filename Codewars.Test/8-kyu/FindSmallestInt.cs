using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class FindSmallestIntTest
    {
        [Test]
        [TestCase(new int[] { 78, 56, 232, 12, 11, 43 }, ExpectedResult = 11)]
        [TestCase(new int[] { 78, 56, -2, 12, 8, -33 }, ExpectedResult = -33)]
        public int HandleTest(int[] args)
        {
            return FindSmallestInt.Handle(args);
        }
    }
}
