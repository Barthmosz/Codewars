using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class ReversedStringsTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.That(ReversedStrings.Handle("world"), Is.EqualTo("dlrow"));
        }
    }
}
