class ListingActivity : Activity
{
   private List<string> prompts = new List<string>
   {
       "Who are people that you appreciate?",
       "What are personal strengths of yours?",
       "Who are people that you have helped this week?",
       "When have you felt the Holy Ghost this month?",
       "Who are some of your personal heroes?"
   };

   public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
   {
   }

   public override void Perform()
   {
       Random random = new Random();
       string prompt = prompts[random.Next(prompts.Count)];
       Console.WriteLine($"\n{prompt}");

       Console.WriteLine("Get ready...");
       DisplayAnimation(5);

       List<string> items = new List<string>();
       int elapsedTime = 0;
       while (elapsedTime < duration)
       {
           Console.Write("> ");
           string item = Console.ReadLine();
           if (!string.IsNullOrWhiteSpace(item))
           {
               items.Add(item);
           }
           elapsedTime += 5;
       }

       Console.WriteLine($"\nYou listed {items.Count} items.");
       foreach (string item in items)
       {
           Console.WriteLine(item);
       }
   }
}