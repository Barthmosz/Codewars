using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class BoolToWordTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(BoolToWord.Handle(true), Is.EqualTo("Yes"));
                Assert.That(BoolToWord.Handle(false), Is.EqualTo("No"));
            });
        }
    }
}
