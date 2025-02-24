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

namespace WpfApp1
{
    
    public partial class EventAnz : Window
    {
        private readonly EventContext _context;

        public EventAnz()
        {
            InitializeComponent();
            _context = new EventContext();
            _context.Database.EnsureCreated();
            LoadEvents();
        }

        private void LoadEvents()
        {
            
            EventList.ItemsSource = _context.Events.ToList();
        }

        private void EventList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EventList.SelectedItem is Event selectedEvent)
            {
                
                var detailWindow = new EventDetail(selectedEvent.EventId);
                detailWindow.ShowDialog();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
