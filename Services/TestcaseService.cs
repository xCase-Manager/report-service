using Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class TestcaseService
    {
        private readonly IMongoCollection<Models.Testcase.Testcase> _testcases;

        public TestcaseService(Models.IDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _testcases = database.GetCollection<Models.Testcase.Testcase>(settings.TestcaseCollectionName);
        }

        public List<Models.Testcase.Testcase> Get() =>
            _testcases.Find(testcase => true).ToList();

        public Models.Testcase.Testcase Get(string id) =>
            _testcases.Find<Models.Testcase.Testcase>(testcase => testcase._Id == id).FirstOrDefault();
    }
}