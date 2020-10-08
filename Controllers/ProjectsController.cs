using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using XCaseManager.ReportService.Models.Project;
using XCaseManager.ReportService.Services;


namespace XCaseManager.ReportService.Controllers
{
    /*
    * Controller for testcases
    */
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectService _projectService;

        public ProjectsController( 
            ProjectService projectService)
        {
            _projectService = projectService;
        }

        /*
        * GET Projects list
        * @output projects
        */
        [HttpGet]
        public ActionResult<List<Project>> Get() =>
            _projectService.Get();
    }
}
