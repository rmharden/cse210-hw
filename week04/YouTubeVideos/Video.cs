public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    List<Comment> _comments = new List<Comment>();

    public int GetCommentCount(List<Comment> comments)
    {
        return 0;
    }

    public Video(string _title, string _author, int _lengthSeconds)
    {

    }

    public void DisplayAll()
    {
        
    }
}