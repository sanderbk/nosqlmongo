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
        private readonly IMongoCollection<User> _users;

        public UserService(IDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<User>("Users");
        }
        public IList<User> Read()
        {
           return _users.Find(usr => true).ToList();
        }
        

        public User Find(string id) =>
           _users.Find(usr => usr.MongoId == id).SingleOrDefault();

       


        /*
        public void Update(User user) =>
            _users.ReplaceOne(usr => usr.Name == user.Name, user);

        public void Delete(string id) =>
            _users.DeleteOne(usr => usr.Name == id);*/
    }
}
