using NUnit.Framework;
using CaptchaLibrary;

namespace UnitTestCaptcha
{
    [TestFixture]
    class RandomizerTest
    {
        [Test]
        public void OperandVelue_ShouldBeBetween1To9()
        {
            IRandomizer randomizer = new MyRandomizer(); 
            var result = randomizer.Operand();
            Assert.GreaterOrEqual(result, 1);
            Assert.LessOrEqual(result, 9);
        }

        [Test]
        public void OperatorVelue_ShouldBeBetween1To3()
        {
            IRandomizer randomizer = new MyRandomizer(); 
            var result = randomizer.Operator();
            Assert.GreaterOrEqual(result, 1);
            Assert.LessOrEqual(result, 3);
        }
    }
}
