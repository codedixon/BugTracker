using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class Tickets
    {
        public int ID { get; set; }
        public string Ticket { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Urgency { get; set; }
        public bool Assigned { get; set; }
        public bool Completed { get; set; }
    }
}
