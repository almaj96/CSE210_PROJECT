


class Program
{
    static void Main(string[] args)
    {
        // Create a list of Scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
                new Reference("John", 3, 16)
            ),
            new Scripture(
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
                new Reference("Proverbs", 3, 5, 6)
            ),
            new Scripture(
                "I can do all things through Christ which strengtheneth me.",
                new Reference("Philippians", 4, 13)
            )
        };

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture currentScripture = scriptures[randomIndex];

        Console.WriteLine(currentScripture.Reference);
        Console.WriteLine(currentScripture.GetScriptureText());

        while (true)
        {
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                break;

            currentScripture.HideRandomWord();
            Console.WriteLine(currentScripture.GetScriptureText());
        }
    }
}