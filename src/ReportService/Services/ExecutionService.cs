using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using XCaseManager.ReportService.Models.Execution;

namespace XCaseManager.ReportService.Services
{
    public class ExecutionService
    {
        private readonly IMongoCollection<Execution> _executions;

        /*
        * Execution repository service
        */
        public ExecutionService(IDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _executions = database.GetCollection<Execution>(settings.ExecutionCollectionName);
        }

        /*
        * Get executions list
        * @output executions list
        */
        public List<Execution> Get() =>
            _executions.Find(execution => true).ToList();

        /*
        * Find an execution
        * @input id
        * @output execution
        */
        public Execution Get(int id) =>
            _executions.Find<Execution>(execution => execution.Id == id).FirstOrDefault();
    }
}