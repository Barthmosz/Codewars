using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class BasicOperationsTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(BasicOperations.Handle('+', 4, 7), Is.EqualTo(11));
                Assert.That(BasicOperations.Handle('-', 15, 18), Is.EqualTo(-3));
                Assert.That(BasicOperations.Handle('*', 5, 5), Is.EqualTo(25));
                Assert.That(BasicOperations.Handle('/', 49, 7), Is.EqualTo(7));
            });
        }
    }
}
