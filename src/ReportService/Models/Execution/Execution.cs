using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace XCaseManager.ReportService.Models.Execution
{
    public class Execution
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("status")]
        public Int32 Status { get; set; }

        [BsonElement("testcaseId")]
        public string TestcaseId { get; set; }

        [BsonElement("__v")]
        public bool version { get; set; }
    }
}