using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class KeepHydratedTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(KeepHydrated.Handle(2), Is.EqualTo(1));
                Assert.That(KeepHydrated.Handle(1.4), Is.EqualTo(0));
                Assert.That(KeepHydrated.Handle(12.3), Is.EqualTo(6));
                Assert.That(KeepHydrated.Handle(0.82), Is.EqualTo(0));
                Assert.That(KeepHydrated.Handle(11.8), Is.EqualTo(5));
                Assert.That(KeepHydrated.Handle(1787), Is.EqualTo(893));
                Assert.That(KeepHydrated.Handle(0), Is.EqualTo(0));
            });
        }
    }
}
