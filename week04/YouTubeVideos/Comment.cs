public class Comment
{
    private string _commentPerson;
    private string _commentText;

    public void Display()
    {
        Console.WriteLine($"Name: {_commentPerson}, Comment: {_commentText}");
    }

}

/*
2.  Abstraction: Comment Class:
A Comment class exists that stores the name of
of the person and the text of the comment.
*/