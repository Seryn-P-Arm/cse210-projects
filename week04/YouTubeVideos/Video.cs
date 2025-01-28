using System;
using System.Net;

// Store video details, title, author, duration in seconds, and video's comments
public class Video {
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Getters
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    // Add comment to the list of comments
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Get length of the comments list
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Get lst of comments of the video
    public List<Comment> GetComments()
    {
        return _comments;
    }
}