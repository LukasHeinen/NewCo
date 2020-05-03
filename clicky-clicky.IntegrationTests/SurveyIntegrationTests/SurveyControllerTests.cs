using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;

namespace clicky_clicky.IntegrationTests.SurveyIntegrationTests
{
    [TestFixture]
    public class SurveyTests
    {
        private TestServer server;
        private HttpClient client;

        [SetUp]
        public void SetUp()
        {
            var webHostBuilder =
            new WebHostBuilder()
                .UseEnvironment("Development")
                // Startup-Klasse des eigentlichen Projektes
                .UseStartup<Startup>();

            this.server = new TestServer(webHostBuilder);
            this.client = server.CreateClient(); 
        }

        [Test]
        public async Task A_Survey_Can_Be_Created()
        {
            var result = await client.GetAsync("/surveys");
            Assert.True(result.IsSuccessStatusCode);
        }
    }
}