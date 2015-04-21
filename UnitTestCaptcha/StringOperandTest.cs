using CaptchaLibrary;
using NUnit.Framework;
namespace UnitTestCaptcha
{
    [TestFixture]
    public class StringOperandTest
    {
        [Test]
        public void ToString_WhenValueIs1_ShouldBeOne()
        {
            StringOperand stringOperand = new StringOperand(1);
            Assert.AreEqual("One", stringOperand.String());
        }

        [Test]
        public void ToString_WhenValueIs9_ShouldBeNine()
        {
            StringOperand stringOperand = new StringOperand(9);
            Assert.AreEqual("Nine", stringOperand.String());
        }

        [Test]
        [ExpectedException(typeof(InvalidRangeException))]
        public void ToString_WhenValueIs10_ShouldThrow_InvalidRangeException()
        {
            StringOperand stringOperand = new StringOperand(10);
        }

        [Test]
        [ExpectedException(typeof(InvalidRangeException))]
        public void ToString_WhenValueIs0_ShouldThrow_InvalidRangeException()
        {
            StringOperand stringOperand = new StringOperand(0);
        }
    }
}
