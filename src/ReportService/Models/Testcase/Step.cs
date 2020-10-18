using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace XCaseManager.ReportService.Models.Testcase
{
    public class Step {
        
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}