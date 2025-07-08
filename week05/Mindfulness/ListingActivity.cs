using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Xml.Linq;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {

    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    private List<string> userEntries = new List<string>();
    public string GetListFromUser()
    {
        Console.WriteLine("Type an entry or type 'quit' to finish");
        string userEntry = Console.ReadLine();
        userEntries.Add(userEntry);
        
        foreach (string e in userEntries)
        {
            Console.WriteLine(e);
        }
        return GetListFromUser();
    }
}