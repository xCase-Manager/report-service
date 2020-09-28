using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XCaseManager.Messenger.Models;
using Services;


namespace Messenger.Controllers
{
    /*
    * Controller for testcases
    */
    [Route("api/[controller]")]
    [ApiController]
    public class TestcasesController : ControllerBase
    {
        private readonly TestcaseDBContext _context;
        private readonly TestcaseService _testcaseService;

        public TestcasesController(TestcaseDBContext context, 
            TestcaseService testcaseService)
        {
            _context = context;
            _testcaseService = testcaseService;
        }

        /*
        * GET Testcases list
        * @output testcases
        */
        [HttpGet]
        public ActionResult<List<Models.Testcase.Testcase>> Get() =>
            _testcaseService.Get();

        /*
        * GET a testcase
        * @input id
        * @output testcase
        */
        [HttpGet("{id}")]
        public async Task<ActionResult<Testcase>> GetTestcase(long id)
        {
            var testcase = await _context.Testcases.FindAsync(id);

            if (testcase == null)
            {
                return NotFound();
            }

            return testcase;
        }
    }
}
