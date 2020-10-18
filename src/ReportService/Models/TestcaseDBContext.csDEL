using Microsoft.EntityFrameworkCore;

namespace XCaseManager.Messenger.Models
{
    public class TestcaseDBContext : DbContext
    {
        public TestcaseDBContext(DbContextOptions<TestcaseDBContext> options)
            : base(options){}

        public DbSet<Testcase> Testcases { get; set; }
    }
}