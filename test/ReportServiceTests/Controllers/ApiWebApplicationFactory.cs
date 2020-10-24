using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace XCaseManager.ReportServiceTests.Controllers
{
    public class ApiWebApplicationFactory : WebApplicationFactory<XCaseManager.Messenger.Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
    
        }
    }
}