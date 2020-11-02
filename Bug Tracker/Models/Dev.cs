using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class Dev
    {
        public int ID { get; set; }
        public List<Tickets> Tickets { get; set;}
    }
}
