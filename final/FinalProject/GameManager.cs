using System;
using System.Collections.Generic;
using QuizGame.Models;

namespace QuizGame.Managers
{
    public class GameManager
    {
        private DatabaseManager dbManager;
        private LeaderboardManager leaderboardManager;
        private Player currentPlayer;
        private List<Question> currentQuizQuestions;
        private int currentQuestionIndex;
        private int currentScore;

        public GameManager(DatabaseManager dbManager, LeaderboardManager leaderboardManager)
        {
            this.dbManager = dbManager;
            this.leaderboardManager = leaderboardManager;
        }

        public bool RegisterPlayer(string username, string password)
        {
            if (dbManager.GetPlayer(username) == null)
            {
                Player newPlayer = new Player(username, password);
                dbManager.AddPlayer(newPlayer);
                return true;
            }
            return false;
        }

        public bool LoginPlayer(string username, string password)
        {
            Player player = dbManager.GetPlayer(username);
            if (player != null && player.VerifyPassword(password))
            {
                currentPlayer = player;
                return true;
            }
            return false;
        }

        public void StartNewQuiz(int numberOfQuestions)
        {
            List<Question> allQuestions = dbManager.GetQuestions();
            currentQuizQuestions = new List<Question>();
            Random rnd = new Random();

            for (int i = 0; i < numberOfQuestions && allQuestions.Count > 0; i++)
            {
                int index = rnd.Next(allQuestions.Count);
                currentQuizQuestions.Add(allQuestions[index]);
                allQuestions.RemoveAt(index);
            }

            currentQuestionIndex = 0;
            currentScore = 0;
        }

        public bool HasNextQuestion()
        {
            return currentQuestionIndex < currentQuizQuestions.Count;
        }

        public Question GetNextQuestion()
        {
            if (HasNextQuestion())
            {
                return currentQuizQuestions[currentQuestionIndex++];
            }
            return null;
        }

        public bool AnswerQuestion(int selectedOptionIndex)
        {
            Question currentQuestion = currentQuizQuestions[currentQuestionIndex - 1];
            bool isCorrect = currentQuestion.CheckAnswer(selectedOptionIndex);
            if (isCorrect)
            {
                currentScore++;
            }
            return isCorrect;
        }

        public int EndQuiz()
        {
            if (currentPlayer != null)
            {
                currentPlayer.UpdateHighScore(currentScore);
                dbManager.UpdatePlayer(currentPlayer);
                leaderboardManager.UpdateLeaderboard(currentPlayer);
            }
            return currentScore;
        }
    }
}