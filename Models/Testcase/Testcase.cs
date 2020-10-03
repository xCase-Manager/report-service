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
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("projectId")]
        public string ProjectId { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }
    }
}