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
    }
}