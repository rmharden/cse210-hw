using System.Net.Sockets;

public class Person
{
    private string _first;
    private string _last;
    public Address _address;

    public string GetFirstName()
    {
        return _first;
    }
    public string GetLastName()
    {
        return _last;
    }
    public void SetFirstName(string newFirstName)
    {
        _first = newFirstName;
    }

    public void SetLastName(string newLastName)
    {
        _last = newLastName;
    }

    public string GetFormalName()
    {
        return GetLastName() + ", " + _first;
    }

    // public string GetFullName()
    // This overrides this function. We do that by making it virtual
    public virtual string GetFullName()
    {
        return _first + " " + _last;
    }
}