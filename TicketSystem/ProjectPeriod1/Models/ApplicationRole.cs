using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPeriod1.Models
{
    [CollectionName("Roles")]
    public class ApplicationRole : MongoIdentityRole<Guid>
    {
        public string RoleName { get; set; }
    }
}
