public class Word
{
    private string text;
    private bool isHidden;

    // Constructor
    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    // Getters
    public string GetText()
    {
        return text;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    // Hide the word (replace with underscores)
    public void Hide()
    {
        isHidden = true;
    }

    // Show the word (reset to visible)
    public void Show()
    {
        isHidden = false;
    }

    // Display the word, either hidden or visible
    public string Display()
    {
        return isHidden ? new string('_', text.Length) : text;
    }
}