using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class EventParticipant
    {
        [Column("EventID")]
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int TeilnehmerId { get; set; }
        public Participant Participant { get; set; }
    }
}
