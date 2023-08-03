using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Advertisement> advertisements = new List<Advertisement>();

            List<string> phrases = new List<string>() {"Excellent product.", "Such a great product.",
            "I always use that product.", "Best product of its category.", "Exceptional product.",
            "I can't live without this product."};
            List<string> events = new List<string>() {"Now I feel good.", "I have succeeded with this product.",
            "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!"};
            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int messageCount = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < messageCount; i++)
            {
                int randomPhraseIndex = random.Next(0, phrases.Count);
                int randomEventsIndex = random.Next(0, events.Count);
                int randomAuthorsIndex = random.Next(0, authors.Count);
                int randomCitiesIndex = random.Next(0, cities.Count);

                Advertisement advertisement = new Advertisement(phrases[randomPhraseIndex], events[randomEventsIndex],
                    authors[randomAuthorsIndex], cities[randomCitiesIndex]);

                Console.WriteLine(advertisement);
            }
        }
    }

    public class Advertisement
    {
        public Advertisement(string phrase, string advertisementEvent, string author, string city)
        {
            Phrase = phrase;
            Event = advertisementEvent;
            Author = author;
            City = city;
        }

        public string Phrase { get; set; }

        public string Event { get; set; }

        public string Author { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            return $"{Phrase} {Event} {Author} – {City}.";
        }

    }
}