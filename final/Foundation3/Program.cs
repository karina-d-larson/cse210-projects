using System;

class Program
{
    static void Main()
    {
        // Create an address
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");

        // Create events
        Lecture lecture = new Lecture(
            "C# Inheritance Workshop",
            "Learn about inheritance in C#",
            "2026-04-01",
            "10:00 AM",
            addr1,
            "Karina",
            50
        );

        Reception reception = new Reception(
            "Networking Reception",
            "Meet and greet with professionals",
            "2026-04-02",
            "6:00 PM",
            addr1,
            "rsvp@example.com"
        );

        Outdoor outdoorEvent = new Outdoor(
            "Spring Festival",
            "Outdoor music and games",
            "2026-04-03",
            "12:00 PM",
            addr1,
            "Sunny"
        );

        // Display event details
        lecture.DisplayEvent();
        reception.DisplayEvent();
        outdoorEvent.DisplayEvent();
    }
}