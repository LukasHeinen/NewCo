using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
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
            this.client = _factory.CreateClient();
        }

        [Test]
        public async Task A_Survey_Can_Be_Created()
        {
            //this is a test to show functionality of the test host
            var result = await client.GetAsync("/surveys");
            Assert.True(result.IsSuccessStatusCode);
        }
    }
}