public class Comment
{
    // Attributes
    private string _user;
    private string _body;

    // Constructor
    public Comment()
    {

    }

    public Comment(string user, string body)
    {
        _user = user;
        _body = body;
    }

    // Methods
    public void DisplayCommentAttributes()
    {
        Console.WriteLine($"    {_user}\n    {_body}\n");
    }
}