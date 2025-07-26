public class Comment
{
    public string _commentAuthor { get; set; }
    public string _commentText { get; set; }

    public Comment(string name, string text)
    {
        _commentAuthor = name;
        _commentText = text;
    }
}