using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace XCaseManager.ReportService.Models.Project
{
    public class Project
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        [BsonElement("title")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("icon")]
        public bool Icon { get; set; }

        [BsonElement("__v")]
        public bool Version { get; set; }
    }
}