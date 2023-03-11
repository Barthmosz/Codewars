using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
  [TestFixture]
  public class EvenOrOddTest
  {
    [Test]
    public void HandleTest()
    {
      Assert.Multiple(() =>
      {
        Assert.That(EvenOrOdd.Handle(2), Is.EqualTo("Even"));
        Assert.That(EvenOrOdd.Handle(1), Is.EqualTo("Odd"));
        Assert.That(EvenOrOdd.Handle(0), Is.EqualTo("Even"));
        Assert.That(EvenOrOdd.Handle(7), Is.EqualTo("Odd"));
        Assert.That(EvenOrOdd.Handle(-1), Is.EqualTo("Odd"));
      });
    }
  }
}
