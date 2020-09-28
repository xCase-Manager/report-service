using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Testcase
{
    public class Testcase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        [BsonElement("title")]
        public string TestcaseName { get; set; }

        public string Description { get; set; }

        public string ProjectId { get; set; }
    }
}