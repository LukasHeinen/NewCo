using System.Reflection.Metadata;
using System.Reflection;
using System;
using clicky_clicky.Surveys.Domain;
using clicky_clicky.Surveys.Domain.Models;
using NUnit.Framework;
using Moq;
using clicky_clicky.Utils.AzureTableStorage;

namespace clicky_clicky.UnitTests.SurveyTests
{
    [TestFixture]
    public class SurveyServiceTests
    {
        private SurveyService _surveyService;

        [SetUp]
        public void SetUp()
        {
            _surveyService = new SurveyService(Mock.Of<IAzureTableStorage<Survey>>());
        }

        [Test]
        public void CreateSurvey_InvalidSurvey_ArgumentException()
        {
            var invalidSurvey = new Survey();
            Assert.ThrowsAsync<ArgumentException>(async () => await _surveyService.CreateSurvey(invalidSurvey));
        }
    }
}