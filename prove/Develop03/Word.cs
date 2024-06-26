public class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }
    private Scripture parentScripture;

    public Word(string text, Scripture parentScripture)
    {
        Text = text;
        IsHidden = false;
        this.parentScripture = parentScripture;
    }

    public override string ToString()
    {
        if (IsHidden)
        {
            bool allWordsHidden = true;
            foreach (Word word in parentScripture.Words)
            {
                if (!word.IsHidden)
                {
                    allWordsHidden = false;
                    break;
                }
            }

            if (allWordsHidden)
            {
                Console.WriteLine("Congratulations! You have memorized the scripture.");
                Environment.Exit(0);
            }

            return new string('_', Text.Length);
        }
        else
        {
            return Text;
        }
    }
}