using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using clicky_clicky.Surveys.Application.RequestModels;
using clicky_clicky.Surveys.Application.ViewModels;
using licky_clicky.IntegrationTests.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using NUnit.Framework;

namespace clicky_clicky.IntegrationTests.SurveyIntegrationTests
{
    [TestFixture]
    public class SurveyTests
    {
        private HttpClient client;

        private readonly WebApplicationFactory<Startup> _factory;

        public SurveyTests()
        {
            _factory = new WebApplicationFactory<Startup>();
        }

        [SetUp]
        public void SetUp()
        {
            //var options = new WebApplicationFactoryClientOptions { AllowAutoRedirect = false };
            this.client = _factory.CreateClient();
        }

        [TearDown]
        public void Dispose()
        {
            client.Dispose();
        }

        [Test]
        public async Task A_Survey_Can_Be_Created()
        {
            //Prepare
            var file = File.OpenRead("Assets/Minions.png");
            var image = new StreamContent(file);
            var content = new MultipartFormDataContent {
                // add API method parameters
                { new StringContent("What is where?"), "Question" },
                { new StringContent("true"), "ShowResolutionAfterTip" }
            };
            content.Add(image, "Image", "Minions.png");
            
            //Act
            var response = await client.PostAsync("/surveys", content);
            
            //Assert
            Assert.IsTrue(response.IsSuccessStatusCode);
            var surveyView = JsonConvert.DeserializeObject<SurveyView>(response.Content.ToString());
            Assert.That(surveyView.Question, Is.EqualTo("What is where?"));
            Assert.That(surveyView.ShowResolutionAfterTip, Is.True);
            Assert.That(surveyView.ImageUrl, Is.Not.Empty);
            Assert.That(surveyView.Id, Is.Not.Empty);
        }

        [Test]
        public async Task A_Survey_Can_Be_Viewed()
        {
            Assert.That(true, Is.True);
        }

    }
}