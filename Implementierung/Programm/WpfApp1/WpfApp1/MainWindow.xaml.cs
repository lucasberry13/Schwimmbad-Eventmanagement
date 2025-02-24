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
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void OpenEventAnz_Click(object sender, RoutedEventArgs e)
        {
            var eventAnz = new EventAnz();
            eventAnz.ShowDialog();
        }

        
        private void OpenEventNeu_Click(object sender, RoutedEventArgs e)
        {
            var eventNeu = new EventNeu();
            eventNeu.ShowDialog();
        }
        private void OpenTeilnehmerVerwaltung_Click(object sender, RoutedEventArgs e)
        {
            var teilnehmerVerwaltung = new TeilnehmerVerwalten();
            teilnehmerVerwaltung.ShowDialog();
        }

        private void BtnAssignParticipant_Click(object sender, RoutedEventArgs e)
        {
            TeilnehmerZuEvent assignWindow = new TeilnehmerZuEvent();
            assignWindow.ShowDialog(); 
        }

    }
}
