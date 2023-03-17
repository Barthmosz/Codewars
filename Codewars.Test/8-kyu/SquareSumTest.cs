using Codewars._8_kyu;
using NUnit.Framework;
using System.Collections.Generic;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class SquareSumTest
    {
        private static IEnumerable<TestCaseData> SampleTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 2 }).Returns(9);
                yield return new TestCaseData(new int[] { 1, 2 }).Returns(5);
                yield return new TestCaseData(new int[] { 5, 3, 4 }).Returns(50);
                yield return new TestCaseData(new int[] { }).Returns(0);
            }
        }

        [Test, TestCaseSource(nameof(SampleTestCases))]
        public int HandleTest(int[] n) => SquareSum.Handle(n);
    }
}
