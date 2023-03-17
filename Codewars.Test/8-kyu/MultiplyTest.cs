using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class MultiplyTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Multiply.Handle(2, 1), Is.EqualTo(2));
                Assert.That(Multiply.Handle(2, 4), Is.EqualTo(8));
            });
        }
    }
}
