using Microsoft.EntityFrameworkCore;

namespace XCaseManager.Messenger.Models
{
    public class ExecutionContext : DbContext
    {
        public ExecutionContext(DbContextOptions<ExecutionContext> options)
            : base(options)
        {
        }

        public DbSet<Execution> Executions { get; set; }
    }
}