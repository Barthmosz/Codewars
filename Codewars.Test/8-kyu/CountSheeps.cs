using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class CountSheepsTest
    {
        [Test]
        public void HandleTest()
        {
            bool[] sheeps = new[] { true, false, true };

            Assert.That(CountSheeps.Handle(sheeps), Is.EqualTo(2));
        }
    }
}
