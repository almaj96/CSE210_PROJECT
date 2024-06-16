using System;
using System.Collections.Generic;
using System.Threading;

// Base class for all activities
abstract class Activity
{
   public string name;
   protected string description;
   protected int duration;

   public Activity(string name, string description)
   {
       this.name = name;
       this.description = description;
   }

   public void Start()
   {
       Console.WriteLine($"\nStarting {name} activity...");
       Console.WriteLine(description);
       Console.Write("Enter the duration in seconds: ");
       duration = int.Parse(Console.ReadLine());
       Console.WriteLine("Get ready...");
       DisplayAnimation(3);
   }

   public void End()
   {
       Console.WriteLine("\nGood job!");
       DisplayAnimation(3);
       Console.WriteLine($"You completed the {name} activity for {duration} seconds.");
       DisplayAnimation(3);
   }

   protected void DisplayAnimation(int seconds)
   {
       for (int i = 0; i < seconds; i++)
       {
           Console.Write(".");
           Thread.Sleep(1000);
       }
       Console.WriteLine();
   }

   public abstract void Perform();
}

// Breathing Activity
class BreathingActivity : Activity
{
   public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
   {
   }

   public override void Perform()
   {
       int elapsedTime = 0;
       while (elapsedTime < duration)
       {
           Console.WriteLine("Breathe in...");
           DisplayAnimation(4);
           Console.WriteLine("Breathe out...");
           DisplayAnimation(6);
           elapsedTime += 10;
       }
   }
}
