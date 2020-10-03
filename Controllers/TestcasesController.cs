using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XCaseManager.Messenger.Models;
using Services;
using Models.Testcase;


namespace Messenger.Controllers
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
