using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp1
{
    public class Event
    {
        [Column("EventID")]
        public int EventId { get; set; }
        public string Titel { get; set; }
        public DateTime Datum { get; set; }
        public string Details { get; set; }

        public ICollection<Participant> Teilnehmers { get; set; } = new List<Participant>();
    }
}
