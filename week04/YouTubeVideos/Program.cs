using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# in One Hour", "Programming Academy", 3600);
        Video video2 = new Video("Top 10 Programming Tips", "Code Guru", 1800);
        Video video3 = new Video("Understanding OOP Concepts", "Tech Explained", 2400);

        // Create comments and add them to each video's list
        video1.AddComment(new Comment("Alice", "Great Video, very helpful!"));
        video1.AddComment(new Comment("Bob", "I learned a lot, thank you!"));
        video1.AddComment(new Comment("Charlie", "Could you do one on advanced topics?"));
        video1.AddComment(new Comment("Bradley", "Haha! I love your humor in this. I don't know if anyone understood what you said but it was hilarious!"));

        video2.AddComment(new Comment("David", "Love the tips, especially #5!"));
        video2.AddComment(new Comment("Eve", "Amazing content as always!"));
        video2.AddComment(new Comment("Frank", "More videos like this, please."));

        video3.AddComment(new Comment("Grace", "This clarified a lot of my doubts."));
        video3.AddComment(new Comment("Hannah", "OOP is so much clearer now!"));
        video3.AddComment(new Comment("Ian", "Fantastic explanation!"));
        video3.AddComment(new Comment("Anomymous", "I still don't understand, it's very difficult for me... Could you make another video about it?"));

        // Populate video list
        List<Video> videos = new List<Video> {video1, video2, video3};

        // Iterate through the videos' details and display them
        foreach (var video in videos)
        {   
            Console.WriteLine();
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Iterate through videos to display comments on them
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}