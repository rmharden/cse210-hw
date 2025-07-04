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
        //video1._comentName = "Linda";
        //video1._commentText = "Wonderful! I learned so much!";

        Video video2 = new Video();
        video2._title = "'Preparing a Canvas'";
        video2._author = "Matthias Krumeich";
        video2._length = 210;

        Video video3 = new Video();
        video3._title = "'Improving Intensity in Color Mixing'";
        video3._author = "Hugh Falconer";
        video3._length = 1380;

        Comment theComment = new Comment();
        theComment._commentName = "Sam";
        theComment._commentText = "Great Video!";

        //theComment._videos.Add(video1);
        //theComment._videos.Add(video2);
        //theComment._videos.Add(video3);

        //theComment.Display();
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