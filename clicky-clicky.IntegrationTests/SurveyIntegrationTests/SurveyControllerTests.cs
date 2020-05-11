using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using clicky_clicky.Surveys.Application.RequestModels;
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
            var file = File.OpenRead("Assets/Minions.png");
            var image = new StreamContent(file);

            var content = new MultipartFormDataContent {
                // add API method parameters
                { new StringContent("What is where?"), "Question" },
                { new StringContent("true"), "ShowResolutionAfterTip" }
            };
            content.Add(image, "Image", "Minions.png");
            // Act
            var response = await client.PostAsync("/surveys", content);
            Assert.True(response.IsSuccessStatusCode);
        }
    }
}