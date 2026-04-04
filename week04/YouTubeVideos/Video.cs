using System;
using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;
    public List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _videoLength = length;
        _comments = new List<Comment>();
    }
    public int GetCommentNumber()
    {
        return _comments.Count;
    }
}
