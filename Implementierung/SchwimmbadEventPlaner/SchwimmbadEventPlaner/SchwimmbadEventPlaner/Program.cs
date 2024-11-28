using System;
using System.Collections.Generic;

class Event
{
    public int ID { get; set; }
    public string Titel { get; set; }
    public DateTime Datum { get; set; }
    public string Details { get; set; }
    public List<string> Teilnehmer { get; set; } = new List<string>();

    public void Anzeigen()
    {
        Console.WriteLine($"ID: {ID}, Titel: {Titel}, Datum: {Datum.ToShortDateString()}, Details: {Details}");
        Console.WriteLine("Teilnehmer:");
        foreach (var t in Teilnehmer)
        {
            Console.WriteLine($"- {t}");
        }
    }
}

class Program
{
    static List<Event> events = new List<Event>();
    static int eventCounter = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSchwimmbad - Eventmanagement");
            Console.WriteLine("1: Neues Event anlegen");
            Console.WriteLine("2: Eventliste anzeigen");
            Console.WriteLine("3: Teilnehmer verwalten");
            Console.WriteLine("4: Beenden");
            Console.Write("Wählen Sie eine Option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    NeuesEvent();
                    break;
                case "2":
                    EventListe();
                    break;
                case "3":
                    TeilnehmerVerwalten();
                    break;
                case "4":
                    Console.WriteLine("Programm beendet.");
                    return;
                default:
                    Console.WriteLine("Ungültige Option, bitte erneut wählen.");
                    break;
            }
        }
    }

    static void NeuesEvent()
    {
        Console.Write("Titel: ");
        string titel = Console.ReadLine();
        Console.Write("Datum (yyyy-mm-dd): ");
        DateTime datum = DateTime.Parse(Console.ReadLine());
        Console.Write("Details: ");
        string details = Console.ReadLine();

        events.Add(new Event { ID = eventCounter++, Titel = titel, Datum = datum, Details = details });
        Console.WriteLine("Event erstellt.");
    }

    static void EventListe()
    {
        if (events.Count == 0)
        {
            Console.WriteLine("Keine Events vorhanden.");
            return;
        }

        foreach (var ev in events)
        {
            ev.Anzeigen();
        }
    }

    static void TeilnehmerVerwalten()
    {
        Console.Write("Event-ID auswählen: ");
        int eventId = int.Parse(Console.ReadLine());

        var ev = events.Find(e => e.ID == eventId);
        if (ev == null)
        {
            Console.WriteLine("Event nicht gefunden.");
            return;
        }

        Console.WriteLine($"Teilnehmer für Event '{ev.Titel}':");
        Console.WriteLine("1: Teilnehmer hinzufügen");
        Console.WriteLine("2: Teilnehmer anzeigen");
        Console.Write("Wählen Sie eine Option: ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            Console.Write("Name des Teilnehmers: ");
            string name = Console.ReadLine();
            ev.Teilnehmer.Add(name);
            Console.WriteLine("Teilnehmer hinzugefügt.");
        }
        else if (option == "2")
        {
            ev.Anzeigen();
        }
        else
        {
            Console.WriteLine("Ungültige Option.");
        }
    }
}
