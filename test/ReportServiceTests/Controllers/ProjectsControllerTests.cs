using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;


namespace XCaseManager.ReportServiceTests.Controllers
{
    public class ProjectControllerTests : IntegrationTest
    {
        public ProjectControllerTests(ApiWebApplicationFactory fixture)
            : base(fixture) { }

        [Fact]
        public async Task Get_Should_Return_Projects()
        {
            var response = await _client.GetAsync("/api/projects");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }  
}