using Microsoft.EntityFrameworkCore;

namespace XCaseManager.Messenger.Models
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options)
            : base(options){}

        public DbSet<Project> Projects { get; set; }
    }
}