using System;
public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public void Display()
    {
        Console.WriteLine($"Video: {_title} by: {_author}, Video Length: {_length}");
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