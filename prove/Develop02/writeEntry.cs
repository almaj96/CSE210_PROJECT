using System;

namespace Journal
{
    class WriteEntry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        public WriteEntry(string prompt, string response)
        {
            Prompt = prompt;
            Response = response;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Date:d} - {Prompt}\n{Response}\n";
        }
    }
}