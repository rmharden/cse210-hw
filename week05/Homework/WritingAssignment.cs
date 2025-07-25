// I forgot to add the Assignment as a parent.
public class WritingAssignment : Assignment
{
    // These attributes are used in both classes they are 
    // going to be part of the base now.
    // private string _studentName;
    // private string _topic;

    private string _title;

    // this is the constructor with a base
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // This method is going to be apart of the base now
    // because it is used in both classes.
    /*
    public string GetSummary()
    {
        return "";
    }
    */

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}

/*
Class: WritingAssignment

Stores:
- student's name
- the topic
- title of the assignment

Constructor:
- requires a value for each item it stores
    - student's name
    - topic
    - title of the assignment

Method:
- A summary of the assignment that contains:
    - student name
    - topic
    - has a method to get the writing info
        - title
        - student's name
*/