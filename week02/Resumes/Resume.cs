public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        //used the example for blings to know how to write this.
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}