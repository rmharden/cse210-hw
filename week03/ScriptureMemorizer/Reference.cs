using System;
using System.Collections.Concurrent;
using System.Data;

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

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
   
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse} and {_book} {_chapter}:{_endVerse}-{_startVerse}";       
    }
}