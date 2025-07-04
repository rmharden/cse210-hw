using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // This is here so I can have an initial space.
        Console.WriteLine("");

        Video video1 = new Video();
        video1._title = "'Introduction to Oil Painting'";
        video1._author = "Erastus Madsen";
        video1._length = 300;

        Video video2 = new Video();
        video2._title = "'Preparing a Canvas'";
        video2._author = "Matthias Krumeich";
        video2._length = 210;

        Video video3 = new Video();
        video3._title = "'Improving Hue Intensity in Color Mixing'";
        video3._author = "Hugh Falconer";
        video3._length = 1380;

        Comment comment1 = new Comment();
        comment1._commentName = "Sam";
        comment1._commentText = "Great Video!";

        Comment comment2 = new Comment();
        comment2._commentName = "Lilli";
        comment2._commentText = "Fantastic!";

        Comment comment3 = new Comment();
        comment3._commentName = "Edmund";
        comment3._commentText = "Wonderful!";

        Video displayVideos = new Video();
        displayVideos._videos.Add(video1);
        displayVideos._videos.Add(video2);
        displayVideos._videos.Add(video3);

        displayVideos.Display();


    }
}

/*
5. Functionality: Object Creation:
Program runs without errors. It correctly creates
at least 3 Video objects (including setting their
values), and for each video creates and sets at 
least 3 Comment objects (including setting their
values). The Video objects are stored in a list.

6. Functionality: Object Use:
Program runs without errors. It irterates through
a list of Video objects and for each one, and
diplays the title, author, length, and number of
comments (using the method) and for each video also
displays the comments for that video =(including
the commenter's name and text).

7. Style: Whitespace and File Organization:
Each class is defined in its own file and the 
name of the file exactly matches the class name.
Vertical and horizontal whitespace (blank lines, 
indentation, braces) are correct throughout the
program.

8: Style: Naming Conventions:
Classes and methods use TitleCase, member variables
use _underscoreCamelCase, local variables use
camelCase.
*/