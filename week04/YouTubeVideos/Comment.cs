public class Comment
{
    public string _commentName;

    public List<Video> _videos = new List<Video>();

    public void Display()
    {
        Console.WriteLine($"Name: {_commentName}");
        Console.WriteLine("Videos:");

        foreach (Video video in _videos)
        {
            video.Display();
        }
    }
}

/*
2.  Abstraction: Comment Class:
A Comment class exists that stores the name of
of the person and the text of the comment.
*/