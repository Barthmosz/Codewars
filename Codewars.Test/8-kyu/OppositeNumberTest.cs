using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class OppositeNumberTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.That(OppositeNumber.Handle(-1), Is.EqualTo(1));
        }
    }
}
