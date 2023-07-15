using System;

public class Comment
{
    public string _username;
    public string _comment;

    public Comment(string username, string comment)
    {
        _username = username;
        _comment = comment;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"    User: {_username} says: {_comment}");
    }
}