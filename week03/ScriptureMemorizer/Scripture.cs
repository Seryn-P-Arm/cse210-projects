public class Scripture
{
    private ScriptureReference reference;
    private List<Word> words;

    // Constructor
    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Reset all words to visible (no words hidden)
    public void ResetHiddenWords()
    {
        foreach (var word in words)
        {
            word.Show(); // Reset each word to visible
        }
    }

    // Display the scripture
    public string Display()
    {
        string scriptureText = string.Join(" ", words.Select(word => word.Display()));
        return $"{reference.ToString()}\n{scriptureText}";
    }

    // Hide random words
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count > 0)
        {
            for (int i = 0; i < count && visibleWords.Count > 0; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }
    }

    // Check if all words are hidden
    public bool IsFullyHidden()
    {
        return words.All(word => word.IsHidden());
    }
}