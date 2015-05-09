using NUnit.Framework;
using NUnit.Mocks;
using NSubstitute;

namespace NUnit
{
    [TestFixture]
    public class TestMoqAccount
    {
        [Test]
        public void TestMethod1() {
            var stubAccount = Substitute.For<IAccount>();
            stubAccount.DoSomething().Returns("x");
            Assert.AreEqual("x", stubAccount.DoSomething());
        }
    }
}
