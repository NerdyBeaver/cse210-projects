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
