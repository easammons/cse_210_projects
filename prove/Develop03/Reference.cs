

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private string _text;
    private int _verseEnd;

        public Reference(string book, int chapter, int verseNumber, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseNumber;
        _verseEnd = verseNumber;  // Same as start if single verse
        _text = text;
    }

    // Constructor for verse range
    public Reference(string book, int chapter, int verseStart, int verseEnd, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _text = text;
    }
    
    public string Text
    {
        get { return _text; }
    }

    public override string ToString()
    {
        string versePart = (_verseStart == _verseEnd)
            ? _verseStart.ToString()
            : $"{_verseStart}-{_verseEnd}";

        return $"{_book} {_chapter}:{versePart} - ";
    }


    
}