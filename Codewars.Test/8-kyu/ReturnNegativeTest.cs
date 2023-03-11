using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
  [TestFixture]
  public class ReturnNegativeTest
  {
    [Test]
    public void HandleTest()
    {
      Assert.That(ReturnNegative.Handle(42), Is.EqualTo(-42));
      Assert.That(ReturnNegative.Handle(-5), Is.EqualTo(-5));
    }
  }
}
