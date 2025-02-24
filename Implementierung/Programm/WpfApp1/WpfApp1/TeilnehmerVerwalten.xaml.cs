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
    
    public partial class TeilnehmerVerwalten : Window
    {
        private readonly EventContext _context;

        public TeilnehmerVerwalten()
        {
            InitializeComponent();
            _context = new EventContext();
            _context.Database.EnsureCreated();
            LoadParticipants();
        }

        private void LoadParticipants()
        {
           
            ParticipantList.ItemsSource = _context.Participants
                                                 .OrderBy(p => p.Name)
                                                 .ToList();
        }

        private void CreateNewParticipant_Click(object sender, RoutedEventArgs e)
        {
            var neuFenster = new Teilnehmer();
            neuFenster.ShowDialog();
            LoadParticipants();
        }

        private void DeleteParticipant_Click(object sender, RoutedEventArgs e)
        {
            if (ParticipantList.SelectedItem is Participant selected)
            {
                var result = MessageBox.Show(
                    $"Möchten Sie den Teilnehmer '{selected.Name}' wirklich löschen?",
                    "Löschen bestätigen",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    _context.Participants.Remove(selected);
                    _context.SaveChanges();
                    LoadParticipants();
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Teilnehmer aus.", "Hinweis",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
