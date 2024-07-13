using System.Threading;

namespace QuizGame.Utilities
{
    public class QuizTimer
    {
        private int timeLimit;
        private bool timeUp;

        public QuizTimer(int timeLimitInSeconds)
        {
            timeLimit = timeLimitInSeconds;
            timeUp = false;
        }

        public void Start()
        {
            Thread timerThread = new Thread(RunTimer);
            timerThread.Start();
        }

        private void RunTimer()
        {
            for (int i = timeLimit; i > 0; i--)
            {
                Thread.Sleep(1000);
            }
            timeUp = true;
        }

        public bool IsTimeUp()
        {
            return timeUp;
        }
    }
}