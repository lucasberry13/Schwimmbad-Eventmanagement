using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1
{
    public class EventContext : DbContext
    {
        // Hier definierst du alle Entitäten, die in der DB landen sollen
        public DbSet<Event> Events { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Beispiel: Anbindung an LocalDB in Visual Studio
            // ACHTUNG: Passe die Connection an dein System an
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EventPlaner;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Hier kannst du z.B. Tabellen, Indizes, Beziehungen genauer konfigurieren.
            // modelBuilder.Entity<Event>().HasKey(e => e.Id);
        }

        


    }
}
