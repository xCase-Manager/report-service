using Models.Testcase;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class TestcaseService
    {
        private readonly IMongoCollection<Testcase> _testcases;

        public TestcaseService(IDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _testcases = database.GetCollection<Testcase>(settings.TestcaseCollectionName);
        }

        public List<Testcase> Get() =>
            _testcases.Find(testcase => true).ToList();

        public Testcase Get(string id) =>
            _testcases.Find<Testcase>(testcase => testcase._Id == id).FirstOrDefault();
    }
}