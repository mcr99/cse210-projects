using System;

public class Comment
{
    public string _commentName {get; set; }
    public string _commentText {get; set; }

    public Comment(string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;
    }
}