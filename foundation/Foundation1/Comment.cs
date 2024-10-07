using System;
using System.Collections.Generic;

public class Comment
{
    private string _commentorName;
    private string _commentText;

    public Comment(string name, string text)
    {
        _commentorName = name;
        _commentText = text;
    }
    public string Display()
    {
        return $"{_commentorName}: {_commentText}";
    }
}