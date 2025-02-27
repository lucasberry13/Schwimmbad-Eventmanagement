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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AktualisiereStatistik();
        }

        private void AktualisiereStatistik()
        {
            
            using (var context = new EventContext())
            {
                
                int gesamtTeilnehmer = context.Participants.Count();

                
                double durchschnittsalter = 0;
                if (gesamtTeilnehmer > 0)
                {
                    durchschnittsalter = context.Participants.Average(p => p.Age);
                }

                
                StatsPanel.Children.Clear();

                
                var titleBlock = new TextBlock
                {
                    Text = "Teilnehmer-Statistik",
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    Margin = new Thickness(5),
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                StatsPanel.Children.Add(titleBlock);

                
                StatsPanel.Children.Add(new TextBlock
                {
                    Text = $"Gesamtanzahl der Teilnehmer: {gesamtTeilnehmer}",
                    Margin = new Thickness(5)
                });

                
                StatsPanel.Children.Add(new TextBlock
                {
                    Text = $"Durchschnittsalter: {durchschnittsalter:F2} Jahre",
                    Margin = new Thickness(5)
                });
            }
        }

        private void OpenEventAnz_Click(object sender, RoutedEventArgs e)
        {
            var eventAnz = new EventAnz();
            eventAnz.ShowDialog();
            AktualisiereStatistik();
        }

        
        private void OpenEventNeu_Click(object sender, RoutedEventArgs e)
        {
            var eventNeu = new EventNeu();
            eventNeu.ShowDialog();
            AktualisiereStatistik();
        }
        private void OpenTeilnehmerVerwaltung_Click(object sender, RoutedEventArgs e)
        {
            var teilnehmerVerwaltung = new TeilnehmerVerwalten();
            teilnehmerVerwaltung.ShowDialog();
            AktualisiereStatistik();
        }

        private void BtnAssignParticipant_Click(object sender, RoutedEventArgs e)
        {
            TeilnehmerZuEvent assignWindow = new TeilnehmerZuEvent();
            assignWindow.ShowDialog();
            AktualisiereStatistik();
        }

    }
}
