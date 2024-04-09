// has the responsibility to track the title, author, and length (in seconds) of the video. Each video also has responsibility to store a list of comments, and should have a method to return the number of comments.
public class Video
{
    // Attributes
    private string _title;
    private string _author;
    private int _lengthSeconds; 
    private List<Comment> _comments = new List<Comment>();

    // Constructors
    public Video()
    {

    }

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public Video(string title, string author, int lengthSeconds, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = comments;
    }
    
    // Methods
    public int CountComments()
    {
        int quantity = _comments.Count();
        return quantity;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthSeconds()
    {
        return _lengthSeconds;
    }

    public void MakeComment(string commentUser, string commentBody)
    { // Create a comment via a constructor and add it to _comments
        Comment newComment = new Comment(commentUser, commentBody);
        _comments.Add(newComment);
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentAttributes();
        }
    }
}