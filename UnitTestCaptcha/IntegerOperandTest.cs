using CaptchaLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCaptcha
{
    [TestClass]
    public class IntegerOperandTest
    {
        [TestMethod]
        public void ToString_WhenValueIs1_ShouldBe1()
        {
            IntegerOperand integerOperand = new IntegerOperand(1);
            Assert.AreEqual("1", integerOperand.String());
        }

        [TestMethod]
        public void ToString_WhenValueIs1_ShouldBe9()
        {
            IntegerOperand integerOperand = new IntegerOperand(9);
            Assert.AreEqual("9", integerOperand.String());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRangeException))]
        public void ToString_WhenValueIs10_ShouldThrowInvalidRangeException()
        {
            IntegerOperand integerOperand = new IntegerOperand(10);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRangeException))]
        public void ToString_WhenValueIs0_ShouldThrowInvalidRangeException()
        {
            IntegerOperand integerOperand = new IntegerOperand(0);
        }
    }
}
