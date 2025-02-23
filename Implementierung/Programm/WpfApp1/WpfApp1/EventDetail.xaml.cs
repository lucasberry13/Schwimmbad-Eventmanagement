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
    /// <summary>
    /// Interaktionslogik für EventDetail.xaml
    /// </summary>
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
            var selectedEvent = _context.Events
               .Include(e => e.Teilnehmers)  // <-- So werden die zugewiesenen Teilnehmer direkt mit abgefragt
               .FirstOrDefault(e => e.EventId == _eventId);

            if (selectedEvent != null)
            {
                LabelName.Text = $"Event: {selectedEvent.Titel}";
                LabelDate.Text = $"Datum: {selectedEvent.Datum:d}";
                LabelDescription.Text = $"Beschreibung: {selectedEvent.Details}";
                ParticipantList.ItemsSource = selectedEvent.Teilnehmers.ToList();
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
