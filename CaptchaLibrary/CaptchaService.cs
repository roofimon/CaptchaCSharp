namespace CaptchaLibrary 
{
    public class CaptchaService
    {
        private IRandomizer randomizer;
        public CaptchaService()
        {
        }
        public void SetRandomizer(IRandomizer randomizer)
        {
            this.randomizer = randomizer;
        }

        public Captcha GetCaptcha()
        {
            return new Captcha(randomizer.Pattern(), randomizer.Operand(), randomizer.Operator(), randomizer.Operand());
        }
    }
}
