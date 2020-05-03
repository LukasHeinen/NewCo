using clicky_clicky.Surveys.Domain.Models;
using NUnit.Framework;

namespace clicky_clicky.UnitTests.SurveyTests
{
    [TestFixture]
    public class SurveyEntityTests
    {
        [TestCase("00000","What is where?")]
        public void IsValid_ValidEntity_true(string creatorId, string question)
        {
            var survey = new Survey()
            {
                CreatorId = creatorId,
                Question = question
            };
            Assert.IsTrue(survey.IsValid());
        }

        [TestCase("")]
        [TestCase("  ")]
        [TestCase(null)]
        [TestCase("1234 232")]
        public void IsValid_InvalidCreator_false(string creatorId)
        {
            var survey = new Survey()
            {
                CreatorId = creatorId,
                Question = "What is where?"
            };
            Assert.IsFalse(survey.IsValid());
        }

        [TestCase("")]
        [TestCase("  ")]
        [TestCase(null)]
        public void IsValid_InvalidQuestion_false(string question)
        {
            var survey = new Survey()
            {
                CreatorId = "12345",
                Question = question
            };
            Assert.IsFalse(survey.IsValid());
        }

        [TestCase("  What is where?")]
        [TestCase("What is where?   ")]
        [TestCase("   What is where?   ")]
        public void Question_LeadingOrTrailingWhitespaces_Trimmed(string question)
        {
            var survey = new Survey()
            {
                CreatorId = "12345",
                Question = question
            };
            Assert.That(survey.Question, Is.EqualTo("What is where?"));
        }
    }
}