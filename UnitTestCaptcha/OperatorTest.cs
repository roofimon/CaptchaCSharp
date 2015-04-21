using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaptchaLibrary;

namespace UnitTestCaptcha
{
    [TestClass]
    public class OperatorTest
    {
        [TestMethod]
        public void String_ShouldBePlus_WhenInputIs1()
        {
            Operator oper = new Operator(1);
            Assert.AreEqual("+", oper.String());
        }
        [TestMethod]
        public void String_ShouldBeMultiply_WhenInputIs2()
        {
            Operator oper = new Operator(2);
            Assert.AreEqual("*", oper.String());
        }
        [TestMethod]
        public void String_ShouldBeMinus_WhenInputIs3()
        {
            Operator oper = new Operator(3);
            Assert.AreEqual("-", oper.String());
        }
    }
}
