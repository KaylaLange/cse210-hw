using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {
       return _comments.Count;
    }

    public string DisplayAll()
    {
        var output = $"Video: {_title} | By: {_author} | Length: {_videoLength} seconds | Number of Comments: {_comments.Count}\n";
        
        foreach (var comment in _comments)
        {
            output += comment.Display() + "\n";
        }

        return output;
    }
}