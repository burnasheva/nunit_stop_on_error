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
    }
}