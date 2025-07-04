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

        Comment video1Comment1 = new Comment();
        video1Comment1._commentName = "Sam";
        video1Comment1._commentText = "Great Video!";

        Comment video1Comment2 = new Comment();
        video1Comment2._commentName = "Lilli";
        video1Comment2._commentText = "Fantastic!";

        Comment video1Comment3 = new Comment();
        video1Comment3._commentName = "Edmund";
        video1Comment3._commentText = "Wonderful!";

        Video video2 = new Video();
        video2._title = "'Preparing a Canvas'";
        video2._author = "Matthias Krumeich";
        video2._length = 210;

        Comment video2Comment1 = new Comment();
        video2Comment1._commentName = "Sebastion";
        video2Comment1._commentText = "Lovely!";

        Comment video2Comment2 = new Comment();
        video2Comment2._commentName = "Russell";
        video2Comment2._commentText = "Very Cool!";

        Comment video2Comment3 = new Comment();
        video2Comment3._commentName = "Miyuki";
        video2Comment3._commentText = "I'm inspired!";

        Video video3 = new Video();
        video3._title = "'Improving Hue Intensity in Color Mixing'";
        video3._author = "Hugh Falconer";
        video3._length = 1380;

        Comment video3Comment1 = new Comment();
        video3Comment1._commentName = "Miyazaki";
        video3Comment1._commentText = "I never knew that about chroma color!";

        Comment video3Comment2 = new Comment();
        video3Comment2._commentName = "Em";
        video3Comment2._commentText = "I've learned a lot!";

        Comment video3Comment3 = new Comment();
        video3Comment3._commentName = "Frank";
        video3Comment3._commentText = "Thanks for the video!";

        Video displayVideos = new Video();
        displayVideos._videos.Add(video1);
        displayVideos._videos.Add(video2);
        displayVideos._videos.Add(video3);

        Comment displayComments = new Comment();
        displayComments._comments.Add(video1Comment1);
        displayComments._comments.Add(video1Comment2);
        displayComments._comments.Add(video1Comment3);
        displayComments._comments.Add(video2Comment1);
        displayComments._comments.Add(video2Comment2);
        displayComments._comments.Add(video2Comment3);
        displayComments._comments.Add(video3Comment1);
        displayComments._comments.Add(video3Comment2);
        displayComments._comments.Add(video3Comment3);


        displayVideos.Display();
        displayComments.DisplayComments();
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