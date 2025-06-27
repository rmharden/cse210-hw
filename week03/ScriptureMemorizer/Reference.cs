using System;
using System.Collections.Concurrent;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

    public Reference()
    {
        _book = "";
        _chapter = 0;
        _verse = 0;
        _startVerse = 0;
        _endVerse = 0;
    }

    public string GetDisplayText()
    {
        string text = $"{_book} {_chapter}:{_verse}";
        return text;
    }
}