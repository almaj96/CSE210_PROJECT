using System;
using System.Collections.Generic;

namespace QuizGame.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectOptionIndex { get; set; }
        public string Category { get; set; }
        public int TimeLimitInSeconds { get; set; }

        public Question(string text, List<string> options, int correctOptionIndex, string category, int timeLimitInSeconds)
        {
            Text = text;
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
            Category = category;
            TimeLimitInSeconds = timeLimitInSeconds;
        }

        public bool CheckAnswer(int selectedOptionIndex)
        {
            return selectedOptionIndex == CorrectOptionIndex;
        }
    }
}