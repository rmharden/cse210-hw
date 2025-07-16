using System.Net.Sockets;

public class Person
{
    private string _first;
    private string _last;
    public Address _address;

    public string GetLastName()
    {
        return _last;
    }

    public void SetLastName(string newLastName)
    {
        _last = newLastName;
    }

    public string GetFormalName()
    {
        
    }
}