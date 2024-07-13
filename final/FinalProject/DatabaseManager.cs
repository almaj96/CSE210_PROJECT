using System;
using System.Collections.Generic;
using QuizGame.Models;

namespace QuizGame.Managers
{
    public class DatabaseManager
    {
        private List<Question> questions;
        private List<Player> players;

        public DatabaseManager()
        {
            questions = new List<Question>();
            players = new List<Player>();
            InitializeSampleData();
        }

        private void InitializeSampleData()
        {
            // Add sample questions
            questions.Add(new Question("What is the capital of France?", new List<string> { "London", "Berlin", "Paris", "Madrid" }, 2, "Geography", 30));
            questions.Add(new Question("Who painted the Mona Lisa?", new List<string> { "Van Gogh", "Da Vinci", "Picasso", "Rembrandt" }, 1, "Art", 30));
            
            // Add more sample questions...

            // Add sample players
            players.Add(new Player("John", "password123"));
            players.Add(new Player("Alice", "securepass"));
        }

        public List<Question> GetQuestions()
        {
            return questions;
        }

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public Player GetPlayer(string username)
        {
            return players.Find(p => p.Username == username);
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void UpdatePlayer(Player player)
        {
            int index = players.FindIndex(p => p.Username == player.Username);
            if (index != -1)
            {
                players[index] = player;
            }
        }
    }
}