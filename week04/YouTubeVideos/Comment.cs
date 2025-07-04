using System.Collections.Generic;

public class Comment
{
    public string _commentName;
    public string _commentText;

    public List<Comment> _comments = new List<Comment>();

    public void DisplayComments()
    {
        Console.WriteLine(_commentName);
        Console.WriteLine(_commentText);

        foreach (Comment comment in _comments)
        {
            comment.DisplayComments();
        }
    }

}


/*
2.  Abstraction: Comment Class:
A Comment class exists that stores the name of
of the person and the text of the comment.
*/