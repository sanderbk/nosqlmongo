using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using ProjectPeriod1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPeriod1.Services
{
    public class UserService
    {
        private readonly IMongoCollection<BsonDocument> _userColection;
        public UserService(IDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _userColection = database.GetCollection<BsonDocument>("Users");

        }
        public User Create(User user)
        {
            _userColection.InsertOne(user.ToBsonDocument());
            return user;
        }

        public IList<User> ReadUsers()
        {

            List<BsonDocument> docs = _userColection.Find(new BsonDocument()).ToList();
            List<User> appusers = new List<User>();
            foreach (BsonDocument u in docs)
            {
                User appuser = new User
                {
                    Email = (string)u["Email"],
                    FirstName = (string)u["FirstName"],
                    LastName = (string)u["LastName"],
                    NrOfTickets = (int)u["NrOfTickets"]
                };
                appusers.Add(appuser);
            }
            return appusers;
        }
    }
}
