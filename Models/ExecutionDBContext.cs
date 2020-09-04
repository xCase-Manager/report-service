using Microsoft.EntityFrameworkCore;

namespace XCaseManager.Messenger.Models
{
    public class ExecutionDBContext : DbContext
    {
        public ExecutionDBContext(DbContextOptions<ExecutionDBContext> options)
            : base(options)
        {
        }

        public DbSet<Execution> Executions { get; set; }
    }
}