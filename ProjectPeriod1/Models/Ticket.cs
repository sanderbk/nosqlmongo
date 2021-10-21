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

        public User User { get; set; }

        public TicketType Type { get; set; }

        public TicketPriority Priority { get; set; }

        public TicketStatus Status { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public DateTime ReportDate { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }

    }
}
