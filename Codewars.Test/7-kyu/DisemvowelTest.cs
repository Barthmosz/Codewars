using Codewars._7_kyu;
using NUnit.Framework;

namespace Codewars.Test._7_kyu
{
    [TestFixture]
    public class DisemvowelTest
    {
        [Test]
        public void HandleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Disemvowel.Handle("This website is for losers LOL!"), Is.EqualTo("Ths wbst s fr lsrs LL!"));
                Assert.That(Disemvowel.Handle("No offense but,\nYour writing is among the worst I've ever read"), Is.EqualTo("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd"));
                Assert.That(Disemvowel.Handle("What are you, a communist?"), Is.EqualTo("Wht r y,  cmmnst?"));
            });
        }
    }
}
