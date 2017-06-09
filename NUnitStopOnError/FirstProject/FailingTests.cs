using NUnit.Framework;

namespace FirstProject
{
    [TestFixture]
    public class FailingTests
    {
        [Test]
        public void AlwaysFailingTest()
        {
            Assert.IsFalse(true);
        }

        [Test]
        public void ShouldPassTest()
        {
            Assert.IsTrue(true);
        }
    }
}