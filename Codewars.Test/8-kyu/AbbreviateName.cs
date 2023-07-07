using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class AbbreviateNameTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(AbbreviateName.Handle("Sam Harris"), Is.EqualTo("S.H"));
                Assert.That(AbbreviateName.Handle("Patrick Feenan"), Is.EqualTo("P.F"));
                Assert.That(AbbreviateName.Handle("Evan Cole"), Is.EqualTo("E.C"));
                Assert.That(AbbreviateName.Handle("P Favuzzi"), Is.EqualTo("P.F"));
                Assert.That(AbbreviateName.Handle("David Mendieta"), Is.EqualTo("D.M"));
            });
        }
    }
}
