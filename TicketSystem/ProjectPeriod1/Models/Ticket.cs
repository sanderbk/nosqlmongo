using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPeriod1.Models
{
    

    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Subject_Incident { get; set; }

        public string Type { get; set; }

        public string Priority { get; set; }

        public string User { get; set; }

        public string Subject { get; set; }

        public string Deadline { get; set; }

        public string Description { get; set; }
        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }

        
    }
}
