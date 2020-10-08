using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using XCaseManager.ReportService.Models;
using XCaseManager.ReportService.Models.Project;

namespace XCaseManager.ReportService.Services
{
    public class ProjectService
    {
        private readonly IMongoCollection<Project> _projects;

        /*
        * Project repository service
        */
        public ProjectService(IDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _projects = database.GetCollection<Project>(
                settings.ProjectCollectionName);
        }

        /*
        * Get Projects list
        * @output projects list
        */
        public List<Project> Get() =>
            _projects.Find(testcase => true).ToList();
    }
}