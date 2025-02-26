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
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1
{
   
    public partial class EventDetail : Window
    {
        private readonly EventContext _context;
        private readonly int _eventId;
        

        public EventDetail(int eventId)
        {
            InitializeComponent();
            _context = new EventContext();
            _context.Database.EnsureCreated();
            _eventId = eventId;
            LoadEventDetails();
        }

        private void LoadEventDetails()
        {
            using (var db = new EventContext())
            {
                var selectedEvent = db.Events
                    .Include(e => e.EventParticipants)
                        .ThenInclude(ep => ep.Participant)
                    .FirstOrDefault(e => e.EventId == _eventId);

                if (selectedEvent != null)
                {
                    LabelName.Text = $"Event: {selectedEvent.Titel}";
                    LabelDate.Text = $"Datum: {selectedEvent.Datum:d}";
                    LabelDescription.Text = $"Beschreibung: {selectedEvent.Details}";

                    
                    var participants = selectedEvent.EventParticipants
                                                    .Select(ep => ep.Participant)
                                                    .ToList();

                    ParticipantList.ItemsSource = participants;
                }
            }

        }

        private void RemoveParticipant_Click(object sender, RoutedEventArgs e)
        {
            if (ParticipantList.SelectedItem is Participant selectedParticipant)
            {
                using (var context = new EventContext())
                {
                    
                    var eventId = _eventId;
                    context.RemoveParticipantFromEvent(eventId, selectedParticipant.TeilnehmerId);
                }

                MessageBox.Show("Teilnehmer wurde entfernt.", "Erfolgreich", MessageBoxButton.OK, MessageBoxImage.Information);

                
                LoadEventDetails();
            }
            else
            {
                MessageBox.Show("Bitte einen Teilnehmer auswählen!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DeleteEvent_Click(object sender, RoutedEventArgs e)
        {
            var selectedEvent = _context.Events.FirstOrDefault(ev => ev.EventId == _eventId);
            if (selectedEvent != null)
            {
                var result = MessageBox.Show("Möchten Sie dieses Event wirklich löschen?",
                                             "Löschen bestätigen",
                                             MessageBoxButton.YesNo,
                                             MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    _context.Events.Remove(selectedEvent);
                    _context.SaveChanges();
                    MessageBox.Show("Event erfolgreich gelöscht!", "Info",
                                    MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
            }
        }
    }
}
