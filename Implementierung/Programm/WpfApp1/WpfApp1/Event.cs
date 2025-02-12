using System;
using System.Collections.Generic;

namespace WpfApp1
{
    public partial class Event
    {
        public Event()
        {
            Teilnehmers = new HashSet<Teilnehmer>();
        }

        public int EventId { get; set; }
        public string Titel { get; set; } = null!;
        public DateTime Datum { get; set; }
        public string? Details { get; set; }

        public virtual ICollection<Teilnehmer> Teilnehmers { get; set; }
    }
}
