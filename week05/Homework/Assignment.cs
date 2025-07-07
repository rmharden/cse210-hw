public class Assignment
{
    private string _studentName;
    private string _topic;


    // This is a constructor that receives a student name
    // and the topic. It sets the member variables.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    
    public string GetSummary()
    {
        return _studentName + "-" + _topic;
    }
}