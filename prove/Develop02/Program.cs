using System;

namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            JournalManager journalManager = new JournalManager();
            bool done = false;
            while (!done)
        
            {
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        journalManager.Write();
                        break;
                    case "2":
                        journalManager.Display();
                        break;
                    case "3":
                        journalManager.Save();
                        break;
                    case "4":
                        journalManager.Load();
                        break;
                    case "5":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}