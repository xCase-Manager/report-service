using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;


namespace XCaseManager.ReportServiceTests.Controllers
{
    public class TestcaseControllerTests : IntegrationTest
    {
        public TestcaseControllerTests(ApiWebApplicationFactory fixture)
            : base(fixture) { }

        [Fact]
        public async Task Get_Should_Return_Testcases()
        {
            var response = await _client.GetAsync("/api/testcases");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }  
}