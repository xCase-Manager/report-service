using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XCaseManager.Messenger.Models;

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

        public TestcasesController(TestcaseDBContext context)
        {
            _context = context;
        }

        /*
        * GET Testcases list
        * @output testcases
        */
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Testcase>>> GetTestcases()
        {
            return await _context.Testcases.ToListAsync();
        }

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
