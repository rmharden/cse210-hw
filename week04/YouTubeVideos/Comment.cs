using System.Collections.Generic;

public class Comment
{
    public string _commentName;
    public string _commentText;

    // I don't think this should be here, but I couldn't
    // get it to work in the Video class.

    // It doesn't display with the corresponding video.
    // I don't know how to link the videos with comments.
    // How do you do that with separate classes and lists??
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