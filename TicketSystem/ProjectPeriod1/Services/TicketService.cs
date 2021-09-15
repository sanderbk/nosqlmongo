using MongoDB.Driver;
using ProjectPeriod1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPeriod1.Services
{
    public class TicketService
    {
        private readonly IMongoCollection<Ticket> _tickets;

        public TicketService(IDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _tickets = database.GetCollection<Ticket>("Tickets");
        }

        public Ticket Create(Ticket ticket)
        {
            _tickets.InsertOne(ticket);
            return ticket;
        }

        public IList<Ticket> Read() =>
            _tickets.Find(tic => true).ToList();

        public Ticket Find(string id) =>
            _tickets.Find(tic => tic.Id == id).SingleOrDefault();

        public void Update(Ticket ticket) =>
            _tickets.ReplaceOne(tic => tic.Id == ticket.Id, ticket);

        public void Delete(string id) =>
            _tickets.DeleteOne(tic => tic.Id == id);
    }
}
