using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class CenturyFromYearTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(CenturyFromYear.Handle(1705), Is.EqualTo(18));
                Assert.That(CenturyFromYear.Handle(1900), Is.EqualTo(19));
                Assert.That(CenturyFromYear.Handle(1601), Is.EqualTo(17));
                Assert.That(CenturyFromYear.Handle(2000), Is.EqualTo(20));
            });
        }
    }
}
