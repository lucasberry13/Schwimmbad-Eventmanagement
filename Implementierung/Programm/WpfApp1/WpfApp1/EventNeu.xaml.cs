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
using Microsoft.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für EventNeu.xaml
    /// </summary>
    public partial class EventNeu : UserControl
    {

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EventPlaner;Integrated Security=SSPI";


        public EventNeu()
        {
            InitializeComponent();
        }

        private void BtnEventHinzu_Click(object sender, RoutedEventArgs e)
        {
            string titel = txtTitel.Text;
            string datum = dpDatum.SelectedDate.HasValue ? dpDatum.SelectedDate.Value.ToString("yyyy-MM-dd") : null;
            string details = txtDetails.Text;

            // Prüfen, ob die Felder nicht leer sind
            if (string.IsNullOrWhiteSpace(titel) || string.IsNullOrWhiteSpace(datum))
            {
                MessageBox.Show("Bitte Titel und Datum eingeben!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Events (Titel, Datum, Details) VALUES (@Titel, @Datum, @Details)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Titel", titel);
                        cmd.Parameters.AddWithValue("@Datum", datum);
                        cmd.Parameters.AddWithValue("@Details", details ?? (object)DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event erfolgreich gespeichert!", "Erfolg", MessageBoxButton.OK, MessageBoxImage.Information);
                            txtTitel.Clear();
                            dpDatum.SelectedDate = null;
                            txtDetails.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Fehler beim Speichern des Events!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datenbankfehler: {ex.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
