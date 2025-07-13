using System;
using System.Collections.Generic;

public class Video
{
    // Attributes to track video information
    public string _title;
    public string _author;
    public int _lengthInSeconds; // Length of the video in seconds
    public List<Comment> _comments = new List<Comment>(); // List to hold comments for this video

    // Method to add a comment to this video's list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to return the number of comments on this video
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display all video details and its comments
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title} — Author: {_author} — Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment(); // Calls the comment's own display method
        }
        Console.WriteLine(""); // Add an empty line for readability between videos
    }
}

public class Comment
{
    // Attributes to track comment information
    public string _commenterName;
    public string _commentText;

    // Method to display the comment's name and text
    public void DisplayComment()
    {
        Console.WriteLine($"  - {_commenterName}: \"{_commentText}\"");
    }
}

public class Program1
{
    static void Main(string[] args)
    {
        // Create a list to hold all videos
        List<Video> videoList = new List<Video>();

        // --- Video 1 ---
        Video video1 = new Video();
        video1._title = "Introduction to C# Classes";
        video1._author = "CodeMaster Tutorials";
        video1._lengthInSeconds = 1200; // 20 minutes

        // Add comments to Video 1
        Comment comment1_1 = new Comment();
        comment1_1._commenterName = "Alice";
        comment1_1._commentText = "Great explanation! Very clear.";
        video1.AddComment(comment1_1);

        Comment comment1_2 = new Comment();
        comment1_2._commenterName = "BobTheBuilder";
        comment1_2._commentText = "Helped me understand abstraction much better.";
        video1.AddComment(comment1_2);

        Comment comment1_3 = new Comment();
        comment1_3._commenterName = "CSharpFan";
        comment1_3._commentText = "Looking forward to more videos!";
        video1.AddComment(comment1_3);

        videoList.Add(video1); // Add video1 to the list

        // --- Video 2 ---
        Video video2 = new Video();
        video2._title = "Basics of Object-Oriented Programming";
        video2._author = "Programming Guru";
        video2._lengthInSeconds = 1800; // 30 minutes

        // Add comments to Video 2
        Comment comment2_1 = new Comment();
        comment2_1._commenterName = "Eve";
        comment2_1._commentText = "A must-watch for beginners!";
        video2.AddComment(comment2_1);

        Comment comment2_2 = new Comment();
        comment2_2._commenterName = "DevStudent";
        comment2_2._commentText = "The examples were really helpful.";
        video2.AddComment(comment2_2);

        videoList.Add(video2); // Add video2 to the list

        // --- Video 3 ---
        Video video3 = new Video();
        video3._title = "Advanced C# Techniques";
        video3._author = "ProCoder";
        video3._lengthInSeconds = 2700; // 45 minutes

        // Add comments to Video 3
        Comment comment3_1 = new Comment();
        comment3_1._commenterName = "GeekGirl";
        comment3_1._commentText = "Mind blown! So much to learn.";
        video3.AddComment(comment3_1);

        Comment comment3_2 = new Comment();
        comment3_2._commenterName = "TechEnthusiast";
        comment3_2._commentText = "Highly recommend for experienced devs.";
        video3.AddComment(comment3_2);

        Comment comment3_3 = new Comment();
        comment3_3._commenterName = "Newbie";
        comment3_3._commentText = "A bit too advanced for me right now, but good info!";
        video3.AddComment(comment3_3);
        
        Comment comment3_4 = new Comment();
        comment3_4._commenterName = "SeniorDev";
        comment3_4._commentText = "Excellent coverage of complex topics.";
        video3.AddComment(comment3_4);

        videoList.Add(video3); // Add video3 to the list

        Console.WriteLine("--- YouTube Video Collection ---");
        Console.WriteLine("");

        // Iterate through the list of videos and display their details
        foreach (Video video in videoList)
        {
            video.DisplayVideoDetails();
        }
    }
}