using System;
using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public List<Video> _videos = new List<Video>();

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author}");
        Console.WriteLine($"Video Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {_comments.Count}");
        Console.WriteLine("");

        foreach (Video video in _videos)
        {
            video.Display();
        }

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