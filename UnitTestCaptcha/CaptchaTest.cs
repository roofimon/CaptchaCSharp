using System;
using CaptchaLibrary;
using NUnit.Framework;

namespace UnitTestCaptcha {
    [TestFixture]
    public class CaptchaTest {
        private int STRING_INTEGER_PATTERN = 1;
        private int INTEGER_STRING_PATTERN = 2;
        private int PLUS_SIGN = 1;
        private int EIGHT = 8;
        [Test]
        public void Operator_ShouldBePlus_OperatorValueIs_1() {
            Captcha captcha = new Captcha(INTEGER_STRING_PATTERN, EIGHT, 1, EIGHT);
            Assert.AreEqual("+", captcha.Operator().String());
        }
        [Test]
        public void RightOperand_ShouldBeOne_IntegerStringPatternWith_RightOperandValueIs_1() {
            Captcha captcha = new Captcha(INTEGER_STRING_PATTERN, EIGHT, PLUS_SIGN, 1);
            Assert.AreEqual("One", captcha.RightOperand().String());
        }
        [Test]
        public void RightOperand_ShouldBe1_StringIntegerPatternWith_RightOperandValueIs_1() {
            Captcha captcha = new Captcha(STRING_INTEGER_PATTERN, EIGHT, PLUS_SIGN, 1);
            Assert.AreEqual("1", captcha.RightOperand().String());
        }
        [Test]
        public void RightOperand_ShouldBe9_StringIntegerPatternWith_RightOperandValueIs_9() {
            Captcha captcha = new Captcha(STRING_INTEGER_PATTERN, EIGHT, PLUS_SIGN, 9);
            Assert.AreEqual("9", captcha.RightOperand().String());
        }
        [Test]
        public void LeftOperand_ShouldBe9_IntergerStringPatternWith_LeftOperandValueIs_9() {
            Captcha captcha = new Captcha(INTEGER_STRING_PATTERN, 9, PLUS_SIGN, EIGHT);
            Assert.AreEqual("9", captcha.LeftOperand().String());
        }
        [Test]
        public void LeftOperand_ShouldBeOne_StringIntergerPatternWith_LeftOperandValueIs_1() {
            Captcha captcha = new Captcha(STRING_INTEGER_PATTERN, 1, PLUS_SIGN, EIGHT);
            Assert.AreEqual("One", captcha.LeftOperand().String());
        }
        [Test]
        public void LeftOperand_ShouldBeNine_StringIntergerPatternWith_LeftOperandValueIs_9() {
            Captcha captcha = new Captcha(STRING_INTEGER_PATTERN, 9, PLUS_SIGN, EIGHT);
            Assert.AreEqual("Nine", captcha.LeftOperand().String());
        }
    }
}
