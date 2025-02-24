using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;


namespace WpfApp1
{
    [Table("Teilnehmer")]
    public class Participant
    {
        [Key]
        public int TeilnehmerId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        [Column("Alter")]
        public int Age { get; set; }

        public int? EventId { get; set; }

        
        public Event Event { get; set; }

        public ICollection<EventParticipant> EventParticipants { get; set; } = new List<EventParticipant>();

    }
}
