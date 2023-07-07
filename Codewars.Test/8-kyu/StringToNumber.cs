using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class StringToNumberTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(StringToNumber.Handle("1234"), Is.EqualTo(1234));
                Assert.That(StringToNumber.Handle("605"), Is.EqualTo(605));
                Assert.That(StringToNumber.Handle("1405"), Is.EqualTo(1405));
                Assert.That(StringToNumber.Handle("-7"), Is.EqualTo(-7));
            });
        }
    }
}
