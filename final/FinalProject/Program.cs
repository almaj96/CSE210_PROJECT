using System;
using QuizGame.Models;
using QuizGame.Managers;
using QuizGame.Utilities;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager dbManager = new DatabaseManager();
            LeaderboardManager leaderboardManager = new LeaderboardManager();
            GameManager gameManager = new GameManager(dbManager, leaderboardManager);

            UserInterface.DisplayWelcomeMessage();

            bool exit = false;
            while (!exit)
            {
                string choice = UserInterface.GetUserInput("1. Register\n2. Login\n3. Play as Guest\n4. View Leaderboard\n5. Exit\nEnter your choice: ");

                switch (choice)
                {
                    case "1":
                        RegisterPlayer(gameManager);
                        break;
                    case "2":
                        if (LoginPlayer(gameManager))
                        {
                            PlayGame(gameManager);
                        }
                        break;
                    case "3":
                        PlayGame(gameManager);
                        break;
                    case "4":
                        leaderboardManager.DisplayLeaderboard();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        UserInterface.DisplayMessage("Invalid choice. Please try again.");
                        break;
                }
            }

            UserInterface.DisplayMessage("Thank you for playing Quiz Game!");
        }

        static void RegisterPlayer(GameManager gameManager)
        {
            string username = UserInterface.GetUserInput("Enter username: ");
            string password = UserInterface.GetUserInput("Enter password: ");
            
            if (gameManager.RegisterPlayer(username, password))
            {
                UserInterface.DisplayMessage("Registration successful!");
            }
            else
            {
                UserInterface.DisplayMessage("Registration failed. Username may already exist.");
            }
        }

        static bool LoginPlayer(GameManager gameManager)
        {
            string username = UserInterface.GetUserInput("Enter username: ");
            string password = UserInterface.GetUserInput("Enter password: ");

            if (gameManager.LoginPlayer(username, password))
            {
                UserInterface.DisplayMessage("Login successful!");
                return true;
            }
            else
            {
                UserInterface.DisplayMessage("Login failed. Please check your username and password.");
                return false;
            }
        }

        static void PlayGame(GameManager gameManager)
        {
            int numberOfQuestions = int.Parse(UserInterface.GetUserInput("Enter the number of questions you want to answer: "));
            gameManager.StartNewQuiz(numberOfQuestions);

            while (gameManager.HasNextQuestion())
            {
                Question currentQuestion = gameManager.GetNextQuestion();
                UserInterface.DisplayQuestion(currentQuestion);

                QuizTimer timer = new QuizTimer(currentQuestion.TimeLimitInSeconds);
                timer.Start();

                string userAnswer = UserInterface.GetUserInput("Enter your answer (1-4): ");

                if (timer.IsTimeUp())
                {
                    UserInterface.DisplayMessage("Time's up! Moving to the next question.");
                    continue;
                }

                if (int.TryParse(userAnswer, out int answerIndex) && answerIndex >= 1 && answerIndex <= 4)
                {
                    bool isCorrect = gameManager.AnswerQuestion(answerIndex - 1);
                    UserInterface.DisplayMessage(isCorrect ? "Correct!" : "Incorrect.");
                }
                else
                {
                    UserInterface.DisplayMessage("Invalid input. Skipping this question.");
                }
            }

            int finalScore = gameManager.EndQuiz();
            UserInterface.DisplayMessage($"Quiz completed! Your final score is: {finalScore}");
        }
    }
}