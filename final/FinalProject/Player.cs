namespace QuizGame.Models
{
    public class Player
    {
        public string Username { get; private set; }
        private string Password { get; set; }
        public int HighScore { get; private set; }

        public Player(string username, string password)
        {
            Username = username;
            Password = password;
            HighScore = 0;
        }

        public bool VerifyPassword(string inputPassword)
        {
            return Password == inputPassword;
        }

        public void UpdateHighScore(int newScore)
        {
            if (newScore > HighScore)
            {
                HighScore = newScore;
            }
        }
    }
}