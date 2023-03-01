using RegexProblem;

namespace TestingRegex
{
    public class Tests
    {
        RegexMethod regexMethod = new RegexMethod();
        [Test]
        public void GivenFirstName_WhenAnalysed_ShouldReturnFirstName()
        {
            string expectedOutput = "First name matching with Regex";
            string actualOutput = regexMethod.ValidateFirstName("Vijay");
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
        [Test]
        public void GivenLastName_WhenAnalysed_ShouldReturnLastName()
        {
            string expectedOutput = "Last name matching with Regex";
            string actualOutput = regexMethod.ValidateLastName("Durkikar");
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
        [Test]
        public void GivenEmail_WhenAnalysed_ShouldReturnEmail()
        {
            string expectedOutput = "Email id is matching with Regex";
            string actualOutput = regexMethod.ValidateEmail("abc.xyz@bridgelabz.co.in");
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
        [Test]
        public void GivenPhoneNumber_WhenAnalysed_ShouldReturnPhoneNumber()
        {
            string expectedOutput = "Phone Number is matching with Regex";
            string actualOutput = regexMethod.ValidatePhoneNumber("91 7729937460");
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
        [Test]
        public void GivenPassword_WhenAnalysed_ShouldReturnPassword()
        {
            string expectedOutput = "Password is matching with Regex";
            string actualOutput = regexMethod.ValidatePassword("Vijay0987");
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
        [Test]
        public void GivenString_WhenAnalysed_ShouldReturnString()
        {
            string expectedOutput = "It is matching with Regex";
            string actualOutput = regexMethod.ValidateString("Vijay");
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
    }
}