using System.Collections.Generic;

public class YouTubeVideos
{
    public string _videoTitle { get; set; }
    public string _videoAuthor { get; set; }
    public int _videoLength { get; set; }
    public List<Comment> _videoComments { get; set; }

    public YouTubeVideos(string title, string author, int length)
    {
        _videoTitle = title;
        _videoAuthor = author;
        _videoLength = length;
        _videoComments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _videoComments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _videoComments.Count;
    }
}