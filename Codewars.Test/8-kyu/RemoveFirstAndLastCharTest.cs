using Codewars._8_kyu;
using NUnit.Framework;

namespace Codewars.Test._8_kyu
{
    [TestFixture]
    public class RemoveFirstAndLastCharTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(RemoveFirstAndLastChat.Handle("eloquent"), Is.EqualTo("loquen"));
                Assert.That(RemoveFirstAndLastChat.Handle("country"), Is.EqualTo("ountr"));
                Assert.That(RemoveFirstAndLastChat.Handle("person"), Is.EqualTo("erso"));
                Assert.That(RemoveFirstAndLastChat.Handle("place"), Is.EqualTo("lac"));
                Assert.That(RemoveFirstAndLastChat.Handle("ok"), Is.EqualTo(""));
            });
        }
    }
}
