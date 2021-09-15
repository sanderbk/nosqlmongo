using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPeriod1.Models
{
  
        public interface IDbSettings
        {
            string ConnectionString { get; set; }
            string DatabaseName { get; set; }
        }

        public class DbSettings : IDbSettings
    {
            public string ConnectionString { get; set; }
            public string DatabaseName { get; set; }
        }
    
}
