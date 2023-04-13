using Codewars._7_kyu;
using NUnit.Framework;

namespace Codewars.Test._7_kyu
{
    [TestFixture]
    public class VowelCountTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.That(VowelCount.Handle("abracadabra"), Is.EqualTo(5));
        }
    }
}
