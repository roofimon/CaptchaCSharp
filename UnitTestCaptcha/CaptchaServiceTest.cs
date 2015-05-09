using NUnit.Framework;
using CaptchaLibrary;
using NSubstitute;
using FluentAssertions;

namespace UnitTestCaptcha
{
    [TestFixture]
    class CaptchaServiceTest
    {
        [Test]
        public void GetCaptcha_1PlusNine_WhenInputIs1119()
        {
            var stubRandomizer = Substitute.For<IRandomizer>();
            stubRandomizer.Pattern().Returns(1);
            stubRandomizer.Operand().Returns(1);
            stubRandomizer.Operator().Returns(1);

            CaptchaService captchaService = new CaptchaService();
            captchaService.SetRandomizer(stubRandomizer);
            var captcha = captchaService.GetCaptcha();
            captcha.ToString().Should().Be("One + 1");
        }
    }
}
