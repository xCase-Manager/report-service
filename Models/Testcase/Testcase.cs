using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

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

        [BsonElement("steps")]
        public List<Step> Steps {get; set;}

        [BsonElement("__v")]
        public bool version { get; set; }
    }
}