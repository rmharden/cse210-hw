// I forgot to add the Assignment as a parent.
public class MathAssignment : Assignment
{
    // These attributes are used in both classes they are 
    // going to be part of the base now.
    // private string _studentName;
    // private string _topic;

    private string _textbookSection;
    private string _problems;

    // This is the constructor that stores each value:
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName,
        topic)// added the base in Step 4
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // This method is going to be apart of the base now
    // because it is used in both classes.
    /*
    public string GetSummary()
    {
        return "";
    }
    */

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}

/*

Class: MathAssignment

A Math assignment needs to store:
- the student's name
- the topic
- the textbook section
- the problems from that section

It has a constructor
- requires a value for each of the items that it stores

Assignment Summary Method that contains:
- Student's name
- Topic
- Display Method
    - Displays the math homeworl list
        -Section number and the problems

*/