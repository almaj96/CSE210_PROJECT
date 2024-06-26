using System;
using System.Collections.Generic;

public class WriteEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    private List<string> Prompts { get; set; }
    private Random random = new Random();

    public WriteEntry()
    {
        Prompts = new List<string>
        {
            "What was the highlight of your day?",
            "What did you learn today?",
            "What are you grateful for today?",
            "What challenges did you face today?",
            "How did you practice self-care today?"
        };
    }

    public void StartEntry()
    {
        AskForDate();
        GeneratePrompt();
        GetUserResponse();
    }

    public void AskForDate()
    {
        Console.Write("Please enter the date for the entry (YYYY-MM-DD): ");
        Date = Console.ReadLine();
    }

    private void GeneratePrompt()
    {
        int randomIndex = random.Next(Prompts.Count);
        Prompt = Prompts[randomIndex];
        Console.WriteLine($"Prompt: {Prompt}");
    }

    private void GetUserResponse()
    {
        Console.Write("Write your response: ");
        Response = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        Console.WriteLine("\nEntry Details:");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }
}
