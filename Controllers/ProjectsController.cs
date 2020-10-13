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
        * @output projects list
        */
        [HttpGet]
        public ActionResult<List<Project>> Get() =>
            _projectService.Get();

        /*
        * GET Project
        * @input id
        * @output project
        */
        [HttpGet("{id}", Name = "GetProject")]
        public ActionResult<Project> Get(string id) {
            var project = _projectService.Get(id);
            if (project != null)
                return project;
            return NotFound();
        }
    }
}
