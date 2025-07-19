using System;

class Program
{
    static void Main(string[] args)
    {
        // Create your scripture reference and verse
        Reference reference = new Reference("Proverbs 3:5-6");
        string verseText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";

        // Pass them into a Scripture object
        Scripture scripture = new Scripture(reference, verseText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplay());

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.IsFullyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplay());
                Console.WriteLine("\nAll words have been hidden. Program ending.");
                break;
            }
        }
    }
}