using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using XCaseManager.ReportService.Models.Testcase;
using XCaseManager.ReportService.Services;


namespace XCaseManager.ReportService.Controllers
{
    /*
    * Controller for testcases
    */
    [Route("api/[controller]")]
    [ApiController]
    public class TestcasesController : ControllerBase
    {
        private readonly TestcaseService _testcaseService;

        public TestcasesController( 
            TestcaseService testcaseService)
        {
            _testcaseService = testcaseService;
        }

        /*
        * GET Testcases list
        * @output testcases
        */
        [HttpGet]
        public ActionResult<List<Testcase>> Get() =>
            _testcaseService.Get();
    }
}
