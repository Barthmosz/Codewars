using Codewars._8_kyu;
using NUnit.Framework;
using System.Collections.Generic;

namespace Codewars.Test._8_kyu
{
  [TestFixture]
  public class NumberToStringTest
  {
    private static IEnumerable<TestCaseData> TestCases
    {
      get
      {
        yield return new TestCaseData(67).Returns("67");
        yield return new TestCaseData(79585).Returns("79585");
        yield return new TestCaseData(1 + 2).Returns("3");
        yield return new TestCaseData(1 - 2).Returns("-1");
      }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string HandleTest(int num)
    {
      return NumberToString.Handle(num);
    }
  }
}
