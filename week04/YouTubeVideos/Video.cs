public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Video Length: {_length}");
        Console.WriteLine(${Comments});
    }

    foreach (Comment comment in _comments)
    {
        comment.Display();
    }

}

/*
1.  Abstraction: Video Class:
A Video class exists and has a way to track
the title, author, and length.

3. Class Composition:
The Video class stores a list of Comment class
objects.

4. Class Behaviors:

The Video class contains a method that returns the
number of comments directly from the way comments
are stored (for example: returns the length of the
list.)
*/