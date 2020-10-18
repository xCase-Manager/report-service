using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace XCaseManager.ReportService.Models.Project
{
    public class Project
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("icon")]
        public string Icon { get; set; }

        [BsonElement("status")]
        public Int32 Status { get; set; }

        [BsonElement("created")]
        public DateTime CreationTime { get; set; }

        [BsonElement("__v")]
        public Int32 Version { get; set; }
    }
}