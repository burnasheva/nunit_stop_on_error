using NUnit.Framework;

namespace SecondProject
{
    [TestFixture]
    public class PassingTests
    {
        [Test]
        public void AlwaysPassingTest()
        {
            Assert.IsTrue(true);
        }
    }
}