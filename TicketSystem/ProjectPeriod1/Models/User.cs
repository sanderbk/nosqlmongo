using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPeriod1.Models
{
    public class User
    {
        [BsonId]
        public Guid Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "email klopt niet")]
        public string Email { get; set; }

        [Display(Name = "#tickets")]
        public int NrOfTickets { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
