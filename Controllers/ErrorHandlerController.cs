using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;


namespace XCaseManager.ReportService.Controllers
{
    /*
    * API Error handler
    */
    [ApiController]
    public class ErrorHandlerController : ControllerBase
    {
        private readonly ILogger _logger;

        public ErrorHandlerController(
            ILogger<ProjectsController> logger)
        {
            _logger = logger;
        }
        
        [Route("/error-local-development")]
        public IActionResult ErrorLocalDevelopment(
            [FromServices] IWebHostEnvironment webHostEnvironment)
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            _logger.LogError("Could not process request, error: " + 
                    context.Error.Message
                );
       
            if (webHostEnvironment.EnvironmentName != "Development")
                throw new InvalidOperationException(
                    "An error happened");

            return Problem(
                detail: context.Error.StackTrace,
                title: context.Error.Message);
        }

        [Route("/error")]
        public IActionResult Error() {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            _logger.LogError("Could not process request, error: " + 
                    context.Error.Message
                );
            return Problem();
        }
    }
}