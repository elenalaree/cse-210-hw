using System;
using System.Reflection.Metadata.Ecma335;

public class Video
{
    public List<Comment> comments;
    private string _title;
    private string _author;
    private int _length;
    private int _commentCount;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        comments = new List<Comment>();
    }
    public void ListComment(Comment newComment)
    {
        comments.Add(newComment);
    }

    public void DisplayVideos()
    {
            _commentCount = comments.Count;
            Console.WriteLine($"Video: {_title}, Author: {_author}, Length: {_length} seconds, Comments: {_commentCount}");
            foreach(Comment comment in comments){
                comment.DisplayComments();
            }
            Console.WriteLine();
    }
}