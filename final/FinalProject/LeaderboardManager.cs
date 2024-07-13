using System;
using System.Collections.Generic;
using System.Linq;
using QuizGame.Models;

namespace QuizGame.Managers
{
    public class LeaderboardManager
    {
        private List<Player> leaderboard;

        public LeaderboardManager()
        {
            leaderboard = new List<Player>();
        }

        public void UpdateLeaderboard(Player player)
        {
            if (!leaderboard.Contains(player))
            {
                leaderboard.Add(player);
            }
            leaderboard = leaderboard.OrderByDescending(p => p.HighScore).ToList();
        }

        public void DisplayLeaderboard()
        {
            Console.WriteLine("Leaderboard:");
            for (int i = 0; i < leaderboard.Count && i < 10; i++)
            {
                Console.WriteLine($"{i + 1}. {leaderboard[i].Username} - {leaderboard[i].HighScore}");
            }
        }
    }
}