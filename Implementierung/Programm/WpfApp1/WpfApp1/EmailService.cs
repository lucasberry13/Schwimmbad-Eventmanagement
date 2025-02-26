using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class EmailService
    {
        public void SendConfirmationEmail(Participant participant, Event eventItem)
        {
            try
            {
                
                string senderEmail = "SchwimmbadEvent@web.de";
                string senderPassword = "SIRD5U2EOF4ZZOXCIVHO";

                if (string.IsNullOrEmpty(senderPassword))
                {
                    MessageBox.Show("SMTP-Passwort nicht gefunden!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                var smtpClient = new SmtpClient("smtp.web.de")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };

                string subject = "Teilnahmebestätigung";
                string body = $@"
                    <html>
                    <body style='font-family: Arial, sans-serif; color: #333;'>
                        <h2 style='color: #007ACC;'>Teilnahmebestätigung</h2>
                        <p>Hallo {participant.Name},</p>
                        <p>Ihre Anmeldung zum Event <strong>{eventItem.Titel}</strong> 
                           {GetEventDatumText(eventItem)} wurde erfolgreich bestätigt.</p>
                        <p>Wir freuen uns auf Ihre Teilnahme.</p>
                        <p>Mit freundlichen Grüßen,<br/>Ihr Schwimmbad-Team</p>
                    </body>
                    </html>";

                var mail = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };

                mail.To.Add(participant.Email);
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Senden der E-Mail: {ex.Message}",
                                "E-Mail-Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string GetEventDatumText(Event eventItem)
        {
            
            return eventItem.Datum != DateTime.MinValue
                ? $"am <strong>{eventItem.Datum:dd.MM.yyyy}</strong>"
                : string.Empty;
        }
    }
}
