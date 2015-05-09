using CaptchaLibrary;
using NUnit.Framework;
using FluentAssertions;

namespace UnitTestCaptcha
{
    [TestFixture]
    public class StringOperandTest
    {
        [Test]
        public void ToString_WhenValueIs1_ShouldBeOne()
        {
            StringOperand stringOperand = new StringOperand(1);
            stringOperand.String().Should().Be("One");
        }

        [Test]
        public void ToString_WhenValueIs9_ShouldBeNine()
        {
            StringOperand stringOperand = new StringOperand(9);
            stringOperand.String().Should().Be("Nine");
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
