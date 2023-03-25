using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class SummationTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Summation.Handle(1), Is.EqualTo(1));
                Assert.That(Summation.Handle(8), Is.EqualTo(36));
                Assert.That(Summation.Handle(22), Is.EqualTo(253));
                Assert.That(Summation.Handle(100), Is.EqualTo(5050));
                Assert.That(Summation.Handle(213), Is.EqualTo(22791));
            });
        }
    }
}
