using System;

public class ScriptureReference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int? endVerse;

    // Constructor for single verse
    public ScriptureReference(string book, int chapter, int startVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = null;
    }

    // Constructor for verse range
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    // Getters
    public string GetBook()
    {
        return book;
    }

    public int GetChapter()
    {
        return chapter;
    }

    public int GetStartVerse()
    {
        return startVerse;
    }

    public int? GetEndVerse()
    {
        return endVerse;
    }

    // ToString method for displaying the reference
    public override string ToString()
    {
        if (endVerse.HasValue)
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
        return $"{book} {chapter}:{startVerse}";
    }
}