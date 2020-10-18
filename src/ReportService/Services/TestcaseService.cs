using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using XCaseManager.ReportService.Models;
using XCaseManager.ReportService.Models.Testcase;

namespace XCaseManager.ReportService.Services
{
    public class TestcaseService
    {
        private readonly IMongoCollection<Testcase> _testcases;

        /*
        * Testcase repository service
        */
        public TestcaseService(IDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _testcases = database.GetCollection<Testcase>(settings.TestcaseCollectionName);
        }

        /*
        * Get testcases list
        * @output testcases list
        */
        public List<Testcase> Get() =>
            _testcases.Find(testcase => true).ToList();

        /*
        * Find a testcase
        * @input id
        * @output testcase
        */
        public Testcase Get(int id) =>
            _testcases.Find<Testcase>(testcase => testcase.Id == id).FirstOrDefault();
    }
}