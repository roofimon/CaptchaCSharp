using CaptchaLibrary;
using NUnit.Framework;

namespace UnitTestCaptcha
{
    [TestFixture]
    public class IntegerOperandTest
    {
        [Test]
        public void ToString_WhenValueIs1_ShouldBe1()
        {
            IntegerOperand integerOperand = new IntegerOperand(1);
            Assert.AreEqual("1", integerOperand.String());
        }

        [Test]
        public void ToString_WhenValueIs1_ShouldBe9()
        {
            IntegerOperand integerOperand = new IntegerOperand(9);
            Assert.AreEqual("9", integerOperand.String());
        }

        [Test]
        [ExpectedException(typeof(InvalidRangeException))]
        public void ToString_WhenValueIs10_ShouldThrowInvalidRangeException()
        {
            IntegerOperand integerOperand = new IntegerOperand(10);
        }

        [Test]
        [ExpectedException(typeof(InvalidRangeException))]
        public void ToString_WhenValueIs0_ShouldThrowInvalidRangeException()
        {
            IntegerOperand integerOperand = new IntegerOperand(0);
        }
    }
}
