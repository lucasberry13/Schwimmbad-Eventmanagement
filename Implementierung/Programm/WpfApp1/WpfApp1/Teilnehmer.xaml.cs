using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.Logging;

namespace WpfApp1
{
    
    public partial class Teilnehmer : Window
    {
        private readonly EventContext _context;

        public Teilnehmer()
        {
            InitializeComponent();
            _context = new EventContext();
            _context.Database.EnsureCreated();
            LoadEvents();
        }

        private void LoadEvents()
        {
            
            using (var db = new EventContext())
            {
                EventComboBox.ItemsSource = db.Events.ToList();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int? selectedEventId = (int?)EventComboBox.SelectedValue;

            if (string.IsNullOrWhiteSpace(ParticipantName.Text) ||
                string.IsNullOrWhiteSpace(ParticipantEmail.Text) ||
                string.IsNullOrWhiteSpace(ParticipantAge.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.",
                                "Fehler",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                return;
            }

            
            if (!int.TryParse(ParticipantAge.Text, out int age))
            {
                MessageBox.Show("Bitte geben Sie ein gültiges Alter ein.",
                                "Fehler",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                return;
            }

            var participant = new Participant
            {
                Name = ParticipantName.Text,
                Email = ParticipantEmail.Text,
                Age = age,
                
            };

            int? eventId = (int?)EventComboBox.SelectedValue;
            if (eventId == null)
            {
                MessageBox.Show("Bitte ein Event auswählen!");
                return;
            }


            _context.Participants.Add(participant);
            _context.SaveChanges();

            var ep = new EventParticipant
            {
                EventId = eventId.Value,
                TeilnehmerId = participant.TeilnehmerId 
            };

            

            _context.EventParticipants.Add(ep);
            _context.SaveChanges();

            var selectedEvent = (Event)EventComboBox.SelectedItem;


            EmailService emailService = new EmailService();
            emailService.SendConfirmationEmail(participant, selectedEvent);

            MessageBox.Show("Teilnehmer gespeichert.",
                            "Info",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
