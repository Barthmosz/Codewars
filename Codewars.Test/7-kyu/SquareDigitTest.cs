using Codewars._7_kyu;
using NUnit.Framework;

namespace Codewars.Test._7_kyu
{
    [TestFixture]
    public class SquareDigitTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(SquareDigits.Handle(9119), Is.EqualTo(811181));
                Assert.That(SquareDigits.Handle(0), Is.EqualTo(0));
            });
        }
    }
}
