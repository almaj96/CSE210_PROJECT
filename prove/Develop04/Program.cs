class Program
{
   static void Main(string[] args)
   {
       List<Activity> activities = new List<Activity>
       {
           new BreathingActivity(),
           new ReflectionActivity(),
           new ListingActivity()
       };

       while (true)
       {
           Console.WriteLine("\nMenu:");
           for (int i = 0; i < activities.Count; i++)
           {
               Console.WriteLine($"{i + 1}. {activities[i].name}");
           }
           Console.WriteLine("4. Exit");
           Console.Write("Select an activity: ");

           int choice;
           if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= activities.Count + 1)
           {
               if (choice == activities.Count + 1)
               {
                   break;
               }

               Activity selectedActivity = activities[choice - 1];
               selectedActivity.Start();
               selectedActivity.Perform();
               selectedActivity.End();
           }
           else
           {
               Console.WriteLine("Invalid choice. Please try again.");
           }
       }
   }
}