using System;
using System.Collections.Generic;

namespace WpfApp1
{
    public partial class Teilnehmer
    {
        public int TeilnehmerId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int? EventId { get; set; }

        public virtual Event? Event { get; set; }
    }
}
