using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
  [TestFixture]
  public class StringRepeatTest
  {
    [Test]
    public void HandleTest()
    {
      Assert.Multiple(() =>
      {
        Assert.That(StringRepeat.Handle(3, "*"), Is.EqualTo("***"));
        Assert.That(StringRepeat.Handle(5, "#"), Is.EqualTo("#####"));
        Assert.That(StringRepeat.Handle(2, "ha "), Is.EqualTo("ha ha "));
      });
    }
  }
}
