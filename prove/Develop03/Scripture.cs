




public class Scripture
{
    public string Text { get; set; }
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(string text, Reference reference)
    {
        Text = text;
        Reference = reference;
        Words = new List<Word>();
        InitializeWords();
    }

    private void InitializeWords()
    {
        string[] wordArray = Text.Split(' ');
        foreach (string word in wordArray)
        {
            Words.Add(new Word(word, this));
        }
    }

    public string GetScriptureText()
    {
        string scriptureText = string.Join(" ", Words);
        return scriptureText;
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int randomIndex = random.Next(Words.Count);
        Words[randomIndex].IsHidden = true;
    }
}