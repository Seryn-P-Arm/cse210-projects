using System;

// Store comment name and text
public class Comment {
    private string _name;
    private string _text;

    public Comment(string name, string text) {
        _name = name;
        _text = text;
    }

// Getters
    public string GetCommenterName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }
}