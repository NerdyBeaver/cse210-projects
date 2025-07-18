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
