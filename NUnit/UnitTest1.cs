using NUnit.Framework;
using NUnit;

namespace NUnit.Framework
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Account source = new Account();
            source.Deposit(200m);

            Account destination = new Account();
            destination.Deposit(150m);

            source.TransferFunds(destination, 100m);

            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
            Assert.That(1, Is.InRange(1, 2));
        }
    }
}
