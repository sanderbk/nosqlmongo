using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPeriod1.Models
{
    public enum TicketStatus
    {
        Open,
        [Display(Name = "In Progress")]
        InProgress,
        Closed,
    }
}
