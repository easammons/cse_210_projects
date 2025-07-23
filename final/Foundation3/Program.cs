using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Address addr2 = new Address("456 Oak Ave", "Chicago", "IL", "USA");
        Address addr3 = new Address("789 Park Blvd", "Los Angeles", "CA", "USA");

        Event lecture = new Lecture("Tech Trends 2025", "A lecture on emerging technologies", "08/15/2025", "10:00 AM", addr1, "Dr. Alice Smith", 100);
        Event reception = new Reception("Summer Networking", "Meet professionals and expand your network", "08/20/2025", "6:00 PM", addr2, "rsvp@events.com");
        Event outdoor = new OutdoorGathering("Music in the Park", "Live outdoor concert", "08/25/2025", "4:00 PM", addr3, "Sunny, 75°F");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (var e in events)
        {
            Console.WriteLine("=== Standard Details ===");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("\n=== Full Details ===");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("\n=== Short Description ===");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("\n------------------------------\n");
        }
        
    }
}