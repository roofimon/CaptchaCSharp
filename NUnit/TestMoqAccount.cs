using NUnit.Framework;
using Moq;

namespace NUnit
{
    [TestFixture]
    public class TestMoqAccount
    {
        [Test]
        public void TestMethod1() { 
            var mock = new Mock<IAccount>();
            mock.Setup(foo => foo.DoSomething()).Returns("x");
            Assert.AreEqual("x", mock.Object.DoSomething());
        }
    }
}
