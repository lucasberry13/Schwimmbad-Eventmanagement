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

namespace WpfApp1
{
   
    public partial class TeilnehmerZuEvent : Window
    {
        private EventContext _context;

        public TeilnehmerZuEvent()
        {
            InitializeComponent();
            _context = new EventContext();
            LoadData();
        }

        private void LoadData()
        {
            
            ComboBoxParticipant.ItemsSource = _context.Participants.ToList();
            ComboBoxParticipant.DisplayMemberPath = "Name";
            ComboBoxParticipant.SelectedValuePath = "TeilnehmerId";

            
            ComboBoxEvent.ItemsSource = _context.Events.ToList();
            ComboBoxEvent.DisplayMemberPath = "Titel";
            ComboBoxEvent.SelectedValuePath = "EventId";
        }

        private void BtnAssign_Click(object sender, RoutedEventArgs e)
        {
            int? participantId = (int?)ComboBoxParticipant.SelectedValue;
            int? eventId = (int?)ComboBoxEvent.SelectedValue;

            if (participantId == null)
            {
                MessageBox.Show("Bitte einen Teilnehmer auswählen!");
                return;
            }

            if (eventId == null)
            {
                MessageBox.Show("Bitte ein Event auswählen!");
                return;
            }

            
            bool alreadyExists = _context.EventParticipants
                .Any(ep => ep.EventId == eventId.Value && ep.TeilnehmerId == participantId.Value);

            if (alreadyExists)
            {
                MessageBox.Show("Dieser Teilnehmer ist bereits in diesem Event!");
                return;
            }

            
            var ep = new EventParticipant
            {
                EventId = eventId.Value,
                TeilnehmerId = participantId.Value
            };

            _context.EventParticipants.Add(ep);
            _context.SaveChanges();

            MessageBox.Show("Teilnehmer wurde erfolgreich zugewiesen!");
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
