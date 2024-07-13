using System;
using QuizGame.Models;

namespace QuizGame.Utilities
{
    public class UserInterface
    {
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Quiz Game!");
        }

        public static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.Text);
            for (int i = 0; i < question.Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Options[i]}");
            }
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}