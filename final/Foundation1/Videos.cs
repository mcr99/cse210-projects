using System;
using System.Collections.Generic;

public class Video
{
    public string _title {get; set; }
    public string _author{get; set; }
    public int _length {get; set; }
    public List<Comment> Comment {get; set; }


public Video (string title, string author, int length)
{
    _title = title;
    _author = author;
    _length = length;
    Comment = new List<Comment>();
}

public void AddComment(string username, string usertext)
{
    Comment.Add(new Comment(username, usertext));
}

public int GetNumberComments()
{
    return Comment.Count;
}
}