using System.Threading;
using NUnit.Framework;

namespace SecondProject
{
    [TestFixture]
    public class PassingTests
    {
        [Test]
        public void AlwaysPassingTest()
        {
            Thread.Sleep(30000);
            Assert.IsTrue(true);
        }
    }
}