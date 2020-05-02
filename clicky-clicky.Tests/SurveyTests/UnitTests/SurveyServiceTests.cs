using System.Reflection.Metadata;
using System.Reflection;
using System;
using clicky_clicky.Surveys.Domain;
using clicky_clicky.Surveys.Domain.Models;
using NUnit.Framework;
using Moq;
using clicky_clicky.Utils.AzureTableStorage;

namespace clicky_clicky.Tests.SurveyTests.UnitTests
{
    [TestFixture]
    public class SurveyServiceTests3
    {
        private SurveyService _surveyService;

        [SetUp]
        public void SetUp()
        {
            _surveyService = new SurveyService(Mock.Of<IAzureTableStorage<Survey>>());
        }

    }
}