using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ProjectPeriod1.Models
{
    [BsonIgnoreExtraElements]
    public class User
    {


        [BsonId]
        public Guid _id { get; set; }

        public string MongoId
        {
            get { return _id.ToString(); }
            set { _id = Guid.Parse(value); }
        }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
   

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "email klopt niet")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
